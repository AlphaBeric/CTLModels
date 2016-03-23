using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CatalogBusiness:ICatalogBusiness
    {
        public UserManager<Happy.Data.ApplicationUser> UserManager { get; set; }
        public CatalogBusiness()
        {
            UserManager = new UserManager<Happy.Data.ApplicationUser>(new UserStore<ApplicationUser>(new DataContext)));
        }
    }
}
