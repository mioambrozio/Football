#pragma checksum "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Home\SessionTimeout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "792ace602d90f79e7eeeabe9378bcf45b7c6003c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SessionTimeout), @"mvc.1.0.view", @"/Views/Home/SessionTimeout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SessionTimeout.cshtml", typeof(AspNetCore.Views_Home_SessionTimeout))]
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
#line 1 "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\_ViewImports.cshtml"
using MIO.Football.MVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792ace602d90f79e7eeeabe9378bcf45b7c6003c", @"/Views/Home/SessionTimeout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731d295c53ad02a35f30f27a5b7c43f8c579301c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SessionTimeout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Home\SessionTimeout.cshtml"
  
    ViewBag.Title = "Sessão expirada";
    Layout = "~/Views/Shared/_LayoutSimple.cshtml";

#line default
#line hidden
            BeginContext(100, 936, true);
            WriteLiteral(@"<div class=""row justify-content-center"">
    <div class=""col-xl-10 col-lg-12 col-md-9"">
        <div class=""card o-hidden border-0 shadow-lg my-5"">
            <div class=""card-body p-0"">
                <div class=""row"">
                    <div class=""col-lg-3 d-none d-lg-block""></div>
                    <div class=""col-lg-6"">
                        <div class=""p-5"">
                            <div class=""text-center"">
                                <h1 class=""h4 text-gray-900 mb-4"">Sua sessão expirou, você será redirecionado para a página de inicial.</h1>
                            </div>
                            <hr>
                        </div>
                    </div>
                    <div class=""col-lg-3 d-none d-lg-block"">
                        <label id=""Mensagem""></label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1053, 659, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var Tempo = 5;
        function Counter() {

            document.getElementById(""Mensagem"").innerHTML = Tempo + "" segundos."";
            Tempo--;

            if (Tempo == ""0"") {
                document.getElementById(""Mensagem"").innerHTML = ""1 segundo<br><br>Redirecionando..."";
                history.pushState(null, null, location.href);
                window.onpopstate = function (event) {
                    history.go(1);
                };
                setTimeout(window.location.assign(""/Home""), 1000);
            }
        }
        setInterval(Counter, 1000);
    </script>
");
                EndContext();
            }
            );
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