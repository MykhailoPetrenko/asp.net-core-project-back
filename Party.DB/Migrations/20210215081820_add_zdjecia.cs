using Microsoft.EntityFrameworkCore.Migrations;

namespace Party.DB.Migrations
{
    public partial class add_zdjecia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zdjecia",
                columns: table => new
                {
                    IdZdjecie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    TworcaIdOsoba = table.Column<string>(nullable: true),
                    WydarzenieIdWydarzenie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zdjecia", x => x.IdZdjecie);
                    table.ForeignKey(
                        name: "FK_Zdjecia_Tworca_TworcaIdOsoba",
                        column: x => x.TworcaIdOsoba,
                        principalTable: "Tworca",
                        principalColumn: "IdOsoba",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Zdjecia_Wydarzenies_WydarzenieIdWydarzenie",
                        column: x => x.WydarzenieIdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zdjecia_TworcaIdOsoba",
                table: "Zdjecia",
                column: "TworcaIdOsoba");

            migrationBuilder.CreateIndex(
                name: "IX_Zdjecia_WydarzenieIdWydarzenie",
                table: "Zdjecia",
                column: "WydarzenieIdWydarzenie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zdjecia");
        }
    }
}
