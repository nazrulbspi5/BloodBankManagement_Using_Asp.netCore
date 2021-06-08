#pragma checksum "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ce903620ab90d037e837e6ae4feb26735decfb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\_ViewImports.cshtml"
using BBMSASP.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\_ViewImports.cshtml"
using BBMSASP.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce903620ab90d037e837e6ae4feb26735decfb2", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f8f806aa9e48203df9a96bc3436dd44413aaac", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""blog"">
    <div class=""container"">
        <div class=""row text-center clearfix"">
            <div class=""col-sm-8 col-sm-offset-2"">
                <h2 class=""title-one"">Blog</h2>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 10 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6\">\r\n                    <div class=\"single-blog\">\r\n                        <img src=\"images/blog/1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 482, "\"", 488, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <h2>");
#nullable restore
#line 15 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <ul class=\"post-meta\">\r\n                            <li><i class=\"fa fa-pencil-square-o\"></i><strong> Posted By:</strong> ");
#nullable restore
#line 17 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                                                                             Write(item.EntryBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-clock-o\"></i><strong> Posted On:</strong> ");
#nullable restore
#line 18 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                                                                     Write(item.PostDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <div class=\"blog-content\">\r\n                            <p>\r\n");
#nullable restore
#line 22 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                  
                                    if (@item.BlogContent.Length > 690)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                   Write(item.BlogContent.ToString().Substring(0, 690));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                                                                      ;
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                   Write(item.BlogContent.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                                                                    ;
                                    }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\r\n\r\n                    </div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1540, "\"", 1547, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-detail"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-detail"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2106, "\"", 2112, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <h2>");
#nullable restore
#line 43 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                               Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <p>");
#nullable restore
#line 44 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
                              Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Blog\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</section> <!--/#blog-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
