#pragma checksum "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\Bookings\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593bbc52087e61f50d7951316900c1d0088688ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Form), @"mvc.1.0.view", @"/Views/Bookings/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593bbc52087e61f50d7951316900c1d0088688ae", @"/Views/Bookings/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef935b5ff25d2d21e2f6b5fd8a09f4c2d0ca80e", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\Bookings\Form.cshtml"
  
    String val = "No Value";
    if (Model == 1)
    {
        val = "Nueva Reserva";
    }
    else
    {
        val = "Editar Reserva " + ViewData["id"];
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\Bookings\Form.cshtml"
  
    ViewData["Title"] = val;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Formulario ");
#nullable restore
#line 19 "C:\Users\mauri\Documents\Escuela\UPA\Estadias\Documentación\Proyecto\HotelSuitesAlamo\HotelSA\Views\Bookings\Form.cshtml"
          Write(val);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
