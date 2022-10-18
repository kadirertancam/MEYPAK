using MEYPAK.PRL.MOBILIZ.MobilizAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.MOBILIZ
{
    public partial class FIhlalList : Form
    {
        string _token;
        public FIhlalList(string token="")
        {
            InitializeComponent();
            _token= token;
            _data = new MobilizGenericData<IhlalList.Root>();
        }
        MobilizGenericData<IhlalList.Root> _data;
        IhlalList.Root _tempIhlalList;
        private void FIhlalList_Load(object sender, EventArgs e)
        {
            _tempIhlalList= _data.Data(@"https://ng.mobiliz.com.tr/su7/api/notifications/?startTime=2022-10-17T21:00:00.000Z",_token);
            dataGridView1.DataSource = _tempIhlalList.result;
        }
    }
}
