using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Architecture.DAL.Modal
{
    public class tblCompany
    {

            [Key]
            [Column(Order = 0)]
            public int intSeqId { get; set; }

            [StringLength(50)]
            public string varName { get; set; }

            [StringLength(250)]
            public string? varStreet { get; set; }

            [StringLength(50)]
            public string? varCity { get; set; }

            [StringLength(50)]
            public string? varState { get; set; }

            [StringLength(50)]
            public string? varPostalCode { get; set; }

            [StringLength(50)]
            public string? varCountry { get; set; }

            [StringLength(50)]
            public string? varPhone { get; set; }

            [StringLength(50)]
            public string? varCellPhone { get; set; }

            [StringLength(50)]
            public string? VarFaxNo { get; set; }

            [StringLength(50)]
            public string? varEmail { get; set; }

            [Column(TypeName = "image")]
            public byte[]? oleImage { get; set; }

            [StringLength(50)]
            public string? varDecription { get; set; }

            [StringLength(50)]
            public string? varNtn { get; set; }

            public int intCompanyId { get; set; }

            public DateTime? dtCreationDate { get; set; }

            public DateTime? dtUpdatedDate { get; set; }

            public int? intCreationBy { get; set; }

            public int? intUpdatedBy { get; set; }

            [StringLength(250)]
            public string? varImage { get; set; }

            [StringLength(350)]
            public string? varAddress { get; set; }

            [StringLength(500)]
            public string? varReportFooter { get; set; }


        } 
    }