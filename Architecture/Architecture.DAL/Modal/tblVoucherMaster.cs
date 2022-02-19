using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Architecture.DAL.Modal
{
    public class tblVoucherMaster
    {
        [Key]
        [Column(Order = 0)]
        public int intSeqId { get; set; }

        
        [Column(Order = 1)]
        [StringLength(50)]
        public string varVoucherNo { get; set; }

        public DateTime dtVoucherDate { get; set; }


        [StringLength(50)]
        public string varType { get; set; }

        
        public int intCompanyId { get; set; }



        public int isPosted { get; set; }

        [StringLength(50)]
        public string intPostedBy { get; set; }

        public DateTime? dtCreationDate { get; set; }

        [StringLength(50)]
        public string intCreatedBy { get; set; }

        public DateTime? dtModifiedDate { get; set; }

        [StringLength(500)]
        public string varDesc { get; set; }
    }
}
