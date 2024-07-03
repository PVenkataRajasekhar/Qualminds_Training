using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnnotationsDemo.Migrations
{
    public partial class newone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Customers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Customers",
                newName: "Email");
        }
    }
}
