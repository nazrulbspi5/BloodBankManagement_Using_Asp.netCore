#pragma checksum "F:\Web Project\University Project\BBMS\BBMSASP.Core\Views\Shared\_blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744b54a5d678e7acf539b6abd5d2b33780c29111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__blog), @"mvc.1.0.view", @"/Views/Shared/_blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744b54a5d678e7acf539b6abd5d2b33780c29111", @"/Views/Shared/_blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f8f806aa9e48203df9a96bc3436dd44413aaac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""blog"">
    <div class=""container"">
        <div class=""row text-center clearfix"">
            <div class=""col-sm-8 col-sm-offset-2"">
                <h2 class=""title-one"">Our Blog</h2>
                <p class=""blog-heading"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-4"">
                <div class=""single-blog"">
                    <img src=""images/blog/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 583, "\"", 589, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h2>Lorem ipsum dolor sit amet</h2>
                    <ul class=""post-meta"">
                        <li><i class=""fa fa-pencil-square-o""></i><strong> Posted By:</strong> John</li>
                        <li><i class=""fa fa-clock-o""></i><strong> Posted On:</strong> Apr 15 2014</li>
                    </ul>
                    <div class=""blog-content"">
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1214, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-detail"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-detail"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1773, "\"", 1779, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <h2>Lorem ipsum dolor sit amet</h2>
                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"single-blog\">\r\n                    <img src=\"images/blog/2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3033, "\"", 3039, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h2>Lorem ipsum dolor sit amet</h2>
                    <ul class=""post-meta"">
                        <li><i class=""fa fa-pencil-square-o""></i><strong> Posted By:</strong> John</li>
                        <li><i class=""fa fa-clock-o""></i><strong> Posted On:</strong> Apr 15 2014</li>
                    </ul>
                    <div class=""blog-content"">
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3664, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-two"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-two"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4217, "\"", 4223, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <h2>Lorem ipsum dolor sit amet</h2>
                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"single-blog\">\r\n                    <img src=\"images/blog/3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5477, "\"", 5483, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h2>Lorem ipsum dolor sit amet</h2>
                    <ul class=""post-meta"">
                        <li><i class=""fa fa-pencil-square-o""></i><strong> Posted By:</strong> John</li>
                        <li><i class=""fa fa-clock-o""></i><strong> Posted On:</strong> Apr 15 2014</li>
                    </ul>
                    <div class=""blog-content"">
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 6101, "\"", 6108, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-three"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-three"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6665, "\"", 6671, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <h2>Lorem ipsum dolor sit amet</h2>
                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"single-blog\">\r\n                    <img src=\"images/blog/3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7925, "\"", 7931, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h2>Lorem ipsum dolor sit amet</h2>
                    <ul class=""post-meta"">
                        <li><i class=""fa fa-pencil-square-o""></i><strong> Posted By:</strong> John</li>
                        <li><i class=""fa fa-clock-o""></i><strong> Posted On:</strong> Apr 15 2014</li>
                    </ul>
                    <div class=""blog-content"">
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 8549, "\"", 8556, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-four"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-four"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9111, "\"", 9117, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <h2>Lorem ipsum dolor sit amet</h2>
                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"single-blog\">\r\n                    <img src=\"images/blog/2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 10371, "\"", 10377, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h2>Lorem ipsum dolor sit amet</h2>
                    <ul class=""post-meta"">
                        <li><i class=""fa fa-pencil-square-o""></i><strong> Posted By:</strong> John</li>
                        <li><i class=""fa fa-clock-o""></i><strong> Posted On:</strong> Apr 15 2014</li>
                    </ul>
                    <div class=""blog-content"">
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 10995, "\"", 11002, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-six"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-six"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11555, "\"", 11561, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <h2>Lorem ipsum dolor sit amet</h2>
                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"single-blog\">\r\n                    <img src=\"images/blog/1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12817, "\"", 12823, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <h2>Lorem ipsum dolor sit amet</h2>
                    <ul class=""post-meta"">
                        <li><i class=""fa fa-pencil-square-o""></i><strong> Posted By:</strong> John</li>
                        <li><i class=""fa fa-clock-o""></i><strong> Posted On:</strong> Apr 15 2014</li>
                    </ul>
                    <div class=""blog-content"">
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 13441, "\"", 13448, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#blog-seven"">Read More</a>
                </div>
                <div class=""modal fade"" id=""blog-seven"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <img src=""images/blog/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14005, "\"", 14011, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <h2>Lorem ipsum dolor sit amet</h2>
                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p><p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section> <!--/#blog-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
