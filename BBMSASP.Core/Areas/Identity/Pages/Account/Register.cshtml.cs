using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web.Helpers;
using BBMSASP.Core.Data;
using BBMSASP.Core.Models;
using BBMSASP.Core.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace BBMSASP.Core.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IMailService _emailService;
        private readonly ApplicationDbContext _dbContext;
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, IMailService mailService, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
            _emailSender = emailSender;
            _dbContext = dbContext;
            _emailService = mailService;

        }

        [BindProperty]
        public InputModel Input { get; set; }
        //public DonorModel Input { get; set; }
        public string Message { get; set; } = "";
        public string Type { get; set; }
        public string ReturnUrl { get; set; }
        public List<BloodGroup> BloodGroupList { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public List<DivisionModel> DivisionList { get; set; }
        public List<DistrictModel> DistrictList { get; set; }
        public List<StatusModel> StatusList { get; set; }
        public class StatusModel
        {
            public string Status { get; set; }
        }
        public class InputModel : DonorModel
        {
           
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password *")]
            public string Password { get; set; }
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            BindDropdownList();
         
        }
        public void BindDropdownList()
        {
            BloodGroupList = _dbContext.BloodGroups.ToList();
            DivisionList = _dbContext.Divisions.ToList();
            List<StatusModel> status = new List<StatusModel>() {
                new StatusModel() { Status="Donate blood."},
                new StatusModel() { Status="If urgent, I can donate."},
                new StatusModel() { Status="Not interested yet, Donate in future."}
            };
            StatusList = status;
        }
      
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
           
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var userExist = await _userManager.FindByNameAsync(Input.UserName.ToLower());
                if (userExist == null)
                {
                    var user = new IdentityUser { UserName = Input.UserName.ToLower(), Email = Input.Email, EmailConfirmed = true };
                    var result = await _userManager.CreateAsync(user, Input.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Donor");
                        _logger.LogInformation("User created a new account with password.");

                        var donorModel = new DonorModel
                        {
                            UserName = Input.UserName.ToLower(),
                            DonorName = Input.DonorName,
                            Email = Input.Email,
                            Status = Input.Status,
                            Gender = Input.Gender,
                            BloodGroupId = Input.BloodGroupId,
                            DateOfBirth = Input.DateOfBirth,
                            ContactNumber = Input.ContactNumber,
                            LastDonationDate = Input.LastDonationDate,
                            DivisionId = Input.DivisionId,
                            DistrictId = Input.DistrictId,
                            UpazilaId = Input.UpazilaId
                        };
                        _dbContext.Donors.Add(donorModel);
                        var isSuccess = _dbContext.SaveChanges();
                        Message = "Registration successfull.";
                        Type = "Success";
                        //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        //var callbackUrl = Url.Page(
                        //    "/Account/ConfirmEmail",
                        //    pageHandler: null,
                        //    values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        //    protocol: Request.Scheme);
                        await _emailService.SendEmailAsync(Input.Email, "Registration Successfully", "<p>Dear " + Input.DonorName + ",<br> Your registration successfully completed, Now you can access your donor panel<br><br>Thanks<br>CTG BLOOD BANK</p>");


                        //await _emailService.SendEmailAsync(Input.Email, "Confirm your email",
                        //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        //if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        //{
                        //    return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                        //}
                        //else
                        //{
                        //    await _signInManager.SignInAsync(user, isPersistent: false);
                        //    return LocalRedirect(returnUrl);
                        //}

                        Input = new InputModel();
                    }
                    else
                    {
                        Message = result.Errors.ToString();
                        Type = "Error";
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                   
                }
                else
                {
                    Message = "UserName '"+Input.UserName+"' Already exist, try another username.";
                    Type = "Error";
                }
                
            }
            BindDropdownList();
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
