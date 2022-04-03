using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);


    }
}
//BİZ Lİstlerle çalışırsak context açıp kapatırız. To List bir opoerasyon gördüğpünde Veritabanı ile bütün context orada sonlanmış olur
//Busssiness tarafında çalıştırılması için de bir repository yazacağımm. 