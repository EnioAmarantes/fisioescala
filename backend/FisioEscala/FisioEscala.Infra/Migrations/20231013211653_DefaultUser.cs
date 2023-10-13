using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioEscala.Infra.Migrations
{
    /// <inheritdoc />
    public partial class DefaultUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { new Guid("89336f57-728e-405c-8558-cde47fefb9a5"), "enio.amarantes@gmail.com", "Enio Amarantes", "password" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("89336f57-728e-405c-8558-cde47fefb9a5"));
        }
    }
}
