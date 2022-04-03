using DevFramework.Core.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Entities.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorhtwindContext>, IProductDal
    {
        public Product Add(Product entity) => throw new NotImplementedException();
        public void Delete(Product entity) => throw new NotImplementedException();
        public Product Get(System.Linq.Expressions.Expression<Func<Product, bool>> filter) => throw new NotImplementedException();
        public List<Product> GetList(System.Linq.Expressions.Expression<Func<Product, bool>> filter = null) => throw new NotImplementedException();
        public Product Update(Product entity) => throw new NotImplementedException();
        Product DataAccess.IEntityRepository<Product>.Add(Product entity) => throw new NotImplementedException();
        void DataAccess.IEntityRepository<Product>.Delete(Product entity) => throw new NotImplementedException();
        Product DataAccess.IEntityRepository<Product>.Get(System.Linq.Expressions.Expression<Func<Product, bool>> filter) => throw new NotImplementedException();
        List<Product> DataAccess.IEntityRepository<Product>.GetList(System.Linq.Expressions.Expression<Func<Product, bool>> filter) => throw new NotImplementedException();
        Product DataAccess.IEntityRepository<Product>.Update(Product entity) => throw new NotImplementedException();
    }
}
