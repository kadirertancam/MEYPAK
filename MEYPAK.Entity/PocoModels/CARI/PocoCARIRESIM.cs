using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CARI
{
    public class PocoCARIRESIM:SUPERPOCOMODEL
    {
        public int CARIID { get; set; }
        public int NUM { get; set; } 
        public string IMG { get; set; }
    }
} 