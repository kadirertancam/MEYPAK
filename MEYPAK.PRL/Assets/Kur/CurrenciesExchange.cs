using DevExpress.XtraGantt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MEYPAK.PRL.Assets.Kur
{
    public class CurrenciesExchange
    {
        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, DateTime date)
        {
            double num;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(Amount * (ıtem.ForexBuying / currency.ForexBuying), 4));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType, DateTime date)
        {
            double num;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                switch (exchangeType)
                {
                    case ExchangeType.ForexBuying:
                        {
                            num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(Amount * (ıtem.ForexBuying / currency.ForexBuying), 4));
                            return num;
                        }
                    case ExchangeType.ForexSelling:
                        {
                            num = (currency.ForexSelling == 0 || ıtem.ForexSelling == 0 ? 0 : Math.Round(Amount * (ıtem.ForexSelling / currency.ForexSelling), 4));
                            return num;
                        }
                    case ExchangeType.BanknoteBuying:
                        {
                            num = (currency.BanknoteBuying == 0 || ıtem.BanknoteBuying == 0 ? 0 : Math.Round(Amount * (ıtem.BanknoteBuying / currency.BanknoteBuying), 4));
                            return num;
                        }
                    case ExchangeType.BanknoteSelling:
                        {
                            num = (currency.BanknoteSelling == 0 || ıtem.BanknoteSelling == 0 ? 0 : Math.Round(Amount * (ıtem.BanknoteSelling / currency.BanknoteSelling), 4));
                            return num;
                        }
                }
                num = 0;
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, int Year, int Month, int Day)
        {
            double num;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(Amount * (ıtem.ForexBuying / currency.ForexBuying), 4));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static double CalculateHistoricalExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType, int Year, int Month, int Day)
        {
            double num;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                switch (exchangeType)
                {
                    case ExchangeType.ForexBuying:
                        {
                            num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(Amount * (ıtem.ForexBuying / currency.ForexBuying), 4));
                            return num;
                        }
                    case ExchangeType.ForexSelling:
                        {
                            num = (currency.ForexSelling == 0 || ıtem.ForexSelling == 0 ? 0 : Math.Round(Amount * (ıtem.ForexSelling / currency.ForexSelling), 4));
                            return num;
                        }
                    case ExchangeType.BanknoteBuying:
                        {
                            num = (currency.BanknoteBuying == 0 || ıtem.BanknoteBuying == 0 ? 0 : Math.Round(Amount * (ıtem.BanknoteBuying / currency.BanknoteBuying), 4));
                            return num;
                        }
                    case ExchangeType.BanknoteSelling:
                        {
                            num = (currency.BanknoteSelling == 0 || ıtem.BanknoteSelling == 0 ? 0 : Math.Round(Amount * (ıtem.BanknoteSelling / currency.BanknoteSelling), 4));
                            return num;
                        }
                }
                num = 0;
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static double CalculateTodaysExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode)
        {
            double num;
            try
            {
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(Amount * (ıtem.ForexBuying / currency.ForexBuying), 4));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static double CalculateTodaysExchange(double Amount, CurrencyCode FromCurrencyCode, CurrencyCode ToCurrencyCode, ExchangeType exchangeType)
        {
            double num;
            try
            {
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                switch (exchangeType)
                {
                    case ExchangeType.ForexBuying:
                        {
                            num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(Amount * (ıtem.ForexBuying / currency.ForexBuying), 4));
                            return num;
                        }
                    case ExchangeType.ForexSelling:
                        {
                            num = (currency.ForexSelling == 0 || ıtem.ForexSelling == 0 ? 0 : Math.Round(Amount * (ıtem.ForexSelling / currency.ForexSelling), 4));
                            return num;
                        }
                    case ExchangeType.BanknoteBuying:
                        {
                            num = (currency.BanknoteBuying == 0 || ıtem.BanknoteBuying == 0 ? 0 : Math.Round(Amount * (ıtem.BanknoteBuying / currency.BanknoteBuying), 4));
                            return num;
                        }
                    case ExchangeType.BanknoteSelling:
                        {
                            num = (currency.BanknoteSelling == 0 || ıtem.BanknoteSelling == 0 ? 0 : Math.Round(Amount * (ıtem.BanknoteSelling / currency.BanknoteSelling), 4));
                            return num;
                        }
                }
                num = 0;
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static Dictionary<string, Currency> GetAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            Dictionary<string, Currency> currencyRates;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return currencyRates;
        }

        public static Dictionary<string, Currency> GetAllCurrenciesHistoricalExchangeRates(DateTime date)
        {
            Dictionary<string, Currency> currencyRates;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return currencyRates;
        }

        public static Dictionary<string, Currency> GetAllCurrenciesTodaysExchangeRates()
        {
            Dictionary<string, Currency> currencyRates;
            try
            {
                currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return currencyRates;
        }

        private static Dictionary<string, Currency> GetCurrencyRates(string Link)
        {
            Dictionary<string, Currency> strs;
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader(Link);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlTextReader);
                xmlDocument.SelectSingleNode("/Tarih_Date/@Tarih");
                xmlDocument.SelectNodes("/Tarih_Date/Currency");
                XmlNodeList xmlNodeLists = xmlDocument.SelectNodes("/Tarih_Date/Currency/Isim");
                XmlNodeList xmlNodeLists1 = xmlDocument.SelectNodes("/Tarih_Date/Currency/@Kod");
                XmlNodeList xmlNodeLists2 = xmlDocument.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                XmlNodeList xmlNodeLists3 = xmlDocument.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                XmlNodeList xmlNodeLists4 = xmlDocument.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                XmlNodeList xmlNodeLists5 = xmlDocument.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");
                Dictionary<string, Currency> strs1 = new Dictionary<string, Currency>()
                {
                    { "TRY", new Currency("Türk Lirası", "TRY", "TRY/TRY", 1, 1, 1, 1) }
                };
                for (int i = 0; i < xmlNodeLists.Count; i++)
                {
                    Currency currency = new Currency(xmlNodeLists.Item(i).InnerText.ToString(), xmlNodeLists1.Item(i).InnerText.ToString(), string.Concat(xmlNodeLists1.Item(i).InnerText.ToString(), "/TRY"), (string.IsNullOrWhiteSpace(xmlNodeLists2.Item(i).InnerText.ToString()) ? 0 : Convert.ToDouble(xmlNodeLists2.Item(i).InnerText.ToString().Replace(".", ","))), (string.IsNullOrWhiteSpace(xmlNodeLists3.Item(i).InnerText.ToString()) ? 0 : Convert.ToDouble(xmlNodeLists3.Item(i).InnerText.ToString().Replace(".", ","))), (string.IsNullOrWhiteSpace(xmlNodeLists4.Item(i).InnerText.ToString()) ? 0 : Convert.ToDouble(xmlNodeLists4.Item(i).InnerText.ToString().Replace(".", ","))), (string.IsNullOrWhiteSpace(xmlNodeLists5.Item(i).InnerText.ToString()) ? 0 : Convert.ToDouble(xmlNodeLists5.Item(i).InnerText.ToString().Replace(".", ","))));
                    strs1.Add(xmlNodeLists1.Item(i).InnerText.ToString(), currency);
                }
                strs = strs1;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return strs;
        }

        public static DataTable GetDataTableAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
        {
            DataTable dataTable;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                DataTable dataTable1 = new DataTable();
                dataTable1.Columns.Add("Name", typeof(string));
                dataTable1.Columns.Add("Code", typeof(string));
                dataTable1.Columns.Add("CrossRateName", typeof(string));
                dataTable1.Columns.Add("ForexBuying", typeof(double));
                dataTable1.Columns.Add("ForexSelling", typeof(double));
                dataTable1.Columns.Add("BanknoteBuying", typeof(double));
                dataTable1.Columns.Add("BanknoteSelling", typeof(double));
                foreach (string key in currencyRates.Keys)
                {
                    DataRow name = dataTable1.NewRow();
                    name["Name"] = currencyRates[key].Name;
                    name["Code"] = currencyRates[key].Code;
                    name["CrossRateName"] = currencyRates[key].CrossRateName;
                    name["ForexBuying"] = currencyRates[key].ForexBuying;
                    name["ForexSelling"] = currencyRates[key].ForexSelling;
                    name["BanknoteBuying"] = currencyRates[key].BanknoteBuying;
                    name["BanknoteSelling"] = currencyRates[key].BanknoteSelling;
                    dataTable1.Rows.Add(name);
                }
                dataTable = dataTable1;
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return dataTable;
        }

        public static DataTable GetDataTableAllCurrenciesHistoricalExchangeRates(DateTime date)
        {
            DataTable dataTable;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                DataTable dataTable1 = new DataTable();
                dataTable1.Columns.Add("Name", typeof(string));
                dataTable1.Columns.Add("Code", typeof(string));
                dataTable1.Columns.Add("CrossRateName", typeof(string));
                dataTable1.Columns.Add("ForexBuying", typeof(double));
                dataTable1.Columns.Add("ForexSelling", typeof(double));
                dataTable1.Columns.Add("BanknoteBuying", typeof(double));
                dataTable1.Columns.Add("BanknoteSelling", typeof(double));
                foreach (string key in currencyRates.Keys)
                {
                    DataRow name = dataTable1.NewRow();
                    name["Name"] = currencyRates[key].Name;
                    name["Code"] = currencyRates[key].Code;
                    name["CrossRateName"] = currencyRates[key].CrossRateName;
                    name["ForexBuying"] = currencyRates[key].ForexBuying;
                    name["ForexSelling"] = currencyRates[key].ForexSelling;
                    name["BanknoteBuying"] = currencyRates[key].BanknoteBuying;
                    name["BanknoteSelling"] = currencyRates[key].BanknoteSelling;
                    dataTable1.Rows.Add(name);
                }
                dataTable = dataTable1;
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return dataTable;
        }

        public static DataTable GetDataTableAllCurrenciesTodaysExchangeRates()
        {
            DataTable dataTable;
            try
            {
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
                DataTable dataTable1 = new DataTable();
                dataTable1.Columns.Add("Name", typeof(string));
                dataTable1.Columns.Add("Code", typeof(string));
                dataTable1.Columns.Add("CrossRateName", typeof(string));
                dataTable1.Columns.Add("ForexBuying", typeof(double));
                dataTable1.Columns.Add("ForexSelling", typeof(double));
                dataTable1.Columns.Add("BanknoteBuying", typeof(double));
                dataTable1.Columns.Add("BanknoteSelling", typeof(double));
                foreach (string key in currencyRates.Keys)
                {
                    DataRow name = dataTable1.NewRow();
                    name["Name"] = currencyRates[key].Name;
                    name["Code"] = currencyRates[key].Code;
                    name["CrossRateName"] = currencyRates[key].CrossRateName;
                    name["ForexBuying"] = currencyRates[key].ForexBuying;
                    name["ForexSelling"] = currencyRates[key].ForexSelling;
                    name["BanknoteBuying"] = currencyRates[key].BanknoteBuying;
                    name["BanknoteSelling"] = currencyRates[key].BanknoteSelling;
                    dataTable1.Rows.Add(name);
                }
                dataTable = dataTable1;
            }
            catch 
            { 
                dataTable = new DataTable();
            }
            return dataTable;
        }

        public static double GetHistoricalCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, DateTime date)
        {
            double num;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(currency.ForexBuying / ıtem.ForexBuying, 4));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static double GetHistoricalCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, int Year, int Month, int Day)
        {
            double num;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(currency.ForexBuying / ıtem.ForexBuying, 4));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static Currency GetHistoricalCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, DateTime date)
        {
            Currency currency;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency ıtem1 = currencyRates[ToCurrencyCode.ToString()];
                currency = new Currency(ıtem1.Name, ıtem1.Code, string.Concat(ıtem1.Code, "/", ıtem.Code), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return currency;
        }

        public static Currency GetHistoricalCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode, int Year, int Month, int Day)
        {
            Currency currency;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency ıtem1 = currencyRates[ToCurrencyCode.ToString()];
                currency = new Currency(ıtem1.Name, ıtem1.Code, string.Concat(ıtem1.Code, "/", ıtem.Code), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return currency;
        }

        public static Currency GetHistoricalExchangeRates(CurrencyCode Currency, int Year, int Month, int Day)
        {
            Currency ıtem;
            try
            {
                string str = string.Format("{0:0000}", Year);
                string str1 = string.Format("{0:00}", Month);
                string str2 = string.Format("{0:00}", Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(Currency.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", Currency.ToString(), ") was not found!"));
                }
                ıtem = currencyRates[Currency.ToString()];
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return ıtem;
        }

        public static Currency GetHistoricalExchangeRates(CurrencyCode Currency, DateTime date)
        {
            Currency ıtem;
            try
            {
                string str = string.Format("{0:0000}", date.Year);
                string str1 = string.Format("{0:00}", date.Month);
                string str2 = string.Format("{0:00}", date.Day);
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates(string.Concat(new string[] { "http://www.tcmb.gov.tr/kurlar/", str, str1, "/", str2, str1, str, ".xml" }));
                if (!currencyRates.Keys.Contains<string>(Currency.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", Currency.ToString(), ") was not found!"));
                }
                ıtem = currencyRates[Currency.ToString()];
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return ıtem;
        }

        public static double GetTodaysCrossRate(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode)
        {
            double num;
            try
            {
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency currency = currencyRates[ToCurrencyCode.ToString()];
                num = (currency.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(currency.ForexBuying / ıtem.ForexBuying, 4));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return num;
        }

        public static Currency GetTodaysCrossRates(CurrencyCode ToCurrencyCode, CurrencyCode FromCurrencyCode)
        {
            Currency currency;
            try
            {
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
                if (!currencyRates.Keys.Contains<string>(FromCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", FromCurrencyCode.ToString(), ") was not found!"));
                }
                if (!currencyRates.Keys.Contains<string>(ToCurrencyCode.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", ToCurrencyCode.ToString(), ") was not found!"));
                }
                Currency ıtem = currencyRates[FromCurrencyCode.ToString()];
                Currency ıtem1 = currencyRates[ToCurrencyCode.ToString()];
                currency = new Currency(ıtem1.Name, ıtem1.Code, string.Concat(ıtem1.Code, "/", ıtem.Code), (ıtem1.ForexBuying == 0 || ıtem.ForexBuying == 0 ? 0 : Math.Round(ıtem1.ForexBuying / ıtem.ForexBuying, 4)), (ıtem1.ForexSelling == 0 || ıtem.ForexSelling == 0 ? 0 : Math.Round(ıtem1.ForexSelling / ıtem.ForexSelling, 4)), (ıtem1.BanknoteBuying == 0 || ıtem.BanknoteBuying == 0 ? 0 : Math.Round(ıtem1.BanknoteBuying / ıtem.BanknoteBuying, 4)), (ıtem1.BanknoteSelling == 0 || ıtem.BanknoteSelling == 0 ? 0 : Math.Round(ıtem1.BanknoteSelling / ıtem.BanknoteSelling, 4)));
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return currency;
        }

        public static Currency GetTodaysExchangeRates(CurrencyCode Currency)
        {
            Currency ıtem;
            try
            {
                Dictionary<string, Currency> currencyRates = CurrenciesExchange.GetCurrencyRates("http://www.tcmb.gov.tr/kurlar/today.xml");
                if (!currencyRates.Keys.Contains<string>(Currency.ToString()))
                {
                    throw new Exception(string.Concat("The specified currency(", Currency.ToString(), ") was not found!"));
                }
                ıtem = currencyRates[Currency.ToString()];
            }
            catch (Exception exception)
            {
                throw new Exception("The date specified may be a weekend or a public holiday!");
            }
            return ıtem;
        }
    }
}