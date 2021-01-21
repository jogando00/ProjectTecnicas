#pragma checksum "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Teacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5afec59a4cec7cf3aeef306339f834a4b4098ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teacher), @"mvc.1.0.view", @"/Views/Home/Teacher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5afec59a4cec7cf3aeef306339f834a4b4098ece", @"/Views/Home/Teacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d293dd7cce200372db995c188ce90e01febec2d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Teacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 66px; position: absolute; margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo_intec.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("class_o in classes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("class_o.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Teacher.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""limiter"" id=""content"">
    <div class=""container-login100"">
        <div class=""wrap-login100"" style=""padding: 0;"">
            <div class=""container"" style=""padding: 100px;"">
                <table style=""width: 60%"">
                    <tr class=""table-header"">
                        <th class="" "">Credito</th>
                        <th class="" "">Asignatura</th>
                    </tr>
                    <tr v-for=""class_o in classes"" class=""table-row"">
                        <td><div class="" "" data-label=""Credito"">{{ class_o.credit }}</div></td>
                        <td><div class="" "" data-label=""Asignatura"">{{ class_o.name }}</div></td>
                    </tr>

                </table>
            </div>
            <div class=""indice row text-right"">
                <div style="" width: 100%; margin-top: 110px; margin-right: 50px;"">
                    <button v-on:click=""openGrade"" class=""btn btn-danger"">Calificaciones</button>
                </div>
            </div>

         ");
            WriteLiteral(@"   <div class=""person text-right"">
                <i class=""fa fa-user"" style=""margin-right: 10px;""></i><span>Welcome {{ professor.name }}</span></br>
                <a class=""txt2"" v-on:click=""exit()"" href=""#"">
                    Exit
                    <i class=""fa fa-long-arrow-right m-l-5"" aria-hidden=""true""></i>
                </a>
            </div>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5afec59a4cec7cf3aeef306339f834a4b4098ece6322", async() => {
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
            WriteLiteral(@"
        </div>
    </div>

    <div class=""modal modal-sticky"" id=""grade"" role=""dialog"" style=""background-color: #0000007d;"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5>CALIFICACIONES</h5>
                    <button data-dismiss=""modal""><i class=""fa fa-close""></i></button>
                </div>
                <div class=""modal-body"">
                    <div class=""justify-content-center row text-center"" style=""margin: 30px;"">
                        <div class=""col-6 form-group"">
                            <label>Asignatura</label>
                            <select class=""form-control"" v-model=""selectedClass"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5afec59a4cec7cf3aeef306339f834a4b4098ece8232", async() => {
                WriteLiteral("{{ class_o.name }}");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""col-6 form-group"">
                            <button v-bind:class=""{ disabled : selectedClass == '' }"" class=""btn btn-primary"" v-on:click=""searchStudents()"">Search</button>
                        </div>
                    </div>
                    <div class=""container"">
                        <table style=""width: 100%"">
                            <tr class=""table-header"">
                                <th class="" "">ID</th>
                                <th class="" "">Nombre</th>
                                <th>Grade</th>
                            </tr>
                            <tr v-for=""student in students"" class=""table-row"">
                                <td><div class="" "" data-label=""ID"">{{ student.un_id }}</div></td>
                                <td><div class="" "" data-label=""Nombre"">{{ student.name }}</div></td>
                                <td><input class=""form-control"" ");
            WriteLiteral(@"v-model=""student.grade"" /></td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-success"" v-on:click=""grade()"">Grade</button>
                </div>
            </div>
        </div>
    </div>
</div>




");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        var professor = ");
#nullable restore
#line 86 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Teacher.cshtml"
                   Write(Html.Raw(Json.Serialize(ViewBag.teacher)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n        var classes = ");
#nullable restore
#line 87 "/Users/jogando/Projects/ProjectTecnicas/ProjectTecnicas/Views/Home/Teacher.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.t_classes)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        var main = new Vue({
            el: '#content',
            data: {
                classes: classes,
                professor: professor,
                students: [],
                selectedClass: ''
            },
            methods: {
                openGrade: function () {
                    $('#grade').modal('show');
                },
                searchStudents: function (id) {
                    var _this = this;
                    $.post(""/searchStudentsGrade"", { id: this.selectedClass }, function (result) {
                        _this.students = result;
                    })
                },
                grade: function () {
                    var _this = this;
                    this.students.forEach(function (student) {
                        $.post(""/gradeStudent"", { class_id: _this.selectedClass, user_id: student.id, grade: student.grade }, function (result) {
                        })
                    });
                    toastr.success('Students graded'");
                WriteLiteral(", \'Success\');\n                    $(\'#grade\').modal(\'hide\');\n                },\n                exit: function () {\n                    window.location = \'/\';\n                }\n            }\n        });\n    </script>\n");
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
