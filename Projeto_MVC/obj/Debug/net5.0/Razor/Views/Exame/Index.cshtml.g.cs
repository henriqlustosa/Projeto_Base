#pragma checksum "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f99ee124928836b007ce138e947062d767bf3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exame_Index), @"mvc.1.0.view", @"/Views/Exame/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f99ee124928836b007ce138e947062d767bf3a", @"/Views/Exame/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1feaed09393b3cac9c49cba1215cd9ed94f43643", @"/Views/_ViewImports.cshtml")]
    public class Views_Exame_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exame>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "exame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Inclus??o"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pesquisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edi????o"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inicia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Finaliza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
  
    ViewData["Title"] = "Exames";
    var termo = ViewData["termo"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header d-flex\">\r\n        <h4 class=\"flex-grow-1\">Exames</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f99ee124928836b007ce138e947062d767bf3a7782", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-plus\" aria-hidden=\"true\"></i>\r\n            Novo\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f99ee124928836b007ce138e947062d767bf3a9455", async() => {
                WriteLiteral("\r\n            <input name=\"termo\" class=\"form-control flex-grow-1\"");
                BeginWriteAttribute("value", "\r\n                    value=\"", 612, "\"", 647, 1);
#nullable restore
#line 19 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
WriteAttributeValue("", 641, termo, 641, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                    placeholder=""Pesquisar por t??tulo, categoria ou descri????o..."" />
            <button class=""btn btn-outline-secondary ml-2"">
                <i class=""fa fa-search""></i>
                <span class=""d-none d-md-inline"">Pesquisar</span>
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-12"">
                <table class=""col-12 table table-striped"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Registro Hospitalar</th>
                            <th>Microrganismo</th>
                            <th>Material</th>
                            <th>Clinica</th>
                            <th>Contato</th>
                            <th>Data Resultado</th>
                            <th>Data Cadastro</th>
                            <th>Data ??ltima Atualiza????o</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 43 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                         foreach(var exame in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 1789, "\"", 1816, 2);
            WriteAttributeValue("", 1797, "row-exame-", 1797, 10, true);
#nullable restore
#line 45 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
WriteAttributeValue("", 1807, exame.Id, 1807, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                               Write(exame.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                               Write(exame.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 49 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                     switch (exame.Clinica)
                                    {
                                        case Clinica.AMA:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Rascunho</span>\r\n");
#nullable restore
#line 53 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                            break;
                                        case Clinica.GINECOLOGIA:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Preg??o iniciado em ");
#nullable restore
#line 55 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                                                Write(exame.Dt_resultado.Value.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                            break;
                                        case Clinica.NEUROCIRURGIA:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Finalizado em ");
#nullable restore
#line 58 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                                           Write(exame.Dt_Cadastro.Value.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                            break;
                                        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 61 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                             Write(exame.Clinica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                            break;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                               Write(exame.Contato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 67 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                     if (exame.Clinica == Clinica.AMA)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f99ee124928836b007ce138e947062d767bf3a18239", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-pencil-alt\" aria-hidden=\"true\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                                                                                            WriteLiteral(exame.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f99ee124928836b007ce138e947062d767bf3a21050", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3635, "\"", 3652, 1);
#nullable restore
#line 73 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
WriteAttributeValue("", 3643, exame.Id, 3643, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            <button class=""btn btn-light"" title=""Iniciar Preg??o"">
                                                <i class=""fas fa-play-circle""></i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                     if (exame.Clinica != Clinica.GINECOLOGIA)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-light btnRemoveexame\" data-id=\"");
#nullable restore
#line 81 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                                                                    Write(exame.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-titulo=\"");
#nullable restore
#line 81 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                                                                                            Write(exame.Contato);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Exclus??o\">\r\n                                            <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                                        </a>\r\n");
#nullable restore
#line 84 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                     if (exame.Clinica == Clinica.GINECOLOGIA)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f99ee124928836b007ce138e947062d767bf3a25451", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 4691, "\"", 4708, 1);
#nullable restore
#line 88 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
WriteAttributeValue("", 4699, exame.Id, 4699, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            <button class=""btn btn-light"" title=""Finalizar Exame"">
                                                <i class=""fas fa-stop-circle""></i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\h013026\OneDrive - Default Directory\Workspace_Treinamento\Projeto_Base\Projeto_MVC\Views\Exame\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exame>> Html { get; private set; }
    }
}
#pragma warning restore 1591
