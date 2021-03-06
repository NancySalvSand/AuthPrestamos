#pragma checksum "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0df7d256ef672879cae75d4fa1b5fd878e92e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsuarioPrestamo_ObtenerAbonos), @"mvc.1.0.view", @"/Views/UsuarioPrestamo/ObtenerAbonos.cshtml")]
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
#line 1 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\_ViewImports.cshtml"
using AuthPrestamos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\_ViewImports.cshtml"
using AuthPrestamos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0df7d256ef672879cae75d4fa1b5fd878e92e9", @"/Views/UsuarioPrestamo/ObtenerAbonos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a792358d160fb0b0f4f46b5c2862fbb0505039", @"/Views/_ViewImports.cshtml")]
    public class Views_UsuarioPrestamo_ObtenerAbonos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthPrestamos.Models.Prestamo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
  
    ViewData["Title"] = "Detalle Abonos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalle</h1>\r\n\r\n<div>\r\n    <h4>Monto</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Usted Debe:$\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n           \r\n            ");
#nullable restore
#line 18 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
       Write(Model.CantidadInteres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
     if (Model.Abonos != null && Model.Abonos.Count > 0)
    {
        List<Abono> ListaAbonos = Model.Abonos.ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral("        <label>Abonos</label>\r\n");
#nullable restore
#line 29 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
         if (ListaAbonos != null && ListaAbonos.Count > 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-hover table-striped"">
                <thead>
                    <tr>
                        <th>Id </th>
                        <th>Abono </th>
                        <th>Saldo por Pagar</th>
                        <th>Fecha</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 42 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                     foreach (Abono item in ListaAbonos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                       Write(item.CantidadAbono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                       Write(item.Saldo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                       Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            WriteLiteral("            <label>Total de abonos: ");
#nullable restore
#line 55 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
                               Write(ListaAbonos.Sum(x => x.CantidadAbono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 56 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\NancySS\source\repos\AuthPrestamos\AuthPrestamos\Views\UsuarioPrestamo\ObtenerAbonos.cshtml"
         




    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthPrestamos.Models.Prestamo> Html { get; private set; }
    }
}
#pragma warning restore 1591
