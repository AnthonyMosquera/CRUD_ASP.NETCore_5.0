using CRUD_ASP.NETCore_5._0_DatabaseFirst.DataAccess;
using CRUD_ASP.NETCore_5._0_DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUD_ASP.NETCore_5._0_DatabaseFirst.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Listado()
        {
            ViewBag.ListadoCliente = await DACustomer.ListadoAsync();
            return PartialView();
        }
        [HttpPost]
        public IActionResult Eliminar(int idCliente)
        {
            bool exito = DACustomer.Eliminar(idCliente);
            return Json(exito);
        }
        [HttpPost]
        public IActionResult Grabar(int idCliente, string nombres, string apellidos, string pais, string ciudad, string telefono)
        {
            var customer = new Customer()
            {
                FirstName = nombres,
                LastName = apellidos,
                Country = pais,
                City = ciudad,
                Phone = telefono
            };

            bool exito = true;

            if (idCliente == -1)
            {
                exito = DACustomer.Insertar(customer);
            }
            else
            {
                customer.Id = idCliente;
                exito = DACustomer.Actualizar(customer);
            }
            return Json(exito);
        }
    }
}
