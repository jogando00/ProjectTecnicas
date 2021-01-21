#pragma checksum "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e381fe887c2d3345a5f7ae2849b107b3739c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Student), @"mvc.1.0.view", @"/Views/Home/Student.cshtml")]
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
#line 1 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/_ViewImports.cshtml"
using ProjectTecnicas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/_ViewImports.cshtml"
using ProjectTecnicas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e381fe887c2d3345a5f7ae2849b107b3739c02", @"/Views/Home/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d293dd7cce200372db995c188ce90e01febec2d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 66px; position: absolute; margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo_intec.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Student.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""content"">
    <div class=""container-login100"">
        <div class=""wrap-login100"" style=""padding: 0;"">
            <div class=""container"" style=""padding: 100px; z-index: 2;"">
                <table style=""width: 60%"">
                    <tr class=""table-header"">
                        <th class="" "">Credito</th>
                        <th class="" "">Asignatura</th>
                        <th class="" "">Calificacion</th>
                    </tr>
                    <tr v-for=""class_o in classes"" class=""table-row"">
                        <td><div class="" "" data-label=""Credito"">{{ class_o.credit }}</div></td>
                        <td><div class="" "" data-label=""Asignatura"">{{ class_o.class_name }}</div></td>
                        <td><div class="" "" data-label=""Calificacion"">{{ class_o.grade }}</div></td>
                    </tr>

                </table>
            </div>
            <div class=""indice row text-right"">
                <div style=""width: 100%"">
                    <h1 class=""te");
            WriteLiteral(@"xt-danger"">{{ gpa }}</h1></br>
                    <h4 class=""text-danger"">INDICE TRIMESTRAL</h4></br>
                    <h2>{{ honor }}</h2>
                </div>
            </div>

            <div class=""person text-right"" style=""z-index: 3"">
                <i class=""fa fa-user"" style=""margin-right: 10px;""></i><span>Welcome {{ student.name }}</span></br>
                <a class=""txt2"" v-on:click=""exit()"" href=""#"">
                    Exit
                    <i class=""fa fa-long-arrow-right m-l-5"" aria-hidden=""true""></i>
                </a>
            </div>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9e381fe887c2d3345a5f7ae2849b107b3739c025703", async() => {
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
            WriteLiteral("\n        </div>\n    </div>\n\n</div>\n\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        var student = ");
#nullable restore
#line 50 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Student.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.student)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n        var classes = ");
#nullable restore
#line 51 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Student.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.classes)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        var main = new Vue({
            el: '#content',
            data: {
                classes: classes,
                student: student,
            },
            computed: {
                gpa: function () {
                    var sum = 0, credits = 0;
                    classes.forEach(function (c) {
                        switch (c.grade) {
                            case 'A':
                                sum += 4 * c.credit;
                                break;
                            case 'B+':
                                sum += 3.5 * c.credit;
                                break;
                            case 'B':
                                sum += 3 * c.credit;
                                break;
                            case 'C+':
                                sum += 2.5 * c.credit;
                                break;
                            case 'C':
                                sum += 2 * c.credit;
                                break;
      ");
                WriteLiteral(@"                      case 'D':
                                sum += 1 * c.credit;
                                break;
                        }
                        credits += Number(c.credit);
                    })

                    return (sum / credits).toFixed(2);
                },
                honor: function () {
                    if (this.gpa > 3.8) {
                        return 'Suma Cum Laude'
                    } else if (this.gpa > 3.5) {
                        return 'Magna Cum Laude'
                    } else if (this.gpa > 3.2) {
                        return 'Cum Laude'
                    } else {
                        return 'Sin Honor' 
                    }
                }

            },
            methods: {
                exit: function () {
                    window.location = '/';
                }
            }
        });
    </script>
");
            }
            );
            WriteLiteral("\n");
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
