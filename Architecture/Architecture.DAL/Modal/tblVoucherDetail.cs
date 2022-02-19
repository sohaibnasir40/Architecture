using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Architecture.DAL.Modal
{
    public class tblVoucherDetail
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal intSeqId { get; set; }

        
        [Column(Order = 1, TypeName = "numeric")]
        public decimal intVoucherId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal intAccountId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? intRefId { get; set; }

        
        [Column(Order = 2)]
        [StringLength(50)]
        public string varRefType { get; set; }

        [StringLength(1000)]
        public string varDescription { get; set; }

        [StringLength(150)]
        public string varSpecialNotes { get; set; }

        [StringLength(150)]
        public string varChequeNo { get; set; }

        public DateTime? dtChequeDate { get; set; }

        [StringLength(250)]
        public string varBank { get; set; }

        [StringLength(50)]
        public string varChequeStatus { get; set; }

        [StringLength(250)]
        public string varReference { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? intItemId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flTax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flTaxAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flChequeAmt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flDebit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flCredit { get; set; }

        public DateTime? dtCreationDate { get; set; }

    }
}
