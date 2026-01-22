using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmprunts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsagerId1",
                table: "Participations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivreId1",
                table: "Emprunts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsagerId1",
                table: "Emprunts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participations_UsagerId1",
                table: "Participations",
                column: "UsagerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_LivreId1",
                table: "Emprunts",
                column: "LivreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_UsagerId1",
                table: "Emprunts",
                column: "UsagerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprunts_Livre_LivreId1",
                table: "Emprunts",
                column: "LivreId1",
                principalTable: "Livre",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprunts_Usager_UsagerId1",
                table: "Emprunts",
                column: "UsagerId1",
                principalTable: "Usager",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Usager_UsagerId1",
                table: "Participations",
                column: "UsagerId1",
                principalTable: "Usager",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprunts_Livre_LivreId1",
                table: "Emprunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprunts_Usager_UsagerId1",
                table: "Emprunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Usager_UsagerId1",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Participations_UsagerId1",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Emprunts_LivreId1",
                table: "Emprunts");

            migrationBuilder.DropIndex(
                name: "IX_Emprunts_UsagerId1",
                table: "Emprunts");

            migrationBuilder.DropColumn(
                name: "UsagerId1",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "LivreId1",
                table: "Emprunts");

            migrationBuilder.DropColumn(
                name: "UsagerId1",
                table: "Emprunts");
        }
    }
}
