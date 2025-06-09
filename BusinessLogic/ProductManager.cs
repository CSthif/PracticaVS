using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManager
    {
        public void AddProduct(Product product)
        {
            //Aplicar validaciones
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new Exception("Nombre del producto no debe ser vacio.");
            }

            if (product.Price < 1)
            {
                throw new Exception("El precio debe ser mayor que cero");
            }

            if (product.Stock < 1)
            {
                throw new Exception("La cantidad disponible debe ser mayor que cero");
            }

            //Si pasa las validaciones enviamos a guardar en el txt
            var fm = new FileManager();
            fm.SaveProduct(product);
        }

        public List<Product> GetProducts()
        {
            var list = new List<Product>();
            return list;
        }
    }
}
