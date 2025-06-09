using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {

        private string _filePath = "products.txt";

        //Metodo que retorna una lista de productos tomada del archivo de texto/.
        //Leer la lista dfe productos de un txt y cargarlo en una lista.
        public List<Product> ReadProducts()
        {
            var products = new List<Product>();

            if (File.Exists(_filePath))
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    var product = new Product();
                    product.Id = Int32.Parse(parts[0]);
                    product.Name = parts[1];
                    product.Price = Double.Parse(parts[2]);
                    product.Stock = Int32.Parse(parts[3]);

                    products.Add(product);
                }
            }

            return products;
        }

        public void SaveProduct(Product product)
        {
            // ---------------- DESARROLLAR POR EL ESTUDIANTE ----------------
            // Guardar el producto en un txt separado por comas
            var line = product.Id + "," + product.Name + "," + product.Price + "," + product.Stock;

            File.AppendAllText(line, _filePath);
        }
    }
}
