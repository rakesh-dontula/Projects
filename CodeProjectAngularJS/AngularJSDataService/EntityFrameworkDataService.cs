using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintenanceToolDataServiceInterface;

using System.Data.Entity;
using MaintenanceToolDataService.Migrations;
 
namespace MaintenanceToolDataService
{
  

    public class EntityFrameworkDataService : IDataService, IDisposable
    {

        AngularJSDatabase _connection;

        public AngularJSDatabase dbConnection
        {
            get { return _connection; }
        }


        public void CommitTransaction(Boolean closeSession)
        {
            dbConnection.SaveChanges();
        }

        public void RollbackTransaction(Boolean closeSession)
        {

        }

        public void Save(object entity) { }

        public void CreateSession() {
       
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AngularJSDatabase,  Configuration>()); 
 
            _connection = new AngularJSDatabase();
        }
        public void BeginTransaction() { }

        public void CloseSession() { }

        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}
