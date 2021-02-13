using Microsoft.EntityFrameworkCore.Migrations;

namespace Party.DB.Migrations
{
    public partial class addextend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreferencjaUczestnika_Uczestnik_IdUczestnik",
                table: "PreferencjaUczestnika");

            migrationBuilder.DropForeignKey(
                name: "FK_UczestnikWydarzenie_Uczestnik_IdUczestnik",
                table: "UczestnikWydarzenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Wydarzenies_Tworca_TworcaIdTworca",
                table: "Wydarzenies");

            migrationBuilder.DropIndex(
                name: "IX_Wydarzenies_TworcaIdTworca",
                table: "Wydarzenies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Uczestnik",
                table: "Uczestnik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tworca",
                table: "Tworca");

            migrationBuilder.DropColumn(
                name: "TworcaIdTworca",
                table: "Wydarzenies");

            migrationBuilder.DropColumn(
                name: "IdUczestnik",
                table: "Uczestnik");

            migrationBuilder.DropColumn(
                name: "IdTworca",
                table: "Tworca");

            migrationBuilder.AddColumn<int>(
                name: "TworcaIdOsoba",
                table: "Wydarzenies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOsoba",
                table: "Uczestnik",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Uczestnik",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imie",
                table: "Uczestnik",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "Uczestnik",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Wiek",
                table: "Uczestnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdOsoba",
                table: "Tworca",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tworca",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imie",
                table: "Tworca",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "Tworca",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Wiek",
                table: "Tworca",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uczestnik",
                table: "Uczestnik",
                column: "IdOsoba");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tworca",
                table: "Tworca",
                column: "IdOsoba");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenies_TworcaIdOsoba",
                table: "Wydarzenies",
                column: "TworcaIdOsoba");

            migrationBuilder.AddForeignKey(
                name: "FK_PreferencjaUczestnika_Uczestnik_IdUczestnik",
                table: "PreferencjaUczestnika",
                column: "IdUczestnik",
                principalTable: "Uczestnik",
                principalColumn: "IdOsoba",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UczestnikWydarzenie_Uczestnik_IdUczestnik",
                table: "UczestnikWydarzenie",
                column: "IdUczestnik",
                principalTable: "Uczestnik",
                principalColumn: "IdOsoba",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wydarzenies_Tworca_TworcaIdOsoba",
                table: "Wydarzenies",
                column: "TworcaIdOsoba",
                principalTable: "Tworca",
                principalColumn: "IdOsoba",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreferencjaUczestnika_Uczestnik_IdUczestnik",
                table: "PreferencjaUczestnika");

            migrationBuilder.DropForeignKey(
                name: "FK_UczestnikWydarzenie_Uczestnik_IdUczestnik",
                table: "UczestnikWydarzenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Wydarzenies_Tworca_TworcaIdOsoba",
                table: "Wydarzenies");

            migrationBuilder.DropIndex(
                name: "IX_Wydarzenies_TworcaIdOsoba",
                table: "Wydarzenies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Uczestnik",
                table: "Uczestnik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tworca",
                table: "Tworca");

            migrationBuilder.DropColumn(
                name: "TworcaIdOsoba",
                table: "Wydarzenies");

            migrationBuilder.DropColumn(
                name: "IdOsoba",
                table: "Uczestnik");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Uczestnik");

            migrationBuilder.DropColumn(
                name: "Imie",
                table: "Uczestnik");

            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "Uczestnik");

            migrationBuilder.DropColumn(
                name: "Wiek",
                table: "Uczestnik");

            migrationBuilder.DropColumn(
                name: "IdOsoba",
                table: "Tworca");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Tworca");

            migrationBuilder.DropColumn(
                name: "Imie",
                table: "Tworca");

            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "Tworca");

            migrationBuilder.DropColumn(
                name: "Wiek",
                table: "Tworca");

            migrationBuilder.AddColumn<int>(
                name: "TworcaIdTworca",
                table: "Wydarzenies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUczestnik",
                table: "Uczestnik",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdTworca",
                table: "Tworca",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uczestnik",
                table: "Uczestnik",
                column: "IdUczestnik");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tworca",
                table: "Tworca",
                column: "IdTworca");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenies_TworcaIdTworca",
                table: "Wydarzenies",
                column: "TworcaIdTworca");

            migrationBuilder.AddForeignKey(
                name: "FK_PreferencjaUczestnika_Uczestnik_IdUczestnik",
                table: "PreferencjaUczestnika",
                column: "IdUczestnik",
                principalTable: "Uczestnik",
                principalColumn: "IdUczestnik",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UczestnikWydarzenie_Uczestnik_IdUczestnik",
                table: "UczestnikWydarzenie",
                column: "IdUczestnik",
                principalTable: "Uczestnik",
                principalColumn: "IdUczestnik",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wydarzenies_Tworca_TworcaIdTworca",
                table: "Wydarzenies",
                column: "TworcaIdTworca",
                principalTable: "Tworca",
                principalColumn: "IdTworca",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
