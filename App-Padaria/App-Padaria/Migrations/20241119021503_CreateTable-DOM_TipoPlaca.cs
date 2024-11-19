using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_Padaria.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableDOM_TipoPlaca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idTipoPlaca",
                table: "DOM_Pao",
                newName: "idTipoPlacaId");

            migrationBuilder.CreateTable(
                name: "DOM_TipoPlaca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadePaes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOM_TipoPlaca", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DOM_Pao_idTipoPlacaId",
                table: "DOM_Pao",
                column: "idTipoPlacaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_idTipoPlacaId",
                table: "DOM_Pao",
                column: "idTipoPlacaId",
                principalTable: "DOM_TipoPlaca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOM_Pao_DOM_TipoPlaca_idTipoPlacaId",
                table: "DOM_Pao");

            migrationBuilder.DropTable(
                name: "DOM_TipoPlaca");

            migrationBuilder.DropIndex(
                name: "IX_DOM_Pao_idTipoPlacaId",
                table: "DOM_Pao");

            migrationBuilder.RenameColumn(
                name: "idTipoPlacaId",
                table: "DOM_Pao",
                newName: "idTipoPlaca");
        }
    }
}
