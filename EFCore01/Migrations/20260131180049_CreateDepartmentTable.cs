using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore01.Migrations
{
    /// <inheritdoc />
    public partial class CreateDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "Sales",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    DepartmenName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, defaultValue: "HR"),
                    DataOfCreation = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments",
                schema: "Sales");
        }
    }
}
