using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class Gorevcim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 12, 14, 15, 29, 49, 786, DateTimeKind.Local).AddTicks(6012), new DateTime(2022, 12, 14, 15, 29, 49, 786, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 12, 14, 15, 29, 49, 786, DateTimeKind.Local).AddTicks(6014) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 2, 16, 307, DateTimeKind.Local).AddTicks(875), new DateTime(2022, 11, 25, 17, 2, 16, 307, DateTimeKind.Local).AddTicks(866), new DateTime(2022, 11, 25, 17, 2, 16, 307, DateTimeKind.Local).AddTicks(877) });
        }
    }
}
