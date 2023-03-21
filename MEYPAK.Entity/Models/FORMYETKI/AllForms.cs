using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.FORMYETKI
{
    public enum AllForms
    {
        #region STOK
        //STOK TANIM
        STOKTANIM=1,
        HIZMETTANIM=1,
        OLCUBIRIMTANIM = 1,
        MARKATANIM = 1,
        DEPOTANIM = 1,
        SAYIMTANIM = 1,
        STOKKASATANIM = 1,
        STOKKASAMARKATANIM = 1,
        STOKFIYATTANIM = 1,
        STOKLISTE = 1,
        //STOK HAREKET
        STOKHAREKET=2,
        HIZMETHAREKET=2,
        SEVKIYAT=2,
        MALKABUL=2,
        SAYIMISLEME=2,
        STOKKASAHAREKET=2,
        STOKSARF=2,
        STOKKASAGIRISMANUEL=2,
        //STOK RAPORLAR
        STOKFIYATRAPORU=3,
        STOKHAREKETRAPORU=3,
        STOKSAYIMRAPORU=3,
        STOKRAPORU=3,
        STOKKATEGORIRAPORU = 3,
        STOKKASAHAREKETRAPORU = 3,
        DEPORAPORU = 3,
        STOKSEVKIYATRAPORU = 3,
        #endregion

        #region CARI
        //CARITANIM
        CARIKART=4,
        CARIPLASIYERTANIM=4,
        CARILISTE=4,
        //CARIHAREKET
        CARIHAREKET=5,
        CARIDURUMUGOSTER=5,
        //CARIRAPORU
        CARIHAREKETRAPORU=6,
        CARIRAPORU=6,
        #endregion

        #region FATURA
        //FATURATANIM
        FATURATANIM=7,
        ALISFATURATANIM=7,
        SATISIRSALIYETANIM=7,
        ALISIRSALIYETANIM=7,
        MUSTERISIPARISTANIM=7,
        SATINALMASIPARISTANIM=7,
        FATURALISTE=7,
        //FATURAHAREKET
        MUSTERISIPARISINIIRSALIYELESTIR=8,
        SATISIRSALIYESIFATURALASTIR=8,
        //FATURARAPORLAR
        FATURARAPORU=9,
        MUSTERISIPARISRAPORU=9,
        #endregion

        #region CEK/SENET
        //MUSTERICEK
        MUSTERICEKTANIM=10,
        MUSTERICEKCARICIRO=10,
        MUSTERICEKTAHSILAT=10,
        MUSTERICEKTEMINAT=10,
        MUSTERICEKPROTESTO=10,
        //MUSTERISENET  //TO DO
        MUSTERISENETTANIM=11,
        MUSTERISENETCARICIRO=11,
        MUSTERISENETTAHSILAT=11,
        MUSTERISENETTEMINAT=11,
        MUSTERISENETPROTESTO=11,
        //FIRMACEK
        FIRMACEKTANIM=12,
        FIRMACEKLISTE=12,
        CEKSENETDURUM=12,
        //FIRMASENET
        FIRMASENETTANIM=13,
        #endregion

        #region KASA
        //KASATANIM
        KASAKART=15,
        //KASAHAREKET
        KASAHAREKET=16,
        //KASARAPOR
        #endregion

        #region BANKA
        //BANKATANIM
        BANKATANIM=18,
        SUBETANIM=18,
        HESAPTANIM=18,
        //BANKAHAREKET
        HESAPHAREKET=19,
        //BANKARAPOR
        #endregion

        #region E-ISLEMLER
        //EFATURA
        EFATURAGIDENKUTUSU=21,
        EFATURAGELENKUTUSU=21,
        //EARSIV
        EARSIVGIDENKUTUSU=22,
        //EIRSALIYE
        EIRSALIYEGIDENKUTUSU=23,
        EIRSALIYEGELENKUTUSU=23,

        #endregion

        #region PERSONEL
        //TANIM
        PERSONELTANIM=23,
        PERSONELLISTE=23,
        //HAREKET

        //RAPOR
        PERSONELRAPORU=25,
        #endregion

        #region ARAC
        //TANIM
        ARACTANIM=26,
        ARACROTATANIM=26,
        //HAREKET

        #endregion

        #region PARAMETRELER
        PARABIRIMLERI=29,
        SERITANIM=29,
        #endregion

        #region KULLANICIYONETIMI
        KULLANICITANIM=30,
        #endregion

        #region DESTEKSERVIS
        DESTEKSERVIS =31,   
        #endregion
    }
}
