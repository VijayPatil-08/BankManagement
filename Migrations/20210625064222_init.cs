using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankManagmentSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    useraccount = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guardiantype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    guardianname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactnumber = table.Column<long>(type: "bigint", nullable: false),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    registrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    accounttype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branchname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citizenshipstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    initialdeposit = table.Column<long>(type: "bigint", nullable: false),
                    idcardnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    referenceaccountholdername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    referenceaccountholderaccountnumber = table.Column<long>(type: "bigint", nullable: false),
                    referenceaccountholderaddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
