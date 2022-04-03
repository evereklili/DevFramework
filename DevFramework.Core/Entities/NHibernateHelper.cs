using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.EntityFramework.NHihabernate
{
    public abstract class NHibernateHelper : IDisposable
    {

        static ISessionFactory  _sessionFactory;//hangi veritabanın gönderirsek onun oturumunu oluşturacka. 
        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactor()); }
        }

       public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public abstract ISessionFactory InitializeFactor();
         
            //bizim oracle, mysql implementation olmalıdır. 
         

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
}
