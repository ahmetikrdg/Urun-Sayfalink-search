#pragma checksum "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "553e036901189ab4e684f922b0895cb7531ea570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 2 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"553e036901189ab4e684f922b0895cb7531ea570", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7ba28a1af04aff11f0df939b1b43dc4ffde132", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 10 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 15 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n          <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 21 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li");
            BeginWriteAttribute("class", " class=\"", 896, "\"", 960, 2);
            WriteAttributeValue("", 904, "page-item", 904, 9, true);
#nullable restore
#line 25 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 913, Model.PageInfo.CurrentPage==i+1?"active":"", 914, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1012, "\"", 1040, 2);
            WriteAttributeValue("", 1019, "/products?page=", 1019, 15, true);
#nullable restore
#line 26 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1034, i+1, 1034, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 27 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 30 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li");
            BeginWriteAttribute("class", " class=\"", 1275, "\"", 1339, 2);
            WriteAttributeValue("", 1283, "page-item", 1283, 9, true);
#nullable restore
#line 33 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1292, Model.PageInfo.CurrentPage==i+1?"active":"", 1293, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1391, "\"", 1451, 4);
            WriteAttributeValue("", 1398, "/products/", 1398, 10, true);
#nullable restore
#line 34 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1408, Model.PageInfo.CurrentCategory, 1408, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1439, "?page=", 1439, 6, true);
#nullable restore
#line 34 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1445, i+1, 1445, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                                                                                                          Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                             \r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 38 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Ahmet Karadağ\Desktop\shopappn\shopappn\shopapp.webui\Views\Shop\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
