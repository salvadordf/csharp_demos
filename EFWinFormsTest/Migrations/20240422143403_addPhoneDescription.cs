using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFWinFormsTest.Migrations
{
    /// <inheritdoc />
    public partial class addPhoneDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Phones",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Phones");
        }
    }
}
