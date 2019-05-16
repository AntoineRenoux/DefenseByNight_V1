namespace DAL
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly DBNContext context;

        public BaseRepository(DBNContext context)
        {
            this.context = context;
        }
    }
}
