#pragma checksum "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d49871647f391b9310e8e0d2779f23d97ffddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d49871647f391b9310e8e0d2779f23d97ffddc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0e6531ec4e9966b2a418eebb5da177b296ce14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\Pictures\PROYECTOS\BackEnd\proyectoFinales\DCU-final\DCU-FINAL-v5-MVC5\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
  
    <!--Header-->
    <hr />

    <main class=""row"">

        <section class=""col-12  text-center my-2 my-md-4"">
                <h3>¿Que puedo aprender en <span>estudiantes tic RD?</span></h3>

                <p>
                    El lugar ideal para darle sentido a tu aprendizaje, ven y accede a
                    la comunidad mas grande y talentosa del pais
                </p>


            <div class=""container my-2 py-4 "">
                <div class=""card row flex-row-reverse d-flex justify-content-center align-items-center"">
                    <img class=""col-lg-4 card-img-end img-fluid p-0"" src=""./imagenes/tic.jpg"" alt=""estudiantes tic"" />
                    <div class=""col-lg-8 card-body flex-column"">
                        <h5 class=""card-title"">Nuestros cursos estan enfocados al area de Tecnologia de la informacion</h5>

                        <p class=""card-text"">Podras encontrar una serieilimitada de contenido.</p>
                      ");
            WriteLiteral("  <a href=\"#\" class=\"btn btn-primary\">Ver cursos</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n        <section");
            BeginWriteAttribute("class", " class=\"", 1233, "\"", 1241, 0);
            EndWriteAttribute();
            WriteLiteral(@">

            <div class=""py-3 py-md-5 text-center"">
                <h3>Elige el area que mas te <span class=""text-danger ""> apasiona </span></h3>
            </div>
            

            <div class=""card-deck"">
                <div class=""card"">
                    <img class=""card-img-top p-2"" src=""../imagenes/dev.png"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Desarrollo de software</h5>
                        <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                        <p class=""card-text""><small class=""text-muted""></small></p>
                        <button class=""btn btn-outline-primary btn-lg"">Mas información</button>
                    </div>
                </div>
                <div class=""card"">
                    <img class=""card-img-top p-2"" src=""../imagenes/db.png"" alt=""Card image c");
            WriteLiteral(@"ap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Base de datos</h5>
                        <p class=""card-text"">This card has supporting text below as a natural lead-in to additional content.</p>
                        <p class=""card-text""><small class=""text-muted""></small></p>
                        <button class=""btn btn-outline-primary btn-lg"">Mas información</button>
                    </div>
                </div>
                <div class=""card"">
                    <img class=""card-img-top p-2"" src=""../imagenes/dweb.png"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Diseño Digital</h5>
                        <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
                        <p class=""card-text""><small class=""text-mute");
            WriteLiteral(@"d"">  </small></p>
                        <button class=""btn btn-outline-primary btn-lg"">Mas información</button>
                    </div>
                </div>
            </div>


                
            
        </section>

        
    </main>



</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
