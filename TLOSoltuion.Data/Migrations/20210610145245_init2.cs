using Microsoft.EntityFrameworkCore.Migrations;

namespace TLOSoltuion.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07b61625-b15c-4b1b-976a-6f554899b79a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1da1f5a7-9839-44d0-a97c-2a18030c2517");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bff8c04-e05b-4ac9-834b-1b116b0a475b");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Post",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imagepath",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b83be45-c7c4-463f-b5d4-16fa0c317f12", "cc41b5fe-3056-4019-9bf7-45cae0df46ca", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "057ec72a-f152-43b6-8362-c4c4a662aac1", "8975ac4d-d7f6-4e3f-8f91-2bedd31c865e", "Publisher", "PUBLISHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0242e1f2-3b88-485f-9bfd-cec4dd93c3a8", "62ca7667-db27-408e-abc2-7cf04e9fb964", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0242e1f2-3b88-485f-9bfd-cec4dd93c3a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "057ec72a-f152-43b6-8362-c4c4a662aac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b83be45-c7c4-463f-b5d4-16fa0c317f12");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "Imagepath",
                table: "Category");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1da1f5a7-9839-44d0-a97c-2a18030c2517", "ed43587e-5d28-44ec-9eea-92c4dc20250c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07b61625-b15c-4b1b-976a-6f554899b79a", "c3593c17-81a6-45ba-94e5-5a76c193eeec", "Publisher", "PUBLISHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bff8c04-e05b-4ac9-834b-1b116b0a475b", "d64b54c4-b7a0-40aa-b309-6203366c85fb", "Admin", "ADMIN" });
        }
    }
}
