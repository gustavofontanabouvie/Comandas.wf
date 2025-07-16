using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comandas.WF.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardapioItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    PossuiPreparo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardapioItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroMesa = table.Column<int>(type: "int", nullable: false),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituacaoComanda = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoMesa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComandaItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardapioItemId = table.Column<int>(type: "int", nullable: false),
                    ComandaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComandaItens_CardapioItems_CardapioItemId",
                        column: x => x.CardapioItemId,
                        principalTable: "CardapioItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComandaItens_Comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comandas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidosCozinha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComandaId = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosCozinha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosCozinha_Comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoCozinhaItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoCozinhaId = table.Column<int>(type: "int", nullable: false),
                    ComandaItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCozinhaItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItemId",
                        column: x => x.ComandaItemId,
                        principalTable: "ComandaItens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoCozinhaItems_PedidosCozinha_PedidoCozinhaId",
                        column: x => x.PedidoCozinhaId,
                        principalTable: "PedidosCozinha",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItens_CardapioItemId",
                table: "ComandaItens",
                column: "CardapioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItens_ComandaId",
                table: "ComandaItens",
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
                name: "IX_PedidosCozinha_ComandaId",
                table: "PedidosCozinha",
                column: "ComandaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "PedidoCozinhaItems");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ComandaItens");

            migrationBuilder.DropTable(
                name: "PedidosCozinha");

            migrationBuilder.DropTable(
                name: "CardapioItems");

            migrationBuilder.DropTable(
                name: "Comandas");
        }
    }
}
