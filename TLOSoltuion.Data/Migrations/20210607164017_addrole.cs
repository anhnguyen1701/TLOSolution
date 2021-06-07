using Microsoft.EntityFrameworkCore.Migrations;

namespace TLOSoltuion.Data.Migrations
{
    public partial class addrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abe02977-2a69-4ea4-9c27-66125a7447e9", "2aed20cf-16e2-4697-956e-46b3cc65494b", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe02977-2a69-4ea4-9c27-66125a7447e9");
        }
    }
}
