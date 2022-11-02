using DevExpress.DataProcessing.InMemoryDataProcessor;
using MEYPAK.Entity.PocoModels.STOK;
using Remote.Linq.SimpleQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using var serviceProxy = new ServiceProxy<IRemoteLinqDataService>("net.tcp://localhost:8080/remotelinqdataservice");
            IQuery<PocoSTOK> productQuery = serviceProxy
                .CreateQuery<PocoSTOK>(service => service.GetProducts)
                .Where(p => p.Name == "Car");

        }
    }
}
