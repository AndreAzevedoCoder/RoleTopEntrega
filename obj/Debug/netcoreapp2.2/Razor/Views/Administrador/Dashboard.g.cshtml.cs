#pragma checksum "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a8cf5c97acfa44db03e4bbf21d9276e142d811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\_ViewImports.cshtml"
using RoleTopOficial;

#line default
#line hidden
#line 2 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\_ViewImports.cshtml"
using RoleTopOficial.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a8cf5c97acfa44db03e4bbf21d9276e142d811", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"defdaef1e0c0b7c023e23102742f5e2a51c0b17b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopOficial.ViewModel.ClienteViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Historico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 241, true);
            WriteLiteral("<center>\n\n  <table>\n    <tr>\n      <th>ID</th>\n      <th>Dono do Evento</th>\n      <th>Nome do Evento</th>\n      <th>Data Do Evento</th>\n      <th>Tipo De Evento</th>\n      <th>Numero De Pessoas</th>\n      <th>Situação</th>\n      \n    </tr>\n");
            EndContext();
#line 15 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
   foreach(var meuevento in @Model.Eventos)
  {

#line default
#line hidden
            BeginContext(338, 46, true);
            WriteLiteral("      <tr>\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(385, 12, false);
#line 18 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
                              Write(meuevento.ID);

#line default
#line hidden
            EndContext();
            BeginContext(397, 41, true);
            WriteLiteral("</td>\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(439, 22, false);
#line 19 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
                              Write(meuevento.DonoDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(461, 41, true);
            WriteLiteral("</td>\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(503, 14, false);
#line 20 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
                              Write(meuevento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(517, 41, true);
            WriteLiteral("</td>\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(559, 22, false);
#line 21 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
                              Write(meuevento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(581, 41, true);
            WriteLiteral("</td>\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(623, 22, false);
#line 22 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
                              Write(meuevento.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(645, 41, true);
            WriteLiteral("</td>\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(687, 25, false);
#line 23 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
                              Write(meuevento.NumeroDePessoas);

#line default
#line hidden
            EndContext();
            BeginContext(712, 65, true);
            WriteLiteral("</td>\n          <td class=\"Subsubtitulo\">Pendente</td>\n          ");
            EndContext();
            BeginContext(777, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a8cf5c97acfa44db03e4bbf21d9276e142d8117407", async() => {
                BeginContext(846, 43, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 889, "", 909, 1);
#line 26 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 896, meuevento.ID, 896, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(909, 106, true);
                WriteLiteral(">\n            <td><input class=\"BotaoNormal\" type=\"submit\" name=\"Aprovar\" value=\"Aprovar\"></td>\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 25 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
AddHtmlAttributeValue("", 805, Url.Action("Aprovar", "Administrador"), 805, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1022, 11, true);
            WriteLiteral("\n          ");
            EndContext();
            BeginContext(1033, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a8cf5c97acfa44db03e4bbf21d9276e142d81110078", async() => {
                BeginContext(1103, 43, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1146, "", 1166, 1);
#line 30 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1153, meuevento.ID, 1153, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1166, 108, true);
                WriteLiteral(">\n            <td><input class=\"BotaoNormal\" type=\"submit\" name=\"Cancelar\" value=\"Cancelar\"></td>\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 29 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
AddHtmlAttributeValue("", 1061, Url.Action("Cancelar", "Administrador"), 1061, 40, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1281, 13, true);
            WriteLiteral("\n      </tr>\n");
            EndContext();
#line 34 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Dashboard.cshtml"
  }

#line default
#line hidden
            BeginContext(1298, 13, true);
            WriteLiteral("  </table>\n  ");
            EndContext();
            BeginContext(1311, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a8cf5c97acfa44db03e4bbf21d9276e142d81113003", async() => {
                BeginContext(1368, 55, true);
                WriteLiteral("\n    <button class=\"BotaoNormal\" >Historico</button>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1427, 12, true);
            WriteLiteral("\n\n</center>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopOficial.ViewModel.ClienteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
