#pragma checksum "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8357c372181181d8075853c59eb2e60a45b77a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\_ViewImports.cshtml"
using RoleTopMVC_;

#line default
#line hidden
#line 2 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\_ViewImports.cshtml"
using RoleTopMVC_.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8357c372181181d8075853c59eb2e60a45b77a6c", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0efa0911ea5d4c96bb12ecde142ee9bcd503928", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 156, true);
            WriteLiteral("<main>        \n    <section class=\"eventos\">\n        <div class=\"relatorio\">\n            <div>  \n                <h3>Eventos Aprovados</h3>\n                ");
            EndContext();
            BeginContext(157, 23, false);
#line 6 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
           Write(Model.ReservasAprovadas);

#line default
#line hidden
            EndContext();
            BeginContext(180, 100, true);
            WriteLiteral("\n            </div>\n\n            <div>  \n                <h3>Eventos Pendentes</h3>\n                ");
            EndContext();
            BeginContext(281, 23, false);
#line 11 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
           Write(Model.ReservasPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(304, 101, true);
            WriteLiteral("\n            </div>\n\n            <div>  \n                <h3>Eventos Reprovados</h3>\n                ");
            EndContext();
            BeginContext(406, 24, false);
#line 16 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
           Write(Model.ReservasReprovadas);

#line default
#line hidden
            EndContext();
            BeginContext(430, 531, true);
            WriteLiteral(@"
            </div>
        </div>


        <h2>Eventos Pendentes</h2>
        <table>
            <thead>
                <tr>
                    <th>Cliente</th>
                    <th>Cliente email</th>
                    <th>Tipo</th>
                    <th>Convidados</th>
                    <th>Data</th>
                    <th>Som</th>
                    <th>Iluminacao</th>
                    <th>Valor Total</th>
                    <th>Aceitar</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 37 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                 foreach(var reserva in Model.Reservas ) 
                {

#line default
#line hidden
            BeginContext(1037, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1091, 20, false);
#line 40 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                       Write(reserva.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1146, 21, false);
#line 41 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                       Write(reserva.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 116, true);
            WriteLiteral("</td>\n                        <td>A Fazer</td>\n                        <td>A Fazer</td>\n                        <td>");
            EndContext();
            BeginContext(1284, 19, false);
#line 44 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                       Write(reserva.DataReserva);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1338, 16, false);
#line 45 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                       Write(reserva.SomPreco);

#line default
#line hidden
            EndContext();
            BeginContext(1354, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1389, 23, false);
#line 46 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                       Write(reserva.IluminacaoPreco);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1447, 18, false);
#line 47 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                       Write(reserva.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 65, true);
            WriteLiteral("</td>\n                        <td>\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1530, "\'", 1594, 1);
#line 49 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1537, Url.Action("Aprovar", "Reserva", new {id = @reserva.Id}), 1537, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1595, 43, true);
            WriteLiteral(">Aceitar</a>\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1638, "\'", 1702, 1);
#line 50 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1645, Url.Action("Recusar", "Reserva", new {id = @reserva.Id}), 1645, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1703, 69, true);
            WriteLiteral(">Recusar</a>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 53 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Dashboard\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1790, 74, true);
            WriteLiteral("            \n            </tbody>\n        </table>\n\n    </section>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
