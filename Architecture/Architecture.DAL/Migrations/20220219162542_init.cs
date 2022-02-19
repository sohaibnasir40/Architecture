using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCompanies",
                columns: table => new
                {
                    intSeqId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varName = table.Column<string>(maxLength: 50, nullable: true),
                    varStreet = table.Column<string>(maxLength: 250, nullable: true),
                    varCity = table.Column<string>(maxLength: 50, nullable: true),
                    varState = table.Column<string>(maxLength: 50, nullable: true),
                    varPostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    varCountry = table.Column<string>(maxLength: 50, nullable: true),
                    varPhone = table.Column<string>(maxLength: 50, nullable: true),
                    varCellPhone = table.Column<string>(maxLength: 50, nullable: true),
                    VarFaxNo = table.Column<string>(maxLength: 50, nullable: true),
                    varEmail = table.Column<string>(maxLength: 50, nullable: true),
                    oleImage = table.Column<byte[]>(type: "image", nullable: true),
                    varDecription = table.Column<string>(maxLength: 50, nullable: true),
                    varNtn = table.Column<string>(maxLength: 50, nullable: true),
                    intCompanyId = table.Column<int>(nullable: false),
                    dtCreationDate = table.Column<DateTime>(nullable: true),
                    dtUpdatedDate = table.Column<DateTime>(nullable: true),
                    intCreationBy = table.Column<int>(nullable: true),
                    intUpdatedBy = table.Column<int>(nullable: true),
                    varImage = table.Column<string>(maxLength: 250, nullable: true),
                    varAddress = table.Column<string>(maxLength: 350, nullable: true),
                    varReportFooter = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanies", x => x.intSeqId);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    intSeqId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    intType = table.Column<int>(nullable: true),
                    varName = table.Column<string>(maxLength: 50, nullable: true),
                    varPassword = table.Column<string>(maxLength: 50, nullable: true),
                    varDisName = table.Column<string>(maxLength: 50, nullable: true),
                    varGender = table.Column<string>(maxLength: 50, nullable: true),
                    varStreet = table.Column<string>(maxLength: 50, nullable: true),
                    varCity = table.Column<string>(maxLength: 50, nullable: true),
                    varState = table.Column<string>(maxLength: 50, nullable: true),
                    varPostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    varCountry = table.Column<int>(nullable: true),
                    varPhone = table.Column<string>(maxLength: 50, nullable: true),
                    varCellPhone = table.Column<string>(maxLength: 50, nullable: true),
                    VarFaxNo = table.Column<string>(maxLength: 50, nullable: true),
                    varEmail = table.Column<string>(maxLength: 50, nullable: true),
                    intCompanyId = table.Column<int>(nullable: false),
                    dtCreationDate = table.Column<DateTime>(nullable: true),
                    dtUpdatedDate = table.Column<DateTime>(nullable: true),
                    intCreationBy = table.Column<int>(nullable: true),
                    intUpdatedBy = table.Column<int>(nullable: true),
                    dtLockTime = table.Column<string>(maxLength: 100, nullable: true),
                    varDesignation = table.Column<string>(maxLength: 250, nullable: true),
                    dtJoiningDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    intSoId = table.Column<int>(nullable: true),
                    varUserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.intSeqId);
                });

            migrationBuilder.CreateTable(
                name: "tblVoucherDetails",
                columns: table => new
                {
                    intSeqId = table.Column<decimal>(type: "numeric", nullable: false),
                    intVoucherId = table.Column<decimal>(type: "numeric", nullable: false),
                    intAccountId = table.Column<decimal>(type: "numeric", nullable: false),
                    intRefId = table.Column<decimal>(type: "numeric", nullable: true),
                    varRefType = table.Column<string>(maxLength: 50, nullable: true),
                    varDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    varSpecialNotes = table.Column<string>(maxLength: 150, nullable: true),
                    varChequeNo = table.Column<string>(maxLength: 150, nullable: true),
                    dtChequeDate = table.Column<DateTime>(nullable: true),
                    varBank = table.Column<string>(maxLength: 250, nullable: true),
                    varChequeStatus = table.Column<string>(maxLength: 50, nullable: true),
                    varReference = table.Column<string>(maxLength: 250, nullable: true),
                    intItemId = table.Column<decimal>(type: "numeric", nullable: true),
                    flQty = table.Column<decimal>(type: "numeric", nullable: true),
                    flRate = table.Column<decimal>(type: "numeric", nullable: true),
                    flTax = table.Column<decimal>(type: "numeric", nullable: true),
                    flTaxAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    flChequeAmt = table.Column<decimal>(type: "numeric", nullable: true),
                    flDebit = table.Column<decimal>(type: "numeric", nullable: true),
                    flCredit = table.Column<decimal>(type: "numeric", nullable: true),
                    dtCreationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVoucherDetails", x => x.intSeqId);
                });

            migrationBuilder.CreateTable(
                name: "tblVoucherMasters",
                columns: table => new
                {
                    intSeqId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varVoucherNo = table.Column<string>(maxLength: 50, nullable: true),
                    dtVoucherDate = table.Column<DateTime>(nullable: false),
                    varType = table.Column<string>(maxLength: 50, nullable: true),
                    intCompanyId = table.Column<int>(nullable: false),
                    isPosted = table.Column<int>(nullable: false),
                    intPostedBy = table.Column<string>(maxLength: 50, nullable: true),
                    dtCreationDate = table.Column<DateTime>(nullable: true),
                    intCreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    dtModifiedDate = table.Column<DateTime>(nullable: true),
                    varDesc = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVoucherMasters", x => x.intSeqId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCompanies");

            migrationBuilder.DropTable(
                name: "tblUsers");

            migrationBuilder.DropTable(
                name: "tblVoucherDetails");

            migrationBuilder.DropTable(
                name: "tblVoucherMasters");
        }
    }
}
