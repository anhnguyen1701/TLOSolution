using Microsoft.EntityFrameworkCore.Migrations;

namespace TLOSoltuion.Data.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8229da4a-a412-46a1-aa64-ff1bea347717");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9970e043-ce5e-4959-9e13-cd66c432ee3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3b7cf3a-0b92-44e7-a393-f875097cda11");

            migrationBuilder.RenameColumn(
                name: "Descripton",
                table: "Category",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0bfa98c-42ef-45c8-a459-3c7cdd943655", "2d52f129-af07-4136-ad25-960bb7a82350", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05b6468d-489f-49a3-b2b7-58761b249566", "36507cb4-e75d-4117-b95a-7b3aa777ab6c", "Publisher", "PUBLISHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12578aed-2d84-4fd8-8b06-c2e8eb738ab1", "6076f60f-bee4-4b5f-baa7-7510653ae9a0", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b6468d-489f-49a3-b2b7-58761b249566");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12578aed-2d84-4fd8-8b06-c2e8eb738ab1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bfa98c-42ef-45c8-a459-3c7cdd943655");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Category",
                newName: "Descripton");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3b7cf3a-0b92-44e7-a393-f875097cda11", "e5bfe730-6667-4399-8323-8254cdaf54c7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8229da4a-a412-46a1-aa64-ff1bea347717", "299f1700-e9b1-4a28-8903-ad38dcaa65d0", "Publisher", "PUBLISHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9970e043-ce5e-4959-9e13-cd66c432ee3d", "3b939125-f544-46d1-8b5c-d76978b06a46", "Admin", "ADMIN" });
        }
    }
}
