using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.DependencyInversiınGoodAndBad
{
    public class ProductService
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositoryFromOracle:IRepository
    {

        public List<string> GetAll()
        {
            return new List<string>() { "Oracle Pencil 1", "Oracle Pencil 2" };
        }
    }

    public interface IRepository
    {
        List<string> GetAll();
    }
}
