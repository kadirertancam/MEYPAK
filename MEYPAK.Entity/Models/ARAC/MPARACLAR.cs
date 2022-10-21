using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARACLAR
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int muId { get; set; } = 0;
        public string companyName { get; set; } = "";
        public int fleetId { get; set; }=0;
        public string fleetName { get; set; } = "";
        public int groupId { get; set; }= 0;
        public string groupName { get; set; } = "";
        public string plate { get; set; } = "";
        public string label { get; set; } = "";
        public string timezone { get; set; } = "";
        public string deviceType { get; set; } = "";
        public string canbusProfile { get; set; } = "";
        public string networkId { get; set; } = "";
        public int hardwareVersion { get; set; } = 0;
        public int softwareVersion { get; set; } = 0;
        public string softwareSubVersion { get; set; } = "";
        public string phone { get; set; } = ""; 
    }
}
