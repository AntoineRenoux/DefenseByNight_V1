using Autofac;
using DAL.Ioc;

namespace DAL
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbnContext context;

        public BaseRepository()
        {
            this.context = AutofacContainer.Instance.Resolve<IDataBaseContext>() as DbnContext;
        }
    }
}
