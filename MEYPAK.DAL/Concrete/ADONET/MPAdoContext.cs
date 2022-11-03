using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.ADONET
{
    public class MPAdoContext<T> where T : class, new()
    {
        public MPAdoContext()
        {
            GenericList = new List<T>();
            genericT = new T(); 
        }
        public List<T> GenericList;

        AdoConnect c = new AdoConnect();
        DataTable dt;
        T genericT;

        public void HepsiniGetir()
        {
            GenericList.Clear();


            dt = c.komutoku("SELECT * FROM " + typeof(T).Name);
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    genericT = new T();
                    var k = 0;
                    for (int j = 0; j < genericT.GetType().GetProperties().Count(); j++)
                    {
                       
                        var ba = genericT.GetType().GetProperties()[j].Name.Substring(0, 2).ToString();
                        if (ba != "MP" && ba != "mp")
                        {

                            var a = dt.Rows[i][dt.Columns[k].ColumnName];
                            if (a.ToString() != "{}")
                            {
                                genericT.GetType().GetProperty(dt.Columns[k].ColumnName).SetValue(genericT, dt.Rows[i][dt.Columns[k].ColumnName]);
                            }
                            k++;
                        }
                        else
                        { 
                            var aasd = 1;
                        }


                    }
                    GenericList.Add(genericT);
                }
        }
        public void HepsiniGetir(string where)
        {
            GenericList.Clear();
            c = new AdoConnect();
            dt = c.komutoku("SELECT * FROM " + typeof(T).Name + " Where " + where);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    genericT = new T();
                    var k = 0;
                    for (int j = 0; j < genericT.GetType().GetProperties().Count()-7; j++)
                    {

                        var ba = genericT.GetType().GetProperties()[j].Name.Substring(0, 2).ToString();
                        if (ba != "MP" && ba != "mp")
                        {

                            var a = dt.Rows[i][dt.Columns[k].ColumnName];
                            if (a.ToString() != "{}")
                            {
                                genericT.GetType().GetProperty(dt.Columns[k].ColumnName).SetValue(genericT, dt.Rows[i][dt.Columns[k].ColumnName]);
                            }
                            k++;
                        }
                    }
                    GenericList.Add(genericT);
                }
            }
        }
    }
}
