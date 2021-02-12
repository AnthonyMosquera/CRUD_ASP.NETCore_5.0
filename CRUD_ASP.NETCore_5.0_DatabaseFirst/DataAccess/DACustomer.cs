using CRUD_ASP.NETCore_5._0_DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP.NETCore_5._0_DatabaseFirst.DataAccess
{
    public class DACustomer
    {   
        //Devolver el listado de los registros
        public static async Task<IEnumerable<Customer>> ListadoAsync() 
        {
            using (var data = new SalesContext())
            {
                return await data.Customers.OrderBy(x => x.Id).ToListAsync();
            }
        }
        //Devolver solo 1 registro
        public static Customer Obtener(int id)
        {
            using (var data = new SalesContext())
            {
                return data.Customers.Where(q => q.Id == id).FirstOrDefault();
            }
        }
        //Insetar
        public static bool Insertar(Customer customer)
        {
            bool exito = true;

            try
            {
                using (var data = new SalesContext())
                {
                    data.Customers.Add(customer);
                    data.SaveChanges();
                }
            }
            catch (System.Exception)
            {

                exito = false;
            }
            return exito;
        }
        //Actualizar - Modificar
        public static bool Actualizar(Customer customer)
        {
            bool exito = true;

            try
            {
                using (var data = new SalesContext())
                {
                    var customerNow = Obtener(customer.Id);
                    customerNow.FirstName = customer.FirstName;
                    customerNow.LastName = customer.LastName;
                    customerNow.City = customer.City;
                    customerNow.Country = customer.Country;
                    customer.Phone = customer.Phone;

                    data.SaveChanges();
                }
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }
        public static bool Eliminar(int id)
        {
            bool exito = true;

            try
            {
                var customerNow = Obtener(id);
                using (var data = new SalesContext())
                {
                    data.Customers.Remove(customerNow);
                    data.SaveChanges();
                }
            }
            catch (Exception)
            {
                exito = false;
            }
                
            return exito;
        }
    }
}
