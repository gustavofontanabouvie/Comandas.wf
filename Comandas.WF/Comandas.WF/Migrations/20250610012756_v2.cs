using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comandas.WF.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardapioItenId",
                table: "ComandaItens",
                newName: "CardapioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosCozinha_ComandaId",
                table: "PedidosCozinha",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_ComandaItemId",
                table: "PedidoCozinhaItems",
                column: "ComandaItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItens_CardapioItemId",
                table: "ComandaItens",
                column: "CardapioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItens_ComandaId",
                table: "ComandaItens",
                column: "ComandaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaItens_CardapioItems_CardapioItemId",
                table: "ComandaItens",
                column: "CardapioItemId",
                principalTable: "CardapioItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaItens_Comandas_ComandaId",
                table: "ComandaItens",
                column: "ComandaId",
                principalTable: "Comandas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItemId",
                table: "PedidoCozinhaItems",
                column: "ComandaItemId",
                principalTable: "ComandaItens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_PedidosCozinha_PedidoCozinhaId",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId",
                principalTable: "PedidosCozinha",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosCozinha_Comandas_ComandaId",
                table: "PedidosCozinha",
                column: "ComandaId",
                principalTable: "Comandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaItens_CardapioItems_CardapioItemId",
                table: "ComandaItens");

            migrationBuilder.DropForeignKey(
                name: "FK_ComandaItens_Comandas_ComandaId",
                table: "ComandaItens");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItemId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_PedidosCozinha_PedidoCozinhaId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosCozinha_Comandas_ComandaId",
                table: "PedidosCozinha");

            migrationBuilder.DropIndex(
                name: "IX_PedidosCozinha_ComandaId",
                table: "PedidosCozinha");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_ComandaItemId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_ComandaItens_CardapioItemId",
                table: "ComandaItens");

            migrationBuilder.DropIndex(
                name: "IX_ComandaItens_ComandaId",
                table: "ComandaItens");

            migrationBuilder.RenameColumn(
                name: "CardapioItemId",
                table: "ComandaItens",
                newName: "CardapioItenId");
        }
    }
}
