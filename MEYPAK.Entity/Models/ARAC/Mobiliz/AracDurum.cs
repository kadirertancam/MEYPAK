using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC.Mobiliz
{
    public class AracDurum
    {
        public class AdditionalData
        {
            public DateTime endDate { get; set; }
            public DateTime startDate { get; set; }
        }

        public class AdditionalFieldList
        {
            public string formatOption { get; set; }
            public string field { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class ExecutionDetails
        {
            public string cronExpression { get; set; }
            public int duration { get; set; }
            public object validUntil { get; set; }
            public DateTime startTime { get; set; }
            public bool isScheduled { get; set; }
            public DateTime endTime { get; set; }
        }

        public class InputList
        {
            public bool dirSelectable { get; set; }
            public bool tooltip { get; set; }
            public string label { get; set; }
            public Store store { get; set; }
            public string type { get; set; }
            public bool required { get; set; }
            public object throttlingFactor { get; set; }
            public object filter { get; set; }
            public string name { get; set; }
            public Model model { get; set; }
            public string key { get; set; }
            public bool multiSelection { get; set; }
            public object tooltipDescription { get; set; }
            public bool? defaultSelected { get; set; }
        }

        public class InputParams
        {
            public List<int> destinationMuList { get; set; }
            public bool showStartEndWorkTime { get; set; }
            public List<object> emailList { get; set; }
            public object endDate { get; set; }
            public object serverName { get; set; }
            public string reportFormat { get; set; }
            public string locale { get; set; }
            public bool notify { get; set; }
            public object startKm { get; set; }
            public bool sendEmail { get; set; }
            public object timezoneOffset { get; set; }
            public string timeInterval { get; set; }
            public object moduleId { get; set; }
            public object endKm { get; set; }
            public object reportId { get; set; }
            public object reportUrl { get; set; }
            public object userId { get; set; }
            public string cronExpression { get; set; }
            public object executionTime { get; set; }
            public string endHour { get; set; }
            public object intervalType { get; set; }
            public object companyId { get; set; }
            public string startHour { get; set; }
            public object reportTag { get; set; }
            public object reportTypeId { get; set; }
            public object validUntil { get; set; }
            public bool sendEmailToMe { get; set; }
            public object userRoleId { get; set; }
            public object startDate { get; set; }
        }

        public class Metadata
        {
            public List<OutputList> outputList { get; set; }
            public List<InputList> inputList { get; set; }
            public Throttling throttling { get; set; }
            public int reportId { get; set; }
            public string reportName { get; set; }
            public object configuration { get; set; }
            public string servicePath { get; set; }
            public object graphFieldList { get; set; }
            public object reportUrl { get; set; }
            public object moduleId { get; set; }
            public List<AdditionalFieldList> additionalFieldList { get; set; }
        }

        public class Model
        {
            public string displayKey { get; set; }
            public List<string> fields { get; set; }
            public string recursiveKey { get; set; }
            public string primaryKey { get; set; }
        }

        public class OutputList
        {
            public string field { get; set; }
            public string label { get; set; }
            public string type { get; set; }
            public string formatOption { get; set; }
        }

        public class Result
        {
            public Metadata metadata { get; set; }
            public List<List<object>> data { get; set; }
            public InputParams inputParams { get; set; }
            public ExecutionDetails executionDetails { get; set; }
            public AdditionalData additionalData { get; set; }
            public int id { get; set; }
        }

        public class Root
        {
            public string type { get; set; }
            public object message { get; set; }
            public object errorCode { get; set; }
            public Result result { get; set; }
            public bool success { get; set; }
            public string status { get; set; }
        }

        public class Store
        {
            public string path { get; set; }
            public string method { get; set; }
            public string root { get; set; }
        }

        public class Throttling
        {
            public int minVehicles { get; set; }
            public object minInterval { get; set; }
            public int maxRange { get; set; }
            public int maxVehicles { get; set; }
            public int maxInterval { get; set; }
            public int minRange { get; set; }
        }

    }
}
