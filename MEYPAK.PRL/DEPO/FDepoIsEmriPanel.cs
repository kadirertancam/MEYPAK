using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraVerticalGrid.Native;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepoIsEmriPanel : XtraForm
    {
        public FDepoIsEmriPanel(string sipid="",string emirid="")
        {
            InitializeComponent();
            _sipid= sipid;
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _depoEmirServis = new GenericWebServis<PocoDEPOEMIR>();
            _siparisSevkEmriHarServis=new GenericWebServis<PocoSIPARISSEVKEMIRHAR>();
            _stokSevkiyatList = new GenericWebServis<PocoSTOKSEVKIYATLIST>();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _emirid = emirid;
        }
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoDEPOEMIR> _depoEmirServis;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoSIPARISSEVKEMIRHAR> _siparisSevkEmriHarServis;
        GenericWebServis<PocoSTOKSEVKIYATLIST> _stokSevkiyatList;
        List<PocoSIPARISDETAY> _tempSiparisDetay;
        string _emirid;
        string _sipid;
        private void FDepoIsEmriPanel_Load(object sender, EventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);
            if (_depoEmirServis.obje.Where(x => x.id.ToString() == _emirid).Count() > 0)
            {
                tempp = _siparisSevkEmriHarServis.obje.Where(x => x.emirid.ToString() == _emirid && x.kayittipi==0).Select(x => new DepoIsEmriList()
                {
                    Miktar = x.siparismiktari,
                    SevkMiktarı = x.emirmiktari,
                    StokAdı = _stokServis.obje.Where(c => c.id == (_siparisDetayServis.obje.Where(z => x.sipariskalemid == z.id).Select(z => z.stokid).FirstOrDefault())).FirstOrDefault().adi,
                    StokKodu = _stokServis.obje.Where(c => c.id == (_siparisDetayServis.obje.Where(z => x.sipariskalemid == z.id).Select(z => z.stokid).FirstOrDefault())).FirstOrDefault().kod
                });

            }
            else
            {
                tempp = _siparisDetayServis.obje.Where(x => x.siparisid.ToString() == _sipid && x.kayittipi == 0).Select(x => new DepoIsEmriList
                {
                    StokAdı = x.stokadi,
                    StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod,
                    Miktar = x.safi,
                    SevkMiktarı = 0,

                });
                
            }
            gridControl1.DataSource = tempp;

        }
        bool check=false;
     

        IEnumerable<DepoIsEmriList> tempp;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _siparisServis.Data(ServisList.SiparisListeServis);
            var tempsipdetay = _siparisDetayServis.obje.Where(x => x.siparisid.ToString() == _sipid);
            _stokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
            _depoEmirServis.Data(ServisList.DepoEmirListeServis);
            _tempSiparisDetay = tempsipdetay.ToList();
            int i = 1;
            if (_emirid != "")
            {
                _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarListeServis);

                for (int j = 0; j < gridView1.RowCount; j++)
                {

                    if (Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()) > 0)
                    {
                        var _tempSipDetay = _siparisDetayServis.obje.Where(x => x.siparisid.ToString() == _sipid.ToString() && x.stokid == _stokServis.obje.Where(z => z.kod == gridView1.GetRowCellValue(j, "StokKodu").ToString() && z.kayittipi == 0).Select(z => z.id).FirstOrDefault()).FirstOrDefault();
                        _tempSipDetay.hareketdurumu = 1;
                        _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, _tempSipDetay);
                        _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarEkleServis, new PocoSIPARISSEVKEMIRHAR()
                        {
                            id= _siparisSevkEmriHarServis.obje.Where(z=>z.emirid.ToString()==_emirid).FirstOrDefault().id,
                            emirmiktari = Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()),
                            siparisid = _tempSipDetay.siparisid,
                            sipariskalemid = _tempSipDetay.id,
                            emirid = int.Parse(_emirid),
                            siparismiktari = _tempSipDetay.safi,
                            kullaniciid = 0,
                            tarih = DateTime.Now,
                            tip = 0,

                        });
                        _stokSevkiyatList.Data(ServisList.StokSevkiyatListEkleServis, new PocoSTOKSEVKIYATLIST()
                        {
                            id= _stokSevkiyatList.obje.Where(z=>z.emirid.ToString()==_emirid).FirstOrDefault().id,
                            birimid = _tempSipDetay.birimid,
                            siparismiktari = _tempSipDetay.safi,
                            depoid = _siparisServis.obje.Where(x => x.id == _tempSipDetay.siparisid).FirstOrDefault().depoid,
                            emirid = int.Parse(_emirid),
                            miktar = Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()),
                            kalanmiktar = Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()),
                            stokid = _tempSipDetay.stokid,
                            sevkemriharid = _siparisSevkEmriHarServis.obje2.id,
                            siparisdetayid = _tempSipDetay.id,


                        });

                        i++;
                    }
                }
            }
            else
            {
                _depoEmirServis.Data(ServisList.DepoEmirEkleServis, new PocoDEPOEMIR()
                {
                    siparisid = int.Parse(_sipid),
                    miktar = _tempSiparisDetay.Sum(x => x.safi),
                    sira = i,
                    tarih = DateTime.Now,
                    tip = 0,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
                    durum = 1,
                    depoid = _siparisServis.obje.Where(x => x.id.ToString() == _sipid).FirstOrDefault().depoid,
                    aciklama = "",
                });
                _depoEmirServis.Data(ServisList.DepoEmirListeServis);



                for (int j = 0; j < gridView1.RowCount; j++)
                {

                    if (Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()) > 0)
                    {
                        var _tempSipDetay = _siparisDetayServis.obje.Where(x => x.siparisid.ToString() == _sipid.ToString() && x.stokid == _stokServis.obje.Where(z => z.kod == gridView1.GetRowCellValue(j, "StokKodu").ToString() && z.kayittipi == 0).Select(z => z.id).FirstOrDefault()).FirstOrDefault();
                        _tempSipDetay.hareketdurumu = 1;
                        _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, _tempSipDetay);
                        _siparisSevkEmriHarServis.Data(ServisList.SiparisSevkEmriHarEkleServis, new PocoSIPARISSEVKEMIRHAR()
                        {
                            emirmiktari = Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()),
                            siparisid = _tempSipDetay.siparisid,
                            sipariskalemid = _tempSipDetay.id,
                            emirid = _depoEmirServis.obje2.id,
                            siparismiktari = _tempSipDetay.safi,
                            kullaniciid = 0,
                            tarih = DateTime.Now,
                            tip = 0,

                        });
                        _stokSevkiyatList.Data(ServisList.StokSevkiyatListEkleServis, new PocoSTOKSEVKIYATLIST()
                        {
                            birimid = _tempSipDetay.birimid,
                            siparismiktari = _tempSipDetay.safi,
                            depoid = _siparisServis.obje.Where(x => x.id == _tempSipDetay.siparisid).FirstOrDefault().depoid,
                            emirid = _depoEmirServis.obje2.id,
                            miktar = Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()),
                            kalanmiktar = Convert.ToDecimal(gridView1.GetRowCellValue(j, "SevkMiktarı").ToString()),
                            stokid = _tempSipDetay.stokid,
                            sevkemriharid = _siparisSevkEmriHarServis.obje2.id,
                            siparisdetayid = _tempSipDetay.id,


                        });

                        i++;
                    }
                }
            }
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
        
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
           
        }
    }
}
