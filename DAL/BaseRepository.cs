using Autofac;
using DAL.Ioc;

namespace DAL
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly DBNContext context;

        public BaseRepository()
        {
            this.context = AutofacContainer.Instance.Resolve<IDataBaseContext>() as DBNContext;
        }
    }
}
