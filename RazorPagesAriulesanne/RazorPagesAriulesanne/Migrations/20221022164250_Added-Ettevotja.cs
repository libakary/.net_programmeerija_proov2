using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesAriulesanne.Migrations
{
    public partial class AddedEttevotja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lisainfo",
                table: "Eraisik",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Ettevotja",
                columns: table => new
                {
                    EttevotjaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuriidilineNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registrikood = table.Column<long>(type: "bigint", nullable: false),
                    OsavotjateArv = table.Column<int>(type: "int", nullable: false),
                    Maksmisviis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lisainfo = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ettevotja", x => x.EttevotjaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ettevotja");

            migrationBuilder.AlterColumn<string>(
                name: "Lisainfo",
                table: "Eraisik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500,
                oldNullable: true);
        }
    }
}
