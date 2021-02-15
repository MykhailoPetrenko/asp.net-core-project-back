using Microsoft.EntityFrameworkCore.Migrations;

namespace Party.DB.Migrations
{
    public partial class change_skarga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skarga_Wydarzenies_WydarzenieIdWydarzenie",
                table: "Skarga");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skarga",
                table: "Skarga");

            migrationBuilder.DropIndex(
                name: "IX_Skarga_WydarzenieIdWydarzenie",
                table: "Skarga");

            migrationBuilder.DropColumn(
                name: "WydarzenieIdWydarzenie",
                table: "Skarga");

            migrationBuilder.AlterColumn<int>(
                name: "IdSkarga",
                table: "Skarga",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdWydarzenie",
                table: "Skarga",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdUczestnik",
                table: "Skarga",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skarga",
                table: "Skarga",
                columns: new[] { "IdWydarzenie", "IdUczestnik" });

            migrationBuilder.CreateIndex(
                name: "IX_Skarga_IdUczestnik",
                table: "Skarga",
                column: "IdUczestnik");

            migrationBuilder.AddForeignKey(
                name: "FK_Skarga_Uczestnik_IdUczestnik",
                table: "Skarga",
                column: "IdUczestnik",
                principalTable: "Uczestnik",
                principalColumn: "IdOsoba",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skarga_Wydarzenies_IdWydarzenie",
                table: "Skarga",
                column: "IdWydarzenie",
                principalTable: "Wydarzenies",
                principalColumn: "IdWydarzenie",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skarga_Uczestnik_IdUczestnik",
                table: "Skarga");

            migrationBuilder.DropForeignKey(
                name: "FK_Skarga_Wydarzenies_IdWydarzenie",
                table: "Skarga");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skarga",
                table: "Skarga");

            migrationBuilder.DropIndex(
                name: "IX_Skarga_IdUczestnik",
                table: "Skarga");

            migrationBuilder.DropColumn(
                name: "IdWydarzenie",
                table: "Skarga");

            migrationBuilder.DropColumn(
                name: "IdUczestnik",
                table: "Skarga");

            migrationBuilder.AlterColumn<int>(
                name: "IdSkarga",
                table: "Skarga",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "WydarzenieIdWydarzenie",
                table: "Skarga",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skarga",
                table: "Skarga",
                column: "IdSkarga");

            migrationBuilder.CreateIndex(
                name: "IX_Skarga_WydarzenieIdWydarzenie",
                table: "Skarga",
                column: "WydarzenieIdWydarzenie");

            migrationBuilder.AddForeignKey(
                name: "FK_Skarga_Wydarzenies_WydarzenieIdWydarzenie",
                table: "Skarga",
                column: "WydarzenieIdWydarzenie",
                principalTable: "Wydarzenies",
                principalColumn: "IdWydarzenie",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
