#pragma checksum "C:\Users\99470\source\repos\Fiorelloo\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "570056326f1df6a80522e3a4ef71f4eb927b2983"
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
#line 1 "C:\Users\99470\source\repos\Fiorelloo\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\99470\source\repos\Fiorelloo\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570056326f1df6a80522e3a4ef71f4eb927b2983", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9820de706002b40f061b74a0cf154e35f47cd7cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\99470\source\repos\Fiorelloo\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <!-- SLIDER SECTION START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
            WriteLiteral("            <div> <img src=\"img/h3-slider-background.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 371, "\"", 377, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n            <div> <img src=\"img/h3-slider-background-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 447, "\"", 453, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n            <div> <img src=\"img/h3-slider-background-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 523, "\"", 529, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n\r\n        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n");
            WriteLiteral(@"                    <div class=""text"">
                        <h1>Send <span>flowers</span> like</h1>
                        <h1>you mean it</h1>
                        <p class=""text-black-50 d-none d-sm-block"">
                            Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will
                            make it special cursus a sit amet mauris.
                        </p>
                    </div>
                    <div class=""img"">
                        <img src=""img/h2-sign-img.png""");
            BeginWriteAttribute("alt", " alt=\"", 1580, "\"", 1586, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- SLIDER SECTION END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 2059, "\"", 2066, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2297, "\"", 2304, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2547, "\"", 2554, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2630, "\"", 2637, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2711, "\"", 2718, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2794, "\"", 2801, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2875, "\"", 2882, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2955, "\"", 2962, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3200, "\"", 3207, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3434, "\"", 3441, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3509, "\"", 3516, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3582, "\"", 3589, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3664, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3730, "\"", 3737, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3802, "\"", 3809, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3983, "\"", 3990, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">Filter</a>
                            <i class=""fas fa-caret-down""></i>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""popular"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4427, "\"", 4434, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-14-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 4518, "\"", 4524, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""popular"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 5215, "\"", 5222, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-13-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 5306, "\"", 5312, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""winter"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 6002, "\"", 6009, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-12-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 6093, "\"", 6099, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""winter"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 6789, "\"", 6796, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-11-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 6880, "\"", 6886, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""various"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 7577, "\"", 7584, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-10-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 7668, "\"", 7674, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""various"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 8365, "\"", 8372, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-9-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8455, "\"", 8461, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""exotic"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 9151, "\"", 9158, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-8-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 9241, "\"", 9247, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-3 mt-3"">
                    <div class=""product-item text-center"" data-id=""exotic"">
                        <div class=""img"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 9937, "\"", 9944, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"img/shop-7-img.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10027, "\"", 10033, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""title mt-3"">
                            <h6>MAJESTY PALM</h6>
                        </div>
                        <div class=""price"">
                            <span class=""text-black-50"">Add to cart</span>
                            <span class=""text-black-50"">$259</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        <img src=""img/h3-video-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 10871, "\"", 10877, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>
                        <p class=""py-3"">
                            Where flowers are our inspiration to create lasting memories. Whatever the
                            occasion...
                        </p>
                        <ul class=""list-unstyled"">
                            <li class=""mt-3"">
                                <img src=""img/h1-custom-icon.png"" class=""mr-2""");
            BeginWriteAttribute("alt", " alt=\"", 11752, "\"", 11758, 0);
            EndWriteAttribute();
            WriteLiteral("> Hand picked just\r\n                                for you.\r\n                            </li>\r\n                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 11981, "\"", 11987, 0);
            EndWriteAttribute();
            WriteLiteral("> Unique flower\r\n                                arrangements\r\n                            </li>\r\n                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 12211, "\"", 12217, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Best way to say
                                you care.
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>Flower Experts</h1>
                        <p class=""text-black-50"">
                            A perfect blend of creativity, energy, communication, happiness and
                            love. Let us arrange
                            a smile for you.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row pb-5"">
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
      ");
            WriteLiteral("                  <div class=\"img\">\r\n                            <img src=\"img/h3-team-img-1.png\" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 13372, "\"", 13378, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>CRYSTAL BROOKS</h6>
                            <p class=""text-black-50"">Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
                        <div class=""img"">
                            <img src=""img/h3-team-img-2.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 13903, "\"", 13909, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>SHIRLEY HARRIS</h6>
                            <p class=""text-black-50"">Manager</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
                        <div class=""img"">
                            <img src=""img/h3-team-img-3.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 14434, "\"", 14440, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>BEVERLY CLARK</h6>
                            <p class=""text-black-50"">Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item text-center"">
                        <div class=""img"">
                            <img src=""img/h3-team-img-4.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 14964, "\"", 14970, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""text mt-3"">
                            <h6>AMANDA WATKINS</h6>
                            <p class=""text-black-50"">Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                   ");
            WriteLiteral(@"         <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->

    <section id=""blog"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>From our Blog</h1>
                        <p class=""text-black-50"">
                            A perfect blend of creativity, energy, communication, happiness and
                            love. Let us arrange
                            a smile for you.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row pb-5"">
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                      ");
            WriteLiteral("  <div class=\"img position-relative\">\r\n                            <img src=\"img/blog-feature-img-1.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 17141, "\"", 17147, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Flower Power</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 18030, "\"", 18036, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Local Florists</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-4.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 18921, "\"", 18927, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Flower Beauty</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
                        <div>
                       ");
            WriteLiteral("     <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    <img src=\"img/testimonial-img-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 20142, "\"", 20148, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text text-muted pt-3 pb-5"">
                                    <i>
                                        Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus
                                        lingua.
                                    </i>
                                </div>
                                <div class=""author"">
                                    <h6>Anna Barnes</h6>
                                    <p class=""text-black-50"">Florist</p>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class=""item text-center"">
                                <div class=""img d-flex justify-content-center"">
                                    <img src=""img/testimonial-img-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 21092, "\"", 21098, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text text-muted pt-3 pb-5"">
                                    <i>
                                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo
                                        ligula eget.
                                    </i>
                                </div>
                                <div class=""author"">
                                    <h6>Jasmine White</h6>
                                    <p class=""text-black-50"">Florist</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SAY END -->
    <!-- INSTAGRAM START -->

    <section id=""instagram"">
        <div class=""owl-carousel instagram"">
            <div><img src=""img/instagram1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 22102, "\"", 22108, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram2.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22182, "\"", 22188, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram3.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22262, "\"", 22268, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram4.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22342, "\"", 22348, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram5.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22422, "\"", 22428, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram6.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22502, "\"", 22508, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram7.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22582, "\"", 22588, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram8.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 22662, "\"", 22668, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n");
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
