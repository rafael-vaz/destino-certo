#pragma checksum "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f574e40e52c1f7475ecec4159e18fa5a4de79cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar_Pacotes), @"mvc.1.0.view", @"/Views/Home/Listar_Pacotes.cshtml")]
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
#line 1 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f574e40e52c1f7475ecec4159e18fa5a4de79cb", @"/Views/Home/Listar_Pacotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62dc632e00c762f86a3e907f5348c6ae15d28f1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listar_Pacotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pacotes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icones-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-listagempacotes.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Alterar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-close2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tittle", new global::Microsoft.AspNetCore.Html.HtmlString("Excluir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
  
  ViewData["Title"] = "Listagem de Pacotes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
  .nav-bar,
  footer,
  .menu-hamburger ul {
    background-color: #34495e !important;
    border: none !important;
  }

  .fundo-img {
    background-image: none !important;
    min-height: none !important;
    overflow-y: scroll !important;
  }

  .table-content {
    height: auto;
    width: 100%;
  }

  ");
            WriteLiteral("@media (max-width: 900px) {\n    .table-content {\n      overflow-x: scroll;\n      justify-content: flex-start;\n    }\n  }\n</style>\n\n<main class=\"fundo-color\">\n  <div class=\"usuarios-content\">\n    <div>\n      <div class=\"icone-titulo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f574e40e52c1f7475ecec4159e18fa5a4de79cb6442", async() => {
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
            WriteLiteral(@"
        <h3 class=""titulos"">LISTAGEM DE PACOTES</h3>
      </div>
      <p class=""paragrafos"">A lista com todos os pacotes cadastrados no sistema será exibida abaixo. Utilize os botões
        da direita para realizar a exclusão ou alteração dos pacotes</p>
      <p class=""paragrafos""><strong>AVISO</strong>: Tenha cuidado ao excluir um pacote. Uma vez excluídos, os dados do
        registo
        relacionados ao pacote não poderão ser recuperados.</p>

      <div class=""table-content"">

        <table class=""table"">
          <thead class=""thead-dark"">
            <tr>
              <th scioe=""col"">ID</th>
              <th scope=""col"">NOME</th>
              <th scope=""col"">ORIGEM</th>
              <th scope=""col"">DESTINO</th>
              <th scope=""col"">DATA DE SAÍDA</th>
              <th scope=""col"">DATA DE RETORNO</th>
              <th scope=""col"">PREÇO</th>
              <th scope=""col""></th>
              <th scope=""col""></th>
              <th scope=""col""></th>

            </tr>
          </the");
            WriteLiteral("ad>\n          <tbody>\n");
#nullable restore
#line 65 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
             foreach (Pacotes p in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\n                <th scope=\"row\">");
#nullable restore
#line 68 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
                           Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 69 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
               Write(p.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 70 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
               Write(p.origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 71 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
               Write(p.destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 72 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
               Write(p.saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 73 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
               Write(p.retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 74 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
               Write(p.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 2123, "\"", 2159, 2);
            WriteAttributeValue("", 2130, "/Home/Alterar_Pacote?id=", 2130, 24, true);
#nullable restore
#line 75 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
WriteAttributeValue("", 2154, p.id, 2154, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f574e40e52c1f7475ecec4159e18fa5a4de79cb11524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 2280, "\"", 2316, 2);
            WriteAttributeValue("", 2287, "/Home/Excluir_Pacote?id=", 2287, 24, true);
#nullable restore
#line 77 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
WriteAttributeValue("", 2311, p.id, 2311, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f574e40e52c1f7475ecec4159e18fa5a4de79cb13212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                </td>\n              </tr>\n");
#nullable restore
#line 81 "/home/rafael/Downloads/Meus Projetos/login-session-crud-asp.net-core-mvc/projeto-destino-certo/Views/Home/Listar_Pacotes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tbody>\n        </table>\n\n\n      </div>\n\n    </div>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pacotes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
