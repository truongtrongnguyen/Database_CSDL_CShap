using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationScaffoldinEntityFrameWorkB5657.Migrations
{
    /// <inheritdoc />
    public partial class V3RemoveTagID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "TagIDNew",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagIDNew");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagIDNew",
                table: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "Tags",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagID");
        }
    }
}
