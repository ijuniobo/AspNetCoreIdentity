#pragma checksum "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6549840327c6491b18401c2d4c97ab0a6fe8776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6549840327c6491b18401c2d4c97ab0a6fe8776", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b55bec701bb5c4324487dfe3a90e1f98fbf801d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml"
  
    if (Model == null)
    {
        ViewData["Title"] = "Ocorreu um Error!!";
    }
    else
    {
        ViewData["Title"] = Model.Titulo;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml"
  
    if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2>Oops ! Ocorreu um erro, mais não se preocupe. Nosso time será avisado e iremos corrigir em breve!</h2>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml"
       Write(Html.Raw(Model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2 class=\"text-danger\">");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml"
                           Write(Html.Raw(Model.Mensagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\AspNetCoreIdentity\AspNetCoreIdentity\Views\Shared\Error.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--<h1 class=""text-danger"">Error.</h1>
<h2 class=""text-danger"">An error occurred while processing your request.</h2>

if (Model.ShowRequestId)
{
    <p>
        <strong>Request ID:</strong> <code>Model.RequestId</code>
    </p>
}

<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591