#pragma checksum "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\Concluido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043836b2ec9a9e81c00f1c6a36feaead46ce7782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Concluido), @"mvc.1.0.view", @"/Views/Home/Concluido.cshtml")]
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
#line 1 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\_ViewImports.cshtml"
using etapa_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\_ViewImports.cshtml"
using etapa_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043836b2ec9a9e81c00f1c6a36feaead46ce7782", @"/Views/Home/Concluido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cc4639cc483b3d6cc0ec22398510e95e9994f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Concluido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListagemFormulario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\Concluido.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("=\"Enviado\";\r\n<div id=\"linkParaOFreteGratis\">\r\n    <h3>FRETE GRATIS PARA TODOS OS ITENS DA LISTA </h3>\r\n</div>\r\n\r\n\r\n<section class=\"checkMensagem\">\r\n    <div class=\"imgCheck\">\r\n        <img src=\"/icones/check.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 230, "\"", 236, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <p >mensagem Enviada xD</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "043836b2ec9a9e81c00f1c6a36feaead46ce77824137", async() => {
                WriteLiteral("confira sua mensagem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n<div id=\"faixaMarcas\">\r\n            <h1>NOSSAS MARCAS</h1>\r\n            <div class=\"containerdasMarcas\">\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 516, "\"", 523, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/1280px-Adidas_Logo.svg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 567, "\"", 573, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 633, "\"", 640, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/Nike-symbol-vector-400x400.png\"");
            BeginWriteAttribute("alt", " alt=\"", 688, "\"", 694, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 754, "\"", 761, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/Oakley_logo.svg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 798, "\"", 804, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 864, "\"", 871, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/quiksilver-logo-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 910, "\"", 916, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n            </div>\r\n        </div>");
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