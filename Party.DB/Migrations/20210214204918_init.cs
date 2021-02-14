using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Party.DB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Miejsca",
                columns: table => new
                {
                    IdMiejsce = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(maxLength: 255, nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    Longitude = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miejsca", x => x.IdMiejsce);
                });

            migrationBuilder.CreateTable(
                name: "Tworca",
                columns: table => new
                {
                    IdOsoba = table.Column<string>(nullable: false),
                    Imie = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Wiek = table.Column<int>(nullable: false),
                    NrKonta = table.Column<string>(nullable: false),
                    StanKonta = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tworca", x => x.IdOsoba);
                });

            migrationBuilder.CreateTable(
                name: "Uczestnik",
                columns: table => new
                {
                    IdOsoba = table.Column<string>(nullable: false),
                    Imie = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Wiek = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uczestnik", x => x.IdOsoba);
                });

            migrationBuilder.CreateTable(
                name: "Wydarzenies",
                columns: table => new
                {
                    IdWydarzenie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzeprowadzenia = table.Column<DateTime>(nullable: false),
                    Typ = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    TworcaIdOsoba = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wydarzenies", x => x.IdWydarzenie);
                    table.ForeignKey(
                        name: "FK_Wydarzenies_Tworca_TworcaIdOsoba",
                        column: x => x.TworcaIdOsoba,
                        principalTable: "Tworca",
                        principalColumn: "IdOsoba",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kategoria",
                columns: table => new
                {
                    IdKategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true),
                    WydarzenieIdWydarzenie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoria", x => x.IdKategoria);
                    table.ForeignKey(
                        name: "FK_Kategoria_Wydarzenies_WydarzenieIdWydarzenie",
                        column: x => x.WydarzenieIdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kometaz",
                columns: table => new
                {
                    IdKometaz = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tresc = table.Column<string>(maxLength: 255, nullable: false),
                    WydarzenieIdWydarzenie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kometaz", x => x.IdKometaz);
                    table.ForeignKey(
                        name: "FK_Kometaz_Wydarzenies_WydarzenieIdWydarzenie",
                        column: x => x.WydarzenieIdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocena",
                columns: table => new
                {
                    IdOcena = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ilosc = table.Column<int>(nullable: false),
                    WydarzenieIdWydarzenie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocena", x => x.IdOcena);
                    table.ForeignKey(
                        name: "FK_Ocena_Wydarzenies_WydarzenieIdWydarzenie",
                        column: x => x.WydarzenieIdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skarga",
                columns: table => new
                {
                    IdSkarga = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tresc = table.Column<string>(nullable: false),
                    WydarzenieIdWydarzenie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skarga", x => x.IdSkarga);
                    table.ForeignKey(
                        name: "FK_Skarga_Wydarzenies_WydarzenieIdWydarzenie",
                        column: x => x.WydarzenieIdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UczestnikWydarzenie",
                columns: table => new
                {
                    IdUczestnik = table.Column<string>(nullable: false),
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
                        principalColumn: "IdOsoba",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UczestnikWydarzenie_Wydarzenies_IdWydarzenie",
                        column: x => x.IdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WydarzenieMiejsce",
                columns: table => new
                {
                    IdWydarzenie = table.Column<int>(nullable: false),
                    IdMiejsce = table.Column<int>(nullable: false),
                    IdWydarzenieMiejsce = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WydarzenieMiejsce", x => new { x.IdWydarzenie, x.IdMiejsce });
                    table.ForeignKey(
                        name: "FK_WydarzenieMiejsce_Miejsca_IdMiejsce",
                        column: x => x.IdMiejsce,
                        principalTable: "Miejsca",
                        principalColumn: "IdMiejsce",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WydarzenieMiejsce_Wydarzenies_IdWydarzenie",
                        column: x => x.IdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preferencja",
                columns: table => new
                {
                    IdPreferencja = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: false),
                    KategoriaIdKategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencja", x => x.IdPreferencja);
                    table.ForeignKey(
                        name: "FK_Preferencja_Kategoria_KategoriaIdKategoria",
                        column: x => x.KategoriaIdKategoria,
                        principalTable: "Kategoria",
                        principalColumn: "IdKategoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WydarzenieKategoria",
                columns: table => new
                {
                    IdWydarzenie = table.Column<int>(nullable: false),
                    IdKategoria = table.Column<int>(nullable: false),
                    IdWydarzenieKategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WydarzenieKategoria", x => new { x.IdWydarzenie, x.IdKategoria });
                    table.ForeignKey(
                        name: "FK_WydarzenieKategoria_Kategoria_IdKategoria",
                        column: x => x.IdKategoria,
                        principalTable: "Kategoria",
                        principalColumn: "IdKategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WydarzenieKategoria_Wydarzenies_IdWydarzenie",
                        column: x => x.IdWydarzenie,
                        principalTable: "Wydarzenies",
                        principalColumn: "IdWydarzenie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreferencjaUczestnika",
                columns: table => new
                {
                    IdUczestnik = table.Column<string>(nullable: false),
                    IdPreferencja = table.Column<int>(nullable: false),
                    IdPreferencjaUczestnika = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferencjaUczestnika", x => new { x.IdPreferencja, x.IdUczestnik });
                    table.ForeignKey(
                        name: "FK_PreferencjaUczestnika_Preferencja_IdPreferencja",
                        column: x => x.IdPreferencja,
                        principalTable: "Preferencja",
                        principalColumn: "IdPreferencja",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferencjaUczestnika_Uczestnik_IdUczestnik",
                        column: x => x.IdUczestnik,
                        principalTable: "Uczestnik",
                        principalColumn: "IdOsoba",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategoria_WydarzenieIdWydarzenie",
                table: "Kategoria",
                column: "WydarzenieIdWydarzenie");

            migrationBuilder.CreateIndex(
                name: "IX_Kometaz_WydarzenieIdWydarzenie",
                table: "Kometaz",
                column: "WydarzenieIdWydarzenie");

            migrationBuilder.CreateIndex(
                name: "IX_Ocena_WydarzenieIdWydarzenie",
                table: "Ocena",
                column: "WydarzenieIdWydarzenie");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencja_KategoriaIdKategoria",
                table: "Preferencja",
                column: "KategoriaIdKategoria");

            migrationBuilder.CreateIndex(
                name: "IX_PreferencjaUczestnika_IdUczestnik",
                table: "PreferencjaUczestnika",
                column: "IdUczestnik");

            migrationBuilder.CreateIndex(
                name: "IX_Skarga_WydarzenieIdWydarzenie",
                table: "Skarga",
                column: "WydarzenieIdWydarzenie");

            migrationBuilder.CreateIndex(
                name: "IX_UczestnikWydarzenie_IdUczestnik",
                table: "UczestnikWydarzenie",
                column: "IdUczestnik");

            migrationBuilder.CreateIndex(
                name: "IX_WydarzenieKategoria_IdKategoria",
                table: "WydarzenieKategoria",
                column: "IdKategoria");

            migrationBuilder.CreateIndex(
                name: "IX_WydarzenieMiejsce_IdMiejsce",
                table: "WydarzenieMiejsce",
                column: "IdMiejsce");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenies_TworcaIdOsoba",
                table: "Wydarzenies",
                column: "TworcaIdOsoba");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kometaz");

            migrationBuilder.DropTable(
                name: "Ocena");

            migrationBuilder.DropTable(
                name: "PreferencjaUczestnika");

            migrationBuilder.DropTable(
                name: "Skarga");

            migrationBuilder.DropTable(
                name: "UczestnikWydarzenie");

            migrationBuilder.DropTable(
                name: "WydarzenieKategoria");

            migrationBuilder.DropTable(
                name: "WydarzenieMiejsce");

            migrationBuilder.DropTable(
                name: "Preferencja");

            migrationBuilder.DropTable(
                name: "Uczestnik");

            migrationBuilder.DropTable(
                name: "Miejsca");

            migrationBuilder.DropTable(
                name: "Kategoria");

            migrationBuilder.DropTable(
                name: "Wydarzenies");

            migrationBuilder.DropTable(
                name: "Tworca");
        }
    }
}
