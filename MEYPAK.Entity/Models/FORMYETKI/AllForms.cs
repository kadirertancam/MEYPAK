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
        STOKTANIM,
        HIZMETTANIM,
        OLCUBIRIMTANIM,
        MARKATANIM,
        DEPOTANIM,
        SAYIMTANIM,
        STOKKASATANIM,
        STOKKASAMARKATANIM,
        STOKFIYATTANIM,
        STOKLISTE,
        //STOK HAREKET
        STOKHAREKET,
        HIZMETHAREKET,
        SEVKIYAT,
        MALKABUL,
        SAYIMISLEME,
        STOKKASAHAREKET,
        STOKSARF,
        STOKKASAGIRISMANUEL,
        //STOK RAPORLAR
        STOKFIYATRAPORU,
        STOKHAREKETRAPORU,
        STOKSAYIMRAPORU,
        STOKRAPORU,
        STOKKATEGORIRAPORU,
        STOKKASAHAREKETRAPORU,
        DEPORAPORU,
        STOKSEVKIYATRAPORU,
        #endregion
        #region CARI
        //CARITANIM
        CARIKART,
        CARIPLASIYERTANIM,
        CARILISTE,
        //CARIHAREKET
        CARIHAREKET,
        CARIDURUMUGOSTER,
        //CARIRAPORU
        CARIHAREKETRAPORU,
        CARIRAPORU,
        #endregion
        #region FATURA
        //FATURATANIM
        FATURATANIM,
        ALISFATURATANIM,
        SATISIRSALIYETANIM,
        ALISIRSALIYETANIM,
        MUSTERISIPARISTANIM,
        SATINALMASIPARISTANIM,
        FATURALISTE,
        //FATURAHAREKET
        MUSTERISIPARISINIIRSALIYELESTIR,
        SATISIRSALIYESIFATURALASTIR,
        //FATURARAPORLAR
        FATURARAPORU,
        MUSTERISIPARISRAPORU,
        #endregion
        #region CEK/SENET
        //MUSTERICEK
        MUSTERICEKTANIM,
        MUSTERICEKCARICIRO,
        MUSTERICEKTAHSILAT,
        MUSTERICEKTEMINAT,
        MUSTERICEKPROTESTO,
        //MUSTERISENET
        MUSTERISENETTANIM,
        MUSTERISENETCARICIRO,
        MUSTERISENETTAHSILAT,
        MUSTERISENETTEMINAT,
        MUSTERISENETPROTESTO,
        //FIRMACEK
        FIRMACEKTANIM,
        FIRMACEKLISTE,
        CEKSENETDURUM,
        //FIRMASENET
        FIRMASENETTANIM,
        #endregion
        #region KASA
        //KASATANIM
        KASAKART,
        //KASAHAREKET
        KASAHAREKET,
        //KASARAPOR
        #endregion
        #region BANKA
        //BANKATANIM
        BANKATANIM,
        SUBETANIM,
        HESAPTANIM,
        //BANKAHAREKET
        HESAPHAREKET,
        //BANKARAPOR
        #endregion
        #region E-ISLEMLER
        //EFATURA
        EFATURAGIDENKUTUSU,
        EFATURAGELENKUTUSU,
        //EARSIV
        EARSIVGIDENKUTUSU,
        #endregion
        #region PERSONEL
        //TANIM
        #endregion
    }
}
