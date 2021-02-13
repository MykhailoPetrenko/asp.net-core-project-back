using Microsoft.EntityFrameworkCore.Migrations;

namespace Party.DB.Migrations
{
    public partial class uczestnikwydarzenie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UczestnikWydarzenie",
                columns: table => new
                {
                    IdUczestnik = table.Column<int>(nullable: false),
                    IdWydarzenie = table.Column<int>(nullable: false),
                    IdUczestnikWydarzenie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UczestnikWydarzenie", x => new { x.IdWydarzenie, x.IdUczestnik });
                    table.ForeignKey(
                        name: "FK_UczestnikWydarzenie_Uczestnik_IdUczestnik",
                        column: x => x.IdUczestnik,
                        principalTable: "Uczestnik",
                        principalColumn: "IdUczestnik",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UczestnikWydarzenie_Wydarzenies_IdWydarzenie",
                        column: x => x.IdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UczestnikWydarzenie_IdUczestnik",
                table: "UczestnikWydarzenie",
                column: "IdUczestnik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UczestnikWydarzenie");
        }
    }
}
