using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using MEYPAK.PRL.MOBILIZ.MobilizAssets;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;

namespace MEYPAK.PRL.MOBILIZ
{
    public partial class FMobilizPanel : Form
    {
        string _token;
        MobilizGenericData<IhlalCount> _data;
        MobilizGenericData<AktiviteOzet.Root> _aktiviteOzet;
        MobilizGenericData<CanbusYakıtOzet.Root> _canbusYakıtOzet;
        MobilizGenericData<AnlıkDurumlarAracSayisi.Root> _anlikDurumlarAracSayisi;
        MobilizGenericData<EnCokIhlalYapanAraclar.Root> _EnCokIhlalYapanAraclar;
        public FMobilizPanel(string token = "")
        {
            InitializeComponent();
            seriesViews = new SeriesCollection();
            _token = token;
            _data = new MobilizGenericData<IhlalCount>();
            _aktiviteOzet = new MobilizGenericData<AktiviteOzet.Root>();
            _canbusYakıtOzet = new MobilizGenericData<CanbusYakıtOzet.Root>();
            _anlikDurumlarAracSayisi = new MobilizGenericData<AnlıkDurumlarAracSayisi.Root>();
            _EnCokIhlalYapanAraclar = new MobilizGenericData<EnCokIhlalYapanAraclar.Root>();

        }
        public SeriesCollection seriesViews;
        IhlalCount _ıhlalCount;
        AktiviteOzet.Root _tempaktiviteOzet;
        CanbusYakıtOzet.Root canbus;
        AnlıkDurumlarAracSayisi.Root _tempAnlıkDurumlarAracSayisi;
        EnCokIhlalYapanAraclar.Root _tempEnCokIhlalYapanAraclar;
        Func<ChartPoint, string> labelPoint;
        SeriesCollection piechartData;
        private void FMobilizPanel_Load(object sender, EventArgs e)
        {
            #region webservis
            _ıhlalCount = _data.Data("https://ng.mobiliz.com.tr/su7/api/dashboard/violation-count/?id=792358&period=1&type=o", _token);
            _tempaktiviteOzet = _aktiviteOzet.Data("https://ng.mobiliz.com.tr/su7/api/dashboard/activity-summary/?id=792358&period=1&type=o", _token);
            canbus = _canbusYakıtOzet.Data("https://ng.mobiliz.com.tr/su7/api/dashboard/fuel-info/?id=792358&period=1&type=o", _token);
            _tempAnlıkDurumlarAracSayisi = _anlikDurumlarAracSayisi.Data("https://ng.mobiliz.com.tr/su7/api/dashboard/states/?id=792358&type=o", _token);
            _tempEnCokIhlalYapanAraclar = _EnCokIhlalYapanAraclar.Data("https://ng.mobiliz.com.tr/su7/api/dashboard/most-violated-vehicles/?id=792358&period=7&type=o", _token);
            #endregion
            #region labels
            label4.Text = _tempaktiviteOzet.result.totalKm.ToString() + " km";
            label8.Text = canbus.result.odometer.ToString() + "km";
            label9.Text = canbus.result.fuelUsed.ToString() + "lt";
            label10.Text = canbus.result.avgConsumption.ToString() + "lt" + " / 100km";
            linkLabel1.Text = _ıhlalCount.result.ToString();
            #endregion
            #region chartseries Anlık Araç Sayısı
            labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection piechartData = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Hareket (%"+_tempaktiviteOzet.result.workTimePercent+")",
                    Values = new ChartValues<double> {_tempaktiviteOzet.result.workTimePercent},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Rölantide (%"+_tempaktiviteOzet.result.idleTimePercent+")",
                    Values = new ChartValues<double> {_tempaktiviteOzet.result.idleTimePercent},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Durma (%"+_tempaktiviteOzet.result.stopTimePercent+")",
                    Values = new ChartValues<double> {_tempaktiviteOzet.result.stopTimePercent},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };


            pieChart1.Series = piechartData;

            pieChart1.LegendLocation = LegendLocation.Right;


            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Anlık Araç Durumları",

                Labels = new List<string> { "Rölantide", "Harketli", "Duran" },

            });
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection
            {
              new ColumnSeries
              {

                Values = new ChartValues<LiveCharts.Defaults.ObservableValue>
                {
                    new ObservableValue(_tempAnlıkDurumlarAracSayisi.result.movingVehicleCount),
                },Title="Harketli",Name="Harketli",DataLabels= true,
              },
              new ColumnSeries
              {
                Values = new ChartValues<ObservableValue>
                {
                  new ObservableValue(_tempAnlıkDurumlarAracSayisi.result.idleVehicleCount),
                },Title="Rölantide",PointGeometry = DefaultGeometries.Square,Name="Rölantide",DataLabels= true,
              },
               new ColumnSeries
              {
                Values = new ChartValues<ObservableValue>
                {
                  new ObservableValue(_tempAnlıkDurumlarAracSayisi.result.stoppedVehicleCount),
                },Title="Duran",Name="Duran",DataLabels= true,
              },

            };


            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart1.Series = series;

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Adet",
                LabelFormatter = value => value.ToString()
            });
            #endregion
            #region chartseries Ençok İhlal yapan 
            series = new LiveCharts.SeriesCollection();
            foreach (var item in _tempEnCokIhlalYapanAraclar.result)
            {
                 
                series.Add( 
              new RowSeries
              {

                Values = new ChartValues<LiveCharts.Defaults.ObservableValue>
                {
                    new ObservableValue(item.violationCount),
                },Title=item.plate.ToString(),DataLabels= true,
              }

               );
            }

            cartesianChart2.LegendLocation = LegendLocation.Right;
            cartesianChart2.Series = series;
            
            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Ihlal",
                LabelFormatter = value => value.ToString()
            });
            #endregion


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FIhlalList fIhlalList = new FIhlalList(_token);
            fIhlalList.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = (canbus.result.fuelUsed * Convert.ToDouble(numericUpDown1.Value)).ToString("N") + " TL";
        }
    }
}
