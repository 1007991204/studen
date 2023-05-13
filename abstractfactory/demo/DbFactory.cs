using SqlSugar;
using static abstractfactory.demo.DbFactory;

namespace abstractfactory.demo
{

    public abstract class AbstractDbFactory
    {
        public abstract T CreateDB<T>() where T : class,IDbLocator;
    }

    public class CreateDbFactory : AbstractDbFactory
    {
        public override T CreateDB<T>()
        {
            try
            {
                var db = Activator.CreateInstance(typeof(T)) as T;
                return db;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
    public class DbFactory
    {
        public interface IDbLocator
        {
            public void PrintInfo();
            public SqlSugarClient GetSqlSugarClient();
        }
        public class MySQLDbLocator : IDbLocator
        {
            public SqlSugarClient GetSqlSugarClient()
            {
                return new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Data Source =localhost; Initial Catalog =school; User Id =root; Password =hzy86561527",
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true
                }, db => { db.Aop.OnLogExecuting = (sql, pars) => { Console.WriteLine(sql); }; });
            }

            public void PrintInfo()
            {
                Console.WriteLine("mysql");
            }
        }
    }
}
