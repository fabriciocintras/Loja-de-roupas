#pragma checksum "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e3df3a966062adc6d53ab7a9191a3526f160560"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e3df3a966062adc6d53ab7a9191a3526f160560", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cc4639cc483b3d6cc0ec22398510e95e9994f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fabrício\Desktop\Tec. Informatica para Internet\Concluido\Modulo 1\PI\etapa 3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</header>
    <section style=""padding-top: 80px;"">
        <div id=""bannerPromocao"">
            <div id=""linkParaOFreteGratis"">
                <h3>FRETE GRATIS PARA TODOS OS ITENS DA LISTA </h3>
            </div>
            <div id=""LinkParaOsProdutosEmOfertaDoBanner"">
                <h3>PRODUTOS COM ATE</h3>
                <h1>70% OFF</h1>
                <button id=""botaoBannerPromocao"">APROVEITE ></button>
            </div>
        </div>

        <div id=""faixaPromocao"">
            
            <div class=""boxPromocao"">
                <div id=""boxPromocaoIconeCamisa"">
                    <img src=""/img/037-tshirt.png""");
            BeginWriteAttribute("alt", " alt=\"", 702, "\"", 708, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div id=""boxPromocaoTextoCamisa"">
                    <h3>4 POR R$ 99,90</h3>
                </div>  
            </div>
            <div class=""boxPromocao"">
                <div id=""boxPromocaoIconesapato"">
                    <img src=""/img/040-shoes.png""");
            BeginWriteAttribute("alt", " alt=\"", 1017, "\"", 1023, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div id=""boxPromocaoTextosapato"">
                    <h3>2 POR R$ 99,90</h3>
                </div>  
            </div>
            <div class=""boxPromocao"">
                <div id=""boxPromocaoIconeLeveMaisPagueMenos"">
                    <img src=""/img/005-cap.png""");
            BeginWriteAttribute("alt", " alt=\"", 1342, "\"", 1348, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div id=""boxPromocaoTextoLeveMaisPagueMenos"">
                    <h3>LEVE 3 E PAGUE 2</h3>
                </div>  
            </div>
        </div>

        <div id=""faixaCategoria"">

        </div>

        <!----------------------------------->

        <div id=""faixaMarcas"">
            <h1>NOSSAS MARCAS</h1>
            <div class=""containerdasMarcas"">
                <div class=""circuloDeMarca""><a");
            BeginWriteAttribute("href", " href=\"", 1815, "\"", 1822, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/1280px-Adidas_Logo.svg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1866, "\"", 1872, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 1932, "\"", 1939, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/Nike-symbol-vector-400x400.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1987, "\"", 1993, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 2053, "\"", 2060, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/Oakley_logo.svg.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2097, "\"", 2103, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"circuloDeMarca\"><a");
            BeginWriteAttribute("href", " href=\"", 2163, "\"", 2170, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/quiksilver-logo-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2209, "\"", 2215, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n            </div>\r\n        </div>\r\n        <div id=\"newslatter\"></div>\r\n    </section>");
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