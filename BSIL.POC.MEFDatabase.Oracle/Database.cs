using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIL.POC.MEFDatabase.Oracle
{
    [Export(typeof(IDatabase))]
    public class Database : IDatabase
    {
        private string _databaseName = string.Empty;

        public Database()
        {
            _databaseName = "Oracle";
        }

        public bool Login(string userName, string password)
        {
            if (userName != string.Empty && password != string.Empty)
            {
                return true;
            }

            return false;
        }

        public string DatabaseName
        {
            get
            {
                return _databaseName;
            }
            set
            {
                _databaseName = value;
            }
        }
    }
}
    

