using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudOperations.Migrations
{
    /// <inheritdoc />
    public partial class updatedbrandtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Brands",
                newName: "DeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeviceId",
                table: "Brands",
                newName: "ID");
        }
    }
}
