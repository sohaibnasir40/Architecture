using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Architecture.DAL.Modal
{
    public  class tblUser
    {
        [Key]
        public int intSeqId { get; set; }

        public int? intType { get; set; }

        [StringLength(50)]
        public string varName { get; set; }

        [StringLength(50)]
        public string varPassword { get; set; }

        [StringLength(50)]
        public string varDisName { get; set; }

        [StringLength(50)]
        public string varGender { get; set; }

        [StringLength(50)]
        public string varStreet { get; set; }

        [StringLength(50)]
        public string varCity { get; set; }

        [StringLength(50)]
        public string varState { get; set; }

        [StringLength(50)]
        public string varPostalCode { get; set; }

        public int? varCountry { get; set; }

        [StringLength(50)]
        public string varPhone { get; set; }

        [StringLength(50)]
        public string varCellPhone { get; set; }

        [StringLength(50)]
        public string VarFaxNo { get; set; }

        [StringLength(50)]
        public string varEmail { get; set; }

        
        [Column(Order = 1)]
        public int intCompanyId { get; set; }

        public DateTime? dtCreationDate { get; set; }

        public DateTime? dtUpdatedDate { get; set; }

        public int? intCreationBy { get; set; }

        public int? intUpdatedBy { get; set; }

        [StringLength(100)]
        public string dtLockTime { get; set; }

        [StringLength(250)]
        public string varDesignation { get; set; }

        public DateTime? dtJoiningDate { get; set; }

        public bool? IsActive { get; set; }
        public int? intSoId { get; set; }

        public string varUserType { get; set; }

    }

}
