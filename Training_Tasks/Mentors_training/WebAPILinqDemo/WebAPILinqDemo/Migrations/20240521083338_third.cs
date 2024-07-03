using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPILinqDemo.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Department");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
