using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableDOM_TipoMassa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_idTipoPlacaId",
                table: "DOM_Pao");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "DOM_TipoPlaca",
                newName: "NomeTipoPlaca");

            migrationBuilder.RenameColumn(
                name: "idTipoPlacaId",
                table: "DOM_Pao",
                newName: "TipoPlacaId");

            migrationBuilder.RenameColumn(
                name: "idTipoMassa",
                table: "DOM_Pao",
                newName: "TipoMassaId");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "DOM_Pao",
                newName: "NomePao");

            migrationBuilder.RenameIndex(
                name: "IX_DOM_Pao_idTipoPlacaId",
                table: "DOM_Pao",
                newName: "IX_DOM_Pao_TipoPlacaId");

            migrationBuilder.CreateTable(
                name: "DOM_TipoMassa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoMassa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOM_TipoMassa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DOM_Pao_TipoMassaId",
                table: "DOM_Pao",
                column: "TipoMassaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOM_Pao_DOM_TipoMassa_TipoMassaId",
                table: "DOM_Pao",
                column: "TipoMassaId",
                principalTable: "DOM_TipoMassa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_TipoPlacaId",
                table: "DOM_Pao",
                column: "TipoPlacaId",
                principalTable: "DOM_TipoPlaca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOM_Pao_DOM_TipoMassa_TipoMassaId",
                table: "DOM_Pao");

            migrationBuilder.DropForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_TipoPlacaId",
                table: "DOM_Pao");

            migrationBuilder.DropTable(
                name: "DOM_TipoMassa");

            migrationBuilder.DropIndex(
                name: "IX_DOM_Pao_TipoMassaId",
                table: "DOM_Pao");

            migrationBuilder.RenameColumn(
                name: "NomeTipoPlaca",
                table: "DOM_TipoPlaca",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "TipoPlacaId",
                table: "DOM_Pao",
                newName: "idTipoPlacaId");

            migrationBuilder.RenameColumn(
                name: "TipoMassaId",
                table: "DOM_Pao",
                newName: "idTipoMassa");

            migrationBuilder.RenameColumn(
                name: "NomePao",
                table: "DOM_Pao",
                newName: "Nome");

            migrationBuilder.RenameIndex(
                name: "IX_DOM_Pao_TipoPlacaId",
                table: "DOM_Pao",
                newName: "IX_DOM_Pao_idTipoPlacaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_idTipoPlacaId",
                table: "DOM_Pao",
                column: "idTipoPlacaId",
                principalTable: "DOM_TipoPlaca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
