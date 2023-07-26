using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement.DataAccess.Migrations
{
    public partial class UpdatedRouteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RouteName",
                table: "Route",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouteName",
                table: "Route");
        }
    }
}
