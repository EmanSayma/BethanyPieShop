using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanyPieShop.Migrations
{
    public partial class ShoppingCartAddedupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartitem_Pies_PieId",
                table: "ShoppingCartitem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartitem",
                table: "ShoppingCartitem");

            migrationBuilder.RenameTable(
                name: "ShoppingCartitem",
                newName: "ShoppingCartitems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartitem_PieId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartitems_Pies_PieId",
                table: "ShoppingCartitems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartitems",
                table: "ShoppingCartitems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartitems",
                newName: "ShoppingCartitem");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartitems_PieId",
                table: "ShoppingCartitem",
                newName: "IX_ShoppingCartitem_PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartitem",
                table: "ShoppingCartitem",
                column: "ShoppingCartitemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartitem_Pies_PieId",
                table: "ShoppingCartitem",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
