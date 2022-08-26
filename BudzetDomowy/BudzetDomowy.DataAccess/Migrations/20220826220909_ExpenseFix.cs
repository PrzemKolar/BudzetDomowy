using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudzetDomowy.DataAccess.Migrations
{
    public partial class ExpenseFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Accounts_AccountId",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Shops_ShopId",
                table: "Expense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expense",
                table: "Expense");

            migrationBuilder.RenameTable(
                name: "Expense",
                newName: "Expenses");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_ShopId",
                table: "Expenses",
                newName: "IX_Expenses_ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_AccountId",
                table: "Expenses",
                newName: "IX_Expenses_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Accounts_AccountId",
                table: "Expenses",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Shops_ShopId",
                table: "Expenses",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Accounts_AccountId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Shops_ShopId",
                table: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.RenameTable(
                name: "Expenses",
                newName: "Expense");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_ShopId",
                table: "Expense",
                newName: "IX_Expense_ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_AccountId",
                table: "Expense",
                newName: "IX_Expense_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expense",
                table: "Expense",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Accounts_AccountId",
                table: "Expense",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Shops_ShopId",
                table: "Expense",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
