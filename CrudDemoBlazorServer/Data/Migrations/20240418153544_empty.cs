using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudDemoBlazorServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class empty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Fees", "Mobile", "StudentAge", "StudentName", "Subject" },
                values: new object[] { 1, "2000", 578989009, 18, "Rahul Joshi", "Hindi" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Ramesh Joshi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
