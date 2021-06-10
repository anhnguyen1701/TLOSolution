using Microsoft.EntityFrameworkCore.Migrations;

namespace TLOSoltuion.Data.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a7a383-44c6-4c66-badd-6e612931c47f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acfc191f-2875-4d66-8cc0-39ba9bffc9f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa9f441c-7a7b-4f94-b240-8c10c1416953");

            migrationBuilder.RenameColumn(
                name: "Descriptopn",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "Descriptopn");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46a7a383-44c6-4c66-badd-6e612931c47f", "033a7f1a-8b30-434b-a006-cfe00a148dfd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acfc191f-2875-4d66-8cc0-39ba9bffc9f7", "6b3873e5-bb11-427a-8b9d-b091246718f4", "Publisher", "PUBLISHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa9f441c-7a7b-4f94-b240-8c10c1416953", "73eb9bd7-476c-4e77-872d-b2a8896cf9e7", "Admin", "ADMIN" });
        }
    }
}
