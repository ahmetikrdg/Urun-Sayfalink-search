﻿// <auto-generated/>
#pragma warning disable 1591
namespace AspNetCore
{
    #line hidden
    using TModel = global::System.Object;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "c:/Users/Ahmet Karadağ/Desktop/shopappn/shopappn/shopapp.webui/Views/_ViewImports.cshtml"
using shopapp.webui.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:/Users/Ahmet Karadağ/Desktop/shopappn/shopappn/shopapp.webui/Views/_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:/Users/Ahmet Karadağ/Desktop/shopappn/shopappn/shopapp.webui/Views/_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    public class Views_Shared__Layoult2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 11 "c:/Users/Ahmet Karadağ/Desktop/shopappn/shopappn/shopapp.webui/Views/Shared/_Layoult2.cshtml"
__o = await Html.PartialAsync("_navbar");

#line default
#line hidden
#nullable disable
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = "_header";
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
#nullable restore
#line 16 "c:/Users/Ahmet Karadağ/Desktop/shopappn/shopappn/shopapp.webui/Views/Shared/_Layoult2.cshtml"
       __o = RenderBody();

#line default
#line hidden
#nullable disable
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

// 3