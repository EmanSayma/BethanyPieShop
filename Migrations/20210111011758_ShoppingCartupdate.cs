using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanyPieShop.Migrations
{
    public partial class ShoppingCartupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartitems_Pies_PieId",
                table: "ShoppingCartitems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartitems",
                table: "ShoppingCartitems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartitems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartitems_PieId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartitemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCartitems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_PieId",
                table: "ShoppingCartitems",
                newName: "IX_ShoppingCartitems_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartitems",
                table: "ShoppingCartitems",
                column: "ShoppingCartitemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartitems_Pies_PieId",
                table: "ShoppingCartitems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
