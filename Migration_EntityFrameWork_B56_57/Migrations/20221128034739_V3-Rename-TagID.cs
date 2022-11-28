using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationScaffoldinEntityFrameWorkB5657.Migrations
{
    /// <inheritdoc />
    public partial class V3RenameTagID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagIDNew",
                table: "Tags",
                newName: "TagID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagID",
                table: "Tags",
                newName: "TagIDNew");
        }
    }
}
