using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Expense_Management
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

}