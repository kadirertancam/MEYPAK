using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ServiceReference2.IntegrationClient ıntegration = new ServiceReference2.IntegrationClient();
            ıntegration.SendInvoiceAsync(new ServiceReference2.InvoiceInfo[]
            {
                new ServiceReference2.InvoiceInfo()
                {
                     CreateDateUtc=DateTime.Now,
                     EArchiveInvoiceInfo= new ServiceReference2.EArchiveInvoiceInformation()
                     {
                          DeliveryType= ServiceReference2.InvoiceDeliveryType.Electronic,
                           InternetSalesInfo= new ServiceReference2.InternetSalesInformation()
                           {
                                PaymentDate=DateTime.UtcNow,
                                 PaymentMidierName= "NAKIT",
                                 PaymentType="NAKIT",
                                 ShipmentInfo= new ServiceReference2.ShipmentInformation()
                                 {
                                      Carier= new ServiceReference2.ShipmentCarier()
                                      {
                                           SenderName="",
                                           SenderTcknVkn="",
                                      },
                                      SendDate=DateTime.Now
                                 },
                                  WebAddress="",
                           },
                           NewGenerationPamentRecorderInfo= new ServiceReference2.NewGenerationPaymentRecorderInformation()
                           {
                                
                           },
                           WithHoldings= new ServiceReference2.EArchiveWithHoldingInformation[]
                           {
                                new ServiceReference2.EArchiveWithHoldingInformation()
                                {
                                      
                                }
                           },

                     },
                     ExtraInformation= "",
                     Invoice= new ServiceReference2.InvoiceType()
                     {
                           
                     }
                }
            });
        }
    }
}
