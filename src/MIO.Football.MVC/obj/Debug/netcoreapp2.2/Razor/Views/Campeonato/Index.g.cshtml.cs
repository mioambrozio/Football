#pragma checksum "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Campeonato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f27b22bb17cc1f1f3e2d69cb3004f407c9bd5d06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campeonato_Index), @"mvc.1.0.view", @"/Views/Campeonato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Campeonato/Index.cshtml", typeof(AspNetCore.Views_Campeonato_Index))]
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
#line 2 "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Campeonato\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f27b22bb17cc1f1f3e2d69cb3004f407c9bd5d06", @"/Views/Campeonato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731d295c53ad02a35f30f27a5b7c43f8c579301c", @"/Views/_ViewImports.cshtml")]
    public class Views_Campeonato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27b22bb17cc1f1f3e2d69cb3004f407c9bd5d063292", async() => {
                BeginContext(6, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(46, 133, true);
                WriteLiteral("    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">\r\n            ");
                EndContext();
                BeginContext(180, 46, false);
#line 5 "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Campeonato\Index.cshtml"
       Write(Context.Session.GetString("PeriodoCampeonato"));

#line default
#line hidden
                EndContext();
                BeginContext(226, 60, true);
                WriteLiteral("\r\n        </h1>\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
                EndContext();
                BeginContext(287, 43, false);
#line 9 "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Campeonato\Index.cshtml"
   Write(Context.Session.GetString("AreaCampeonato"));

#line default
#line hidden
                EndContext();
                BeginContext(330, 26, true);
                WriteLiteral("\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(357, 43, false);
#line 11 "C:\Users\Miriam\source\repos\TesteWay2\src\MIO.Football.MVC\Views\Campeonato\Index.cshtml"
   Write(Context.Session.GetString("NomeCampeonato"));

#line default
#line hidden
                EndContext();
                BeginContext(400, 149, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <img class=\"img-football\" src=\"https://thumbs.dreamstime.com/b/football-15892269.jpg\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
