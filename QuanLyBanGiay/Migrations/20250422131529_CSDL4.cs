using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanGiay.Migrations
{
    /// <inheritdoc />
    public partial class CSDL4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDung_PhanQuyen_PhanQuyenID1",
                table: "NguoiDung");

            migrationBuilder.RenameColumn(
                name: "PhanQuyenID1",
                table: "NguoiDung",
                newName: "PhanQuyenID");

            migrationBuilder.RenameIndex(
                name: "IX_NguoiDung_PhanQuyenID1",
                table: "NguoiDung",
                newName: "IX_NguoiDung_PhanQuyenID");

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDung_PhanQuyen_PhanQuyenID",
                table: "NguoiDung",
                column: "PhanQuyenID",
                principalTable: "PhanQuyen",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDung_PhanQuyen_PhanQuyenID",
                table: "NguoiDung");

            migrationBuilder.RenameColumn(
                name: "PhanQuyenID",
                table: "NguoiDung",
                newName: "PhanQuyenID1");

            migrationBuilder.RenameIndex(
                name: "IX_NguoiDung_PhanQuyenID",
                table: "NguoiDung",
                newName: "IX_NguoiDung_PhanQuyenID1");

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDung_PhanQuyen_PhanQuyenID1",
                table: "NguoiDung",
                column: "PhanQuyenID1",
                principalTable: "PhanQuyen",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
