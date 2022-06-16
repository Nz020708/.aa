#pragma checksum "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d01a8a8a1f88df9cba1d5344186fd104e94231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
using Beryllium.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d01a8a8a1f88df9cba1d5344186fd104e94231", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""architecture"">
        <div class=""myContainer"">
            <div id=""carouselExampleDark""
                 class=""carousel carousel-dark slide""
                 data-bs-ride=""carousel"">
                <div class=""carousel-indicators dots"">
                    <button type=""button""
                            data-bs-target=""#carouselExampleDark""
                            data-bs-slide-to=""0""
                            class=""active""
                            aria-current=""true""
                            aria-label=""Slide 1""></button>
                    <button type=""button""
                            data-bs-target=""#carouselExampleDark""
                            data-bs-slide-to=""1""
                            aria-label=""Slide 2""></button>
                    <button type=""button""
                            data-bs-target=""#carouselExampleDark""
                            data-bs-slide-to=""2""
                            aria-label=""Slide 3""></butto");
            WriteLiteral(@"n>
                </div>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"" data-bs-interval=""10000"">
                        <img src=""https://demos.freehtml5.co/beryllium/images/slider_1.jpg""
                             class=""d-block w-100""
                             alt=""..."" />
                        <div class=""carousel-caption d-none d-md-block slider-text"">
                            <h5>Architecture #1</h5>
                        </div>
                    </div>
                    <div class=""carousel-item"" data-bs-interval=""2000"">
                        <img src=""https://demos.freehtml5.co/beryllium/images/slider_2.jpg""
                             class=""d-block w-100""
                             alt=""..."" />
                        <div class=""carousel-caption d-none d-md-block slider-text"">
                            <h5>Architecture #2</h5>
                        </div>
                    </div>
                    ");
            WriteLiteral(@"<div class=""carousel-item"">
                        <img src=""https://demos.freehtml5.co/beryllium/images/slider_3.jpg""
                             class=""d-block w-100""
                             alt=""..."" />
                        <div class=""carousel-caption d-none d-md-block slider-text"">
                            <h5>Architecture #3</h5>
                        </div>
                    </div>
                </div>
                <button class=""carousel-control-prev control-btn-left""
                        type=""button""
                        data-bs-target=""#carouselExampleDark""
                        data-bs-slide=""prev"">
                    <i class=""fa-solid fa-arrow-left prev-next""></i>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next control-btn-right""
                        type=""button""
                        data-bs-target=""#carouselExampleDark""
                       ");
            WriteLiteral(@" data-bs-slide=""next"">
                    <i class=""fa-solid fa-arrow-right prev-next""></i>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
        </div>
    </section>
    <section id=""work"">
        <div class=""myContainer"">
            <h2>WORK</h2>
            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus
                placerat enim <br />
                et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt
                volutpat erat.
            </p>
            <div class=""slick"">
");
#nullable restore
#line 82 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                 foreach (var item in Model.Places)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"slick-item\">\r\n                        <div class=\"slick-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3985, "\"", 4046, 2);
            WriteAttributeValue("", 3991, "https://demos.freehtml5.co/beryllium/images/", 3991, 44, true);
#nullable restore
#line 86 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 4035, item.Image, 4035, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 alt=\"new york arena\" />\r\n                        </div>\r\n                        <div class=\"title\">");
#nullable restore
#line 89 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"subtitle\">");
#nullable restore
#line 90 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                                         Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n");
#nullable restore
#line 92 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                 foreach (var item in Model.Places)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"slick-item\">\r\n                        <div class=\"slick-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4510, "\"", 4571, 2);
            WriteAttributeValue("", 4516, "https://demos.freehtml5.co/beryllium/images/", 4516, 44, true);
#nullable restore
#line 97 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
WriteAttributeValue("", 4560, item.Image, 4560, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 alt=\"new york arena\" />\r\n                        </div>\r\n                        <div class=\"title\">");
#nullable restore
#line 100 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"subtitle\">");
#nullable restore
#line 101 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                                         Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n");
#nullable restore
#line 103 "C:\Users\99470\source\repos\WebUI\Beryllium\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"               
            </div>
        </div>
    </section>
    <section id=""newsandtestimonials"">
        <div class=""myContainer"">
            <div class=""parts"">
                <div class=""col-6 part"">
                    <div class=""title""><h2>News</h2></div>
                    <div class=""news-items"">
                        <div class=""news-item"">
                            <div class=""date"">SEPTEMBER 10, 2016</div>
                            <div class=""name"">
                                <a href=""#""><h2>Manila Bridge Re-construction</h2></a>
                            </div>
                            <div class=""about"">
                                <a href=""#"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod...</a>
                            </div>
                        </div>
                        <div class=""news-item"">
                            <div class=""date"">SEPTEMBER 10, 2016</div>
 ");
            WriteLiteral(@"                           <div class=""name"">
                                <a href=""#""><h2>Manila Bridge Re-construction</h2></a>
                            </div>
                            <div class=""about"">
                                <a href=""#"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod...</a>
                            </div>
                        </div>
                        <div class=""news-item"">
                            <div class=""date"">SEPTEMBER 10, 2016</div>
                            <div class=""name"">
                                <a href=""#""><h2>Manila Bridge Re-construction</h2></a>
                            </div>
                            <div class=""about"">
                                <a href=""#"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod...</a>
                            </div>
                        ");
            WriteLiteral(@"</div>
                        <button>MORE NEWS</button>
                    </div>

                </div>
                <div class=""col-6 part"">
                    <div class=""title""><h2>Testimonials</h2></div>
                    <div class=""testimonials-items"">
                        <div class=""testimonial-item"">
                            <div class=""about"">
                                <p>“Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.“</p>
                            </div>
                            <div class=""person"">
                                <p>— John Doe Dueller</p>
                            </div>
                        </div>
                        <div class=""testimonial-item"">
                            <div class=""about"">
                                <p>“Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et");
            WriteLiteral(@" urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.“</p>
                            </div>
                            <div class=""person"">
                                <p>— John Doe Dueller</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
    <section id=""details"">
        <col-4></col-4>
        <col-4></col-4>
        <col-4></col-4>
    </section>
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591