#pragma checksum "C:\Users\antho\source\repos\CRUD_ASP.NETCore_5.0\CRUD_ASP.NETCore_5.0_DatabaseFirst\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8615e6d2b1f5ea73ef681d09f75f195778eff25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\antho\source\repos\CRUD_ASP.NETCore_5.0\CRUD_ASP.NETCore_5.0_DatabaseFirst\Views\_ViewImports.cshtml"
using CRUD_ASP.NETCore_5._0_DatabaseFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\antho\source\repos\CRUD_ASP.NETCore_5.0\CRUD_ASP.NETCore_5.0_DatabaseFirst\Views\_ViewImports.cshtml"
using CRUD_ASP.NETCore_5._0_DatabaseFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8615e6d2b1f5ea73ef681d09f75f195778eff25b", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486fc7fbd034f2f701ef5733cb744f903690a068", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables.net/datatables.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8615e6d2b1f5ea73ef681d09f75f195778eff25b4313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8615e6d2b1f5ea73ef681d09f75f195778eff25b5352", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""alert alert-info"">
    <div class=""row"">
        <div class=""col-md-4"">
            <h3>Mantenimiento de Clientes</h3>
        </div>
        <div class=""col-md-2"">
            <button id=""btnAgregarCliente"" class=""btn btn-success"">
                Agregar
            </button>
        </div>
    </div>
</div>
<hr />
<div id=""divListadoClientes"">

</div>
<!-- Modal -->
<div class=""modal fade"" id=""modalRegistroCliente"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""titulo"">Registro de Clientes</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""container-fluid"">
                    <div ");
            WriteLiteral(@"class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Nombres</label>
                                <input type=""text"" class=""form-control"" id=""txtNombres"" />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label>Apellidos</label>
                                <input type=""text"" class=""form-control"" id=""txtApellidos"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label>País</label>
                                <input type=""text"" class=""form-control"" id=""txtPais"" />
                            </div>
                       ");
            WriteLiteral(@" </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label>Ciudad</label>
                                <input type=""text"" class=""form-control"" id=""txtCiudad"" />
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label>Telefono</label>
                                <input type=""text"" class=""form-control"" id=""txtTelefono"" />
                            </div>
                        </div>
                    </div>
                    <input type=""hidden"" id=""hidIDCliente"" value=""-1"" />
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                <button type=""button"" class=""btn btn-primary"" id=""btnGrabarCliente"">Grabar<");
            WriteLiteral(@"/button>
            </div>
        </div>
    </div>
</div>
<script>

    //Limpiar controles
    function limpiarControles() {
        $(""#hidIDCliente"").val(-1);
        $(""#txtNombres"").val("""");
        $(""#txtApellidos"").val("""");
        $(""#txtPais"").val("""");
        $(""#txtCiudad"").val("""");
        $(""#txtTelefono"").val("""");
    }
    // Mostrar el Modal para registro cliente
    $(""#btnAgregarCliente"").click(function () {
        $(""#modalRegistroCliente"").modal();
    });
    // Guardar Cliente
    $(""#btnGrabarCliente"").click(function () {
        var vIDCliente = $(""#hidIDCliente"").val();
        var vNombres = $(""#txtNombres"").val();
        var vApellidos = $(""#txtApellidos"").val();
        var vPais = $(""#txtPais"").val();
        var vCiudad = $(""#txtCiudad"").val();
        var vTelefono = $(""#txtTelefono"").val();

        //Generar la peticion
        $.ajax({
            type: ""POST"",
            url: ""Customer/Grabar"",
            cache: false,
            da");
            WriteLiteral(@"ta: {
                idCliente: vIDCliente,
                nombres: vNombres,
                apellidos: vApellidos,
                pais: vPais,
                ciudad: vCiudad,
                telefono: vTelefono
            },
            success: function (exito) {
                if (exito) {
                    alert(""Se registró correctamente"");
                    CargarListadoClientes();
                    $(""#modalRegistroCliente"").modal(""toggle"");
                    limpiarControles();
                } else {
                    alert(""Ocurrió un error al grabar"");
                }
            }
        });
    });

    // Modificar Cliente
    $(""#divListadoClientes"").on('click', '.btnEditarCliente', function () {
        var vIdCliente = $(this).attr('data-id');
        $(""#hidIDCliente"").val(vIdCliente);
        var modalRegistro = $(""#modalRegistroCliente"");
        $.ajax({
            type: ""GET"",
            url: ""Customer/Obtener"",
            data: { idCl");
            WriteLiteral(@"iente: vIdCliente },
            cache: false,
            success: function (objCliente) {
                $(""#txtNombres"").val(objCliente.firstName);
                $(""#txtApellidos"").val(objCliente.lastName);
                $(""#txtPais"").val(objCliente.country);
                $(""#txtCiudad"").val(objCliente.city);
                $(""#txtTelefono"").val(objCliente.phone);
                modalRegistro.modal();
                modalRegistro.find(""#titulo"").html(""Editar Cliente"");
            }
        });
    });
    // Eliminar Cliente
    $(""#divListadoClientes"").on('click', '.btnEliminarCliente', function () {
        var vIdCliente = $(this).attr('data-id');
        if (confirm(""¿Estas seguro de eliminar el cliente?"")) {
            $.ajax({
                type: ""POST"",
                url: ""Customer/Eliminar"",
                data: { idCliente: vIdCliente },
                cache: false,
                success: function (exito) {
                    if (exito) {
             ");
            WriteLiteral(@"           CargarListadoClientes();
                    } else {
                        alert(""Ocurrió un error al eliminar"");
                    }
                }
            });
        }
    });
    // Listas Clientes
    CargarListadoClientes();
    function CargarListadoClientes() {
        $.ajax({
            type: ""GET"",
            url: ""Customer/Listado"",
            cache: false,
            success: function (datahtml) {
                $(""#divListadoClientes"").html(datahtml);
                $(""#divListadoClientes #tbClientes"").DataTable();
            }
        });
    };
</script>");
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
