#pragma checksum "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Shared\Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e87c90fe9f5e610ddfc1701ae36ec663dab1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Sucesso), @"mvc.1.0.view", @"/Views/Shared/Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Sucesso.cshtml", typeof(AspNetCore.Views_Shared_Sucesso))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97e87c90fe9f5e610ddfc1701ae36ec663dab1fb", @"/Views/Shared/Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0efa0911ea5d4c96bb12ecde142ee9bcd503928", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<main> \n    <h2>\n        ");
            EndContext();
            BeginContext(26, 14, false);
#line 3 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Shared\Sucesso.cshtml"
   Write(Model.NomeView);

#line default
#line hidden
            EndContext();
            BeginContext(40, 38, true);
            WriteLiteral(" Concluida!\n    </h2>\n    <p>\n        ");
            EndContext();
            BeginContext(79, 14, false);
#line 6 "C:\Users\32727031874\Desktop\RoleTopMVC-master\Views\Shared\Sucesso.cshtml"
   Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(93, 17, true);
            WriteLiteral("\n    </p>\n</main>");
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
