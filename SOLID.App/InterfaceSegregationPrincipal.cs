using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.InterfaceSegregationPrincipal
{
    //1.Class Library
    public class ReadProductRepository : IReadRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }
    //2.Class Library
    public class WriteProductRepository : IWriteRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    //public interface IProductRepository
    //{ 
    //    Bad Way
    //    List<Product> GetList();
    //    Product GetById(int id);
    //    Product Create(Product product);
    //    Product Update(Product product);
    //    Product Delete(Product product);
    //}

    //Good Way
    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);

    }
    public interface IWriteRepository
    {
       Product Create(Product product);
       Product Update(Product product);
       Product Delete(Product product);
    }
}
