using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaintenanceToolDataModels;

namespace MaintenanceToolWebApplication.WebApiModels
{
   

    public class ApplicationApiModel : TransactionalInformation
    {
    
        public List<ApplicationMenu> MenuItems;

        public ApplicationApiModel()
        {           
            MenuItems = new List<ApplicationMenu>();        
        }

    }

}