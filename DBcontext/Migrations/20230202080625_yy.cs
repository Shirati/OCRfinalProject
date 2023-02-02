using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBcontext.Migrations
{
    /// <inheritdoc />
    public partial class yy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actions_Users_UserId",
                table: "actions");

            migrationBuilder.DropForeignKey(
                name: "FK_actions_actionTypes_ActionTypeId",
                table: "actions");

            migrationBuilder.DropForeignKey(
                name: "FK_pictures_actions_ActionId",
                table: "pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_permissions_PermissionId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pictures",
                table: "pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_permissions",
                table: "permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actionTypes",
                table: "actionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actions",
                table: "actions");

            migrationBuilder.RenameTable(
                name: "pictures",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "permissions",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "actionTypes",
                newName: "ActionTypes");

            migrationBuilder.RenameTable(
                name: "actions",
                newName: "Actions");

            migrationBuilder.RenameIndex(
                name: "IX_pictures_ActionId",
                table: "Pictures",
                newName: "IX_Pictures_ActionId");

            migrationBuilder.RenameIndex(
                name: "IX_actions_UserId",
                table: "Actions",
                newName: "IX_Actions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_actions_ActionTypeId",
                table: "Actions",
                newName: "IX_Actions_ActionTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "PictureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionTypes",
                table: "ActionTypes",
                column: "ActionTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actions",
                table: "Actions",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_ActionTypes_ActionTypeId",
                table: "Actions",
                column: "ActionTypeId",
                principalTable: "ActionTypes",
                principalColumn: "ActionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Users_UserId",
                table: "Actions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Actions_ActionId",
                table: "Pictures",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Permissions_PermissionId",
                table: "Users",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "PermissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actions_ActionTypes_ActionTypeId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Users_UserId",
                table: "Actions");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Actions_ActionId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Permissions_PermissionId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionTypes",
                table: "ActionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actions",
                table: "Actions");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "pictures");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "permissions");

            migrationBuilder.RenameTable(
                name: "ActionTypes",
                newName: "actionTypes");

            migrationBuilder.RenameTable(
                name: "Actions",
                newName: "actions");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_ActionId",
                table: "pictures",
                newName: "IX_pictures_ActionId");

            migrationBuilder.RenameIndex(
                name: "IX_Actions_UserId",
                table: "actions",
                newName: "IX_actions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Actions_ActionTypeId",
                table: "actions",
                newName: "IX_actions_ActionTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pictures",
                table: "pictures",
                column: "PictureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_permissions",
                table: "permissions",
                column: "PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actionTypes",
                table: "actionTypes",
                column: "ActionTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actions",
                table: "actions",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_actions_Users_UserId",
                table: "actions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_actions_actionTypes_ActionTypeId",
                table: "actions",
                column: "ActionTypeId",
                principalTable: "actionTypes",
                principalColumn: "ActionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_pictures_actions_ActionId",
                table: "pictures",
                column: "ActionId",
                principalTable: "actions",
                principalColumn: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_permissions_PermissionId",
                table: "Users",
                column: "PermissionId",
                principalTable: "permissions",
                principalColumn: "PermissionId");
        }
    }
}
