using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    partial class MyWindowsService : ServiceBase
    {
        ServiceHost host;

        public MyWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(MyWCFService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
