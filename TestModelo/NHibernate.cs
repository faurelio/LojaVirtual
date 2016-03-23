using NHibernate;
using NHibernate.Cfg;

namespace TestModelo
{
    public class NHibernate
    {
        public static ISession OpenSession()
        {
            Configuration config = new Configuration().Configure("hibernate.cfg.xml");

            config.AddAssembly("Modelo"); // assembly onde estão localizados os mapeamentos
            
            var sessionFactory = config.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
