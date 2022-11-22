using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public  class MPCARIDOKUMAN :SUPERMODEL
    { 
        public int CARIID { get; set; }
        public string ADI { get; set; }

        [MaxLength, Column(TypeName = "ntext")]
        public string DOKUMAN { get; set; }

    }
}
