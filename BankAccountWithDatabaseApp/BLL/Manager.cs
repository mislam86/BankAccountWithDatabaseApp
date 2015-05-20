using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountWithDatabaseApp.DAL;
using BankAccountWithDatabaseApp.Model;

namespace BankAccountWithDatabaseApp.BLL
{
    class Manager
    {
        Gateway gateway = new Gateway();

        public string Save(Account anAccount)
        {
            int value = gateway.Save(anAccount);

            if (value > 0)
                return "Saved successfully";
            else
            {
                return "Save failed";
            }
        }
    }
}
