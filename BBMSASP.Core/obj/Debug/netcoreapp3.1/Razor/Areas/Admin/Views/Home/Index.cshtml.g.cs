#pragma checksum "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677ef2f374ed6bb6564faa77ce2d914096150f82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\_ViewImports.cshtml"
using BBMSASP.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\_ViewImports.cshtml"
using BBMSASP.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677ef2f374ed6bb6564faa77ce2d914096150f82", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f8f806aa9e48203df9a96bc3436dd44413aaac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BBMSASP.Core.Areas.Admin.Models.DonorCounterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 14 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-6\">\r\n            <!-- small box -->\r\n            <div class=\"small-box bg-info\">\r\n                <div class=\"inner\">\r\n                    <h3>");
#nullable restore
#line 21 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.APositive);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>A+</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 33 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.BPositive);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>B+</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 45 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ABPositive);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                </div>
                <div class=""icon"">
                    <h3>AB+</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 58 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.OPositive);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>O+</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
    </div>
    <div class=""row"">
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 72 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ANegative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>A-</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 84 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.BNegative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>B-</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 96 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ABNegative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                </div>
                <div class=""icon"">
                    <h3>AB-</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 109 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ONegative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>O-</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
    </div>
    <div class=""row"">
        <div class=""col-lg-4 col-4"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 123 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.TotalDonor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>Total Donors</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-4 col-4"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 135 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.TotalRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>Total Request</h3>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-4"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 146 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.PendingRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"icon\">\r\n                    <h3>Pending Request</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 155 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 157 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
 if (User.IsInRole("Donor"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-lg-6 col-6\">\r\n            <!-- small box -->\r\n            <div class=\"small-box bg-info\">\r\n                <div class=\"inner\">\r\n                    <h3>");
#nullable restore
#line 164 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.TotalRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <div class=""icon"">
                    <h3>Total Request</h3>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-6 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 176 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.TotalRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"icon\">\r\n                    <h3>Active Blood Request</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 185 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Areas\Admin\Views\Home\Index.cshtml"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BBMSASP.Core.Areas.Admin.Services.IProfileService donorProfile { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BBMSASP.Core.Areas.Admin.Models.DonorCounterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591