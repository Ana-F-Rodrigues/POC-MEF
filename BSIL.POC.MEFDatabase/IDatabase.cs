using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIL.POC.MEFDatabase
{
    public interface IDatabase
    {
        string DatabaseName { get; set; }

        bool Login(string userName, string password);
    }
}
