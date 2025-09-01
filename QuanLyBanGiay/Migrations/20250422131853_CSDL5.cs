using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanGiay.Migrations
{
    /// <inheritdoc />
    public partial class CSDL5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_SanPham_SanPhamID",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_SanPhamID",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "SanPhamID",
                table: "HoaDon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SanPhamID",
                table: "HoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_SanPhamID",
                table: "HoaDon",
                column: "SanPhamID");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_SanPham_SanPhamID",
                table: "HoaDon",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
