using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanGiay.Migrations
{
    /// <inheritdoc />
    public partial class CSDL9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "SanPham",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "LoaiSanPham",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "KhachHang",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "HangSanXuat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "DonHang",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "LoaiSanPham");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "HangSanXuat");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "DonHang");
        }
    }
}
