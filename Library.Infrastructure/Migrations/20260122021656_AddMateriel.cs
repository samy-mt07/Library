using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMateriel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materiels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpruntsMateriel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterielId = table.Column<int>(type: "int", nullable: false),
                    UsagerId = table.Column<int>(type: "int", nullable: false),
                    DateEmprunt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRetourPrevue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRetour = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpruntsMateriel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpruntsMateriel_Materiels_MaterielId",
                        column: x => x.MaterielId,
                        principalTable: "Materiels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpruntsMateriel_Usager_UsagerId",
                        column: x => x.UsagerId,
                        principalTable: "Usager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpruntsMateriel_MaterielId",
                table: "EmpruntsMateriel",
                column: "MaterielId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpruntsMateriel_UsagerId",
                table: "EmpruntsMateriel",
                column: "UsagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpruntsMateriel");

            migrationBuilder.DropTable(
                name: "Materiels");
        }
    }
}
