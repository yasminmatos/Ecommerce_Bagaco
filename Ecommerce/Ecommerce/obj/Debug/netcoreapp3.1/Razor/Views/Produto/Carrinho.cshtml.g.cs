#pragma checksum "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7188a36df27b6d12e6a819a7c7390a3dd94d9e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_carrinho), @"mvc.1.0.view", @"/Views/Produto/carrinho.cshtml")]
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
#line 1 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7188a36df27b6d12e6a819a7c7390a3dd94d9e26", @"/Views/Produto/carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/menu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/carrinho.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Views/Produto/ProdutosCliente.cshtml"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7188a36df27b6d12e6a819a7c7390a3dd94d9e265430", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <script src=""https://kit.fontawesome.com/19a96cf4ea.js""
            crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7188a36df27b6d12e6a819a7c7390a3dd94d9e265982", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7188a36df27b6d12e6a819a7c7390a3dd94d9e267160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Bagaço - Carrinho</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7188a36df27b6d12e6a819a7c7390a3dd94d9e269086", async() => {
                WriteLiteral("\r\n    <header>\r\n        <div class=\"logo\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7188a36df27b6d12e6a819a7c7390a3dd94d9e269404", async() => {
                    WriteLiteral("BAGAÇO");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n        <nav>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 728, "\"", 735, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link  user\">\r\n                <i class=\"fa-solid fa-user\"></i>\r\n            </a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 844, "\"", 851, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\">Sair</a>\r\n        </nav>\r\n    </header>\r\n\r\n    <div class=\"container\">\r\n       \r\n");
#nullable restore
#line 33 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
          double total = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n        <div class=\"container-txt\">\r\n            <p>SUAS COMPRAS</p>\r\n        </div>\r\n        <ul class=\"produtos\">\r\n");
#nullable restore
#line 39 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
             foreach (Produto p in Model)
            {
                string formato = "data:image/jpeg;base64," + Convert.ToBase64String(p.Img);


#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                    <div class=\"info-produto\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1359, "\"", 1373, 1);
#nullable restore
#line 45 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
WriteAttributeValue("", 1365, formato, 1365, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"img\">\r\n                        <div>\r\n                            <p class=\"nome\">");
#nullable restore
#line 47 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
                                       Write(p.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p class=\"descricao\">");
#nullable restore
#line 48 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
                                            Write(p.Descricao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p class=\"preco\">");
#nullable restore
#line 49 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
                                        Write(p.Preco);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"combo\">\r\n                        <button class=\"mais\" formmethod=\"post\">+</button>\r\n                        <input type=\"number\" value=\"1\"");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1832, "\"", 1850, 1);
#nullable restore
#line 55 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
WriteAttributeValue("", 1844, p.Qtd, 1844, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <button class=\"menos\">-</button>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"qtd-container\">\r\n                        <div class=\"qtd\">Disponível: ");
#nullable restore
#line 61 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
                                                Write(p.Qtd);

#line default
#line hidden
#nullable disable
                WriteLiteral(" produtos</div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 64 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"

                total += p.Preco * p.Qtd;
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </ul>\r\n    </div>\r\n\r\n    <div class=\"finalizar\">\r\n        <p class=\"total\">Total da Compra: ");
#nullable restore
#line 72 "C:\Users\aluno\Downloads\Ecommerce\Ecommerce\Ecommerce\Views\Produto\carrinho.cshtml"
                                     Write(Produto.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </p>\r\n        <button class=\"finalizarCompra\">Finalizar Compra</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
