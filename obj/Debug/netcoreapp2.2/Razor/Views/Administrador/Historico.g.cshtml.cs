#pragma checksum "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b2319f9c627209bd478d7adc619c833f091c51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Historico), @"mvc.1.0.view", @"/Views/Administrador/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Historico.cshtml", typeof(AspNetCore.Views_Administrador_Historico))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b2319f9c627209bd478d7adc619c833f091c51d", @"/Views/Administrador/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"defdaef1e0c0b7c023e23102742f5e2a51c0b17b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopOficial.ViewModel.ClienteViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 256, true);
            WriteLiteral(@"
<center>

  <table>
    <tr>
      <th>ID</th>
      <th>Dono do Evento</th>
      <th>Nome do Evento</th>
      <th>Data Do Evento</th>
      <th>Tipo De Evento</th>
      <th>Numero De Pessoas</th>
      <th>Situação</th>
      
    </tr>
");
            EndContext();
#line 16 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
   foreach(var meuevento in @Model.Eventos)
  {

#line default
#line hidden
            BeginContext(356, 47, true);
            WriteLiteral("      <tr>\r\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(404, 12, false);
#line 19 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                              Write(meuevento.ID);

#line default
#line hidden
            EndContext();
            BeginContext(416, 42, true);
            WriteLiteral("</td>\r\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(459, 22, false);
#line 20 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                              Write(meuevento.DonoDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(481, 42, true);
            WriteLiteral("</td>\r\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(524, 14, false);
#line 21 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                              Write(meuevento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(538, 42, true);
            WriteLiteral("</td>\r\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(581, 22, false);
#line 22 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                              Write(meuevento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(603, 42, true);
            WriteLiteral("</td>\r\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(646, 22, false);
#line 23 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                              Write(meuevento.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(668, 42, true);
            WriteLiteral("</td>\r\n          <td class=\"Subsubtitulo\">");
            EndContext();
            BeginContext(711, 25, false);
#line 24 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                              Write(meuevento.NumeroDePessoas);

#line default
#line hidden
            EndContext();
            BeginContext(736, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 25 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
           switch(@meuevento.Status)
          {
              case 0:

#line default
#line hidden
            BeginContext(817, 58, true);
            WriteLiteral("                  <td class=\"Subsubtitulo\">Pendente</td>\r\n");
            EndContext();
#line 29 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                  break;
              case 1:

#line default
#line hidden
            BeginContext(924, 58, true);
            WriteLiteral("                  <td class=\"Subsubtitulo\">Aprovado</td>\r\n");
            EndContext();
#line 32 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                  break;
              case 2:

#line default
#line hidden
            BeginContext(1031, 59, true);
            WriteLiteral("                  <td class=\"Subsubtitulo\">Reprovado</td>\r\n");
            EndContext();
#line 35 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
                  break;
          }

#line default
#line hidden
            BeginContext(1129, 17, true);
            WriteLiteral("\r\n\r\n      </tr>\r\n");
            EndContext();
#line 40 "C:\Users\54094513841\Desktop\RoleTopOFC\Views\Administrador\Historico.cshtml"
  }

#line default
#line hidden
            BeginContext(1151, 14, true);
            WriteLiteral("  </table>\r\n  ");
            EndContext();
            BeginContext(1165, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b2319f9c627209bd478d7adc619c833f091c51d8332", async() => {
                BeginContext(1222, 56, true);
                WriteLiteral("\r\n    <button class=\"BotaoNormal\">Dashboard</button>\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1282, 15, true);
            WriteLiteral("\r\n\r\n</center>\r\n");
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
