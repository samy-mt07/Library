using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmprunt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usagers",
                table: "Usagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livres",
                table: "Livres");

            migrationBuilder.RenameTable(
                name: "Usagers",
                newName: "Usager");

            migrationBuilder.RenameTable(
                name: "Livres",
                newName: "Livre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usager",
                table: "Usager",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livre",
                table: "Livre",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Emprunts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEmprunt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRetourPrevue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRetourReelle = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Etat = table.Column<int>(type: "int", nullable: false),
                    UsagerId = table.Column<int>(type: "int", nullable: false),
                    LivreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprunts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprunts_Livre_LivreId",
                        column: x => x.LivreId,
                        principalTable: "Livre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emprunts_Usager_UsagerId",
                        column: x => x.UsagerId,
                        principalTable: "Usager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_LivreId",
                table: "Emprunts",
                column: "LivreId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_UsagerId",
                table: "Emprunts",
                column: "UsagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprunts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usager",
                table: "Usager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livre",
                table: "Livre");

            migrationBuilder.RenameTable(
                name: "Usager",
                newName: "Usagers");

            migrationBuilder.RenameTable(
                name: "Livre",
                newName: "Livres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usagers",
                table: "Usagers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livres",
                table: "Livres",
                column: "Id");
        }
    }
}
