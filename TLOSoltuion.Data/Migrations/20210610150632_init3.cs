using Microsoft.EntityFrameworkCore.Migrations;

namespace TLOSoltuion.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Descriptopn",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Descriptopn",
                table: "Category");

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
    }
}
