using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore01.Migrations
{
    /// <inheritdoc />
    public partial class RenameEmployeeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "EmpName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Employees",
                newName: "Name");
        }
    }
}
