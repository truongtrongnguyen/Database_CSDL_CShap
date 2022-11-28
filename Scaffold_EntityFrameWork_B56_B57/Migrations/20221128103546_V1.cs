using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScaffoldEntityFrameWorkB56B57.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hoten",
                table: "KhachHang",
                newName: "HoTenKH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoTenKH",
                table: "KhachHang",
                newName: "Hoten");
        }
    }
}
