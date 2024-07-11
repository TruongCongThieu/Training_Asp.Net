using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EntityFrameWorkCore.Migrations
{
    /// <inheritdoc />
    public partial class AddEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(6, 2",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
