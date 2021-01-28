using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyWCFService" in both code and config file together.
    public class MyWCFService : IMyWCFService
    {
        public string Echo(string message)
        {
            return message;
        }
    }
}
