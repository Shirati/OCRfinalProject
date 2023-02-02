using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBcontext.Migrations
{
    /// <inheritdoc />
    public partial class changeUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actions_users_UserId",
                table: "actions");

            migrationBuilder.DropForeignKey(
                name: "FK_users_permissions_PermissionId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_users_PermissionId",
                table: "Users",
                newName: "IX_Users_PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_actions_Users_UserId",
                table: "actions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_permissions_PermissionId",
                table: "Users",
                column: "PermissionId",
                principalTable: "permissions",
                principalColumn: "PermissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actions_Users_UserId",
                table: "actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_permissions_PermissionId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PermissionId",
                table: "users",
                newName: "IX_users_PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_actions_users_UserId",
                table: "actions",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_permissions_PermissionId",
                table: "users",
                column: "PermissionId",
                principalTable: "permissions",
                principalColumn: "PermissionId");
        }
    }
}
