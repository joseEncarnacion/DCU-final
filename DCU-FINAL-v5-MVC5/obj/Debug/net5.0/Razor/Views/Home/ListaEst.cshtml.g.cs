#pragma checksum "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4669b45590f10b0f5192606b9b280590d92dbe9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaEst), @"mvc.1.0.view", @"/Views/Home/ListaEst.cshtml")]
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
#line 1 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\_ViewImports.cshtml"
using DCU_FINAL_v5_MVC5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\_ViewImports.cshtml"
using DCU_FINAL_v5_MVC5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4669b45590f10b0f5192606b9b280590d92dbe9c", @"/Views/Home/ListaEst.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0e6531ec4e9966b2a418eebb5da177b296ce14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ListaEst : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DCU_FINAL_v5_MVC5.Models.EntityEstuditiante>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
  
    ViewData["Title"] = "ListaEst";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!--row-cols-md-3 style=\"width: 18rem;-->\r\n\r\n<div class=\"text-center\">\r\n    <h1>Administracion de estudiantes</h1>\r\n</div>\r\n\r\n<section class=\"row\">\r\n    <div class=\"col col-10 col-md-5 py-3 my-3 my-md-5 py-md-4\">\r\n    \r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4669b45590f10b0f5192606b9b280590d92dbe9c4668", async() => {
                WriteLiteral(@"
           <!-- <input class=""form-control me-2"" type=""search"" name=""search"" id=""searchID"" placeholder=""Search"" aria-label=""Search"">
            <button class=""btn btn-outline-success"" id=""buronS"">buscar</button> -->
        <input class=""form-control me-2"" type=""search"" name=""search"" id=""searchID"" placeholder=""Search"" aria-label=""Search"">
        <button class=""btn btn-outline-success"" id=""buronS"">buscar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n   </div>\r\n</section>\r\n\r\n\r\n<section class=\"row\">\r\n\r\n    <div class=\"card-group\">\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
         foreach (var info in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-10 col-md-6 col-lg-4\">\r\n           \r\n                <div class=\"card\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=", 1106, "", 1121, 1);
#nullable restore
#line 40 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
WriteAttributeValue("", 1111, info.Foto, 1111, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\">ID# ");
#nullable restore
#line 42 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
                                            Write(info.idEstudiante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 43 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
                                          Write(info.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 44 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
                                        Write(info.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> ");
#nullable restore
#line 45 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"
                                         Write(info.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a href=\"#\" class=\"btn btn-primary\">Editar Informacion</a>\r\n                    </div>\r\n        \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\ListaEst.cshtml"

      
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n   \r\n\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DCU_FINAL_v5_MVC5.Models.EntityEstuditiante>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
