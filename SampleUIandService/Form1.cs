using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "http://localhost:8733/Design_Time_Addresses/ServiceLayer/MyWCFService/";
            ChannelFactory<IMyWCFService> factory = new ChannelFactory<IMyWCFService>(
                new BasicHttpBinding(), new EndpointAddress(url));
            IMyWCFService proxy = factory.CreateChannel();
            MessageBox.Show(proxy.Echo("Hello!"));
        }
    }
}
