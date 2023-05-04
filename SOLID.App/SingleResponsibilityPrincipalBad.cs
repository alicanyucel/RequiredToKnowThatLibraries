﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.SingleResponsibilityPrincipalBad
{
    public class Product
    {
        //Bad Version
        public int Id { get; set; }     
        public string Name { get; set; }
        private static List<Product> _products;
      //In here this lambda statement as a semantically hidden get request 
        public static List<Product> GetProducts => _products;
        public Product()
        {
            _products = new List<Product>() 
            {
                new Product() {Id=1,Name="Pencil 1" },
                new Product() {Id=2,Name="Pencil 2" },
                new Product() {Id=3,Name="Pencil 3" },
                new Product() {Id=4,Name="Pencil 4" },
                new Product() {Id=5,Name="Pencil 5" }
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var IsProduct = _products.Any(p => p.Id == product.Id);

            if (!IsProduct)
            {
                _products.Add(product);
            }
            else
            {
                var index = _products.FindIndex(p=>p.Id == product.Id);

                _products[index]=product;
            }
        }

        public void Delete(int id)
        {
            var deletedProduct = _products.SingleOrDefault(P => P.Id == id);
            if(deletedProduct == null)
            {
                throw new Exception("Ürün Bulunamadı.");
            }
            _products.Remove(deletedProduct);
        }

        public void WriteToConsole()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Id} + {product.Name}");
            }
        }
    }
}
