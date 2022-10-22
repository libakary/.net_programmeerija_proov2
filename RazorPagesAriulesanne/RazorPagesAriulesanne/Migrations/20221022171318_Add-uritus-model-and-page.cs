using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesAriulesanne.Migrations
{
    public partial class Adduritusmodelandpage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uritus",
                columns: table => new
                {
                    UritusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrituseNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Toimumisaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Toimumiskoht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lisainfo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uritus", x => x.UritusID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uritus");
        }
    }
}
