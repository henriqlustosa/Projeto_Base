#pragma checksum "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee36400306f94c2b1fd67934f73dd4509432e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Microrganismo), @"mvc.1.0.view", @"/Views/Home/Microrganismo.cshtml")]
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
#line 1 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\_ViewImports.cshtml"
using Projeto_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\_ViewImports.cshtml"
using Projeto_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee36400306f94c2b1fd67934f73dd4509432e6d", @"/Views/Home/Microrganismo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1feaed09393b3cac9c49cba1215cd9ed94f43643", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Microrganismo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microrganismo>
    {
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
   Layout = "_AreaPublica";
    ViewData["Title"] = "Microrganismo"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 6 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<span class=\"image main img-categoria\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ee36400306f94c2b1fd67934f73dd4509432e6d3878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 174, "~/", 174, 2, true);
#nullable restore
#line 8 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
AddHtmlAttributeValue("", 176, Model.Imagem, 176, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
AddHtmlAttributeValue("", 196, Model.Descricao, 196, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</span>\n<h3>Exames em andamento</h3>\n<section class=\"tiles\">\n");
#nullable restore
#line 12 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
     foreach (var exame in Model.Exames.Where(l => l.Clinica == Clinica.AMA))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<article class=\"leilao\">\n    <span class=\"image\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ee36400306f94c2b1fd67934f73dd4509432e6d6346", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 430, "~/", 430, 2, true);
#nullable restore
#line 16 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
AddHtmlAttributeValue("", 432, exame.PosterUrl, 432, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
AddHtmlAttributeValue("", 455, exame.Usuario, 455, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    \n    </span>\n    <h4>");
#nullable restore
#line 20 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
   Write(exame.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <div class=\"content\">\n        <p>");
#nullable restore
#line 22 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
      Write(exame.Contato.Substring(0, 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n</article>");
#nullable restore
#line 24 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Home\Microrganismo.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microrganismo> Html { get; private set; }
    }
}
#pragma warning restore 1591
