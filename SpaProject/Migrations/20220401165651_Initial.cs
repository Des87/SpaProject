using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomersTrack",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Department = table.Column<int>(type: "INTEGER", nullable: false),
                    InorOut = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersTrack", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Sauna",
                columns: table => new
                {
                    SaunaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    AllTime = table.Column<TimeSpan>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauna", x => x.SaunaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersTrack");

            migrationBuilder.DropTable(
                name: "Sauna");
        }
    }
}
