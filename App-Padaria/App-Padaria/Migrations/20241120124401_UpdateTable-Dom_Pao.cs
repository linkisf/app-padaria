using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableDom_Pao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DOM_Pao_TipoPlacaId",
                table: "DOM_Pao",
                column: "TipoPlacaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_TipoPlacaId",
                table: "DOM_Pao",
                column: "TipoPlacaId",
                principalTable: "DOM_TipoPlaca",
                principalColumn: "TipoPlacaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_TipoPlacaId",
                table: "DOM_Pao");

            migrationBuilder.DropIndex(
                name: "IX_DOM_Pao_TipoPlacaId",
                table: "DOM_Pao");
        }
    }
}
