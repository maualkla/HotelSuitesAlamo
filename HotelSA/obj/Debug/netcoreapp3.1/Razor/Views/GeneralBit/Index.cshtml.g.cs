#pragma checksum "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\GeneralBit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98597c5ad8c0f038d9c88f0692b93eb8442e59bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralBit_Index), @"mvc.1.0.view", @"/Views/GeneralBit/Index.cshtml")]
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
#line 1 "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\_ViewImports.cshtml"
using HotelSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\_ViewImports.cshtml"
using HotelSA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98597c5ad8c0f038d9c88f0692b93eb8442e59bf", @"/Views/GeneralBit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef935b5ff25d2d21e2f6b5fd8a09f4c2d0ca80e", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralBit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\GeneralBit\Index.cshtml"
  
    ViewData["Title"] = "Bitacora General";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bitacora General - Hotel Suites Alamo</h1>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 108, "\"", 115, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Logout </a>|<a href=""/Tarifas""> Tarifas </a>|<a href=""/Reservas""> Reservas </a>|<a href=""/BitacoraGeneral/Detalles""> Habitaciones </a>|<a href=""/Huespedes""> Huespedes </a>|<a href=""/Empleados""> Empleados </a>|<a href=""/BitacoraDeMovimientos""> Bitacora de Movimientos </a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
