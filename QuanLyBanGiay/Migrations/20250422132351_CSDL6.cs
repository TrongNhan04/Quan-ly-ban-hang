using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanGiay.Migrations
{
    /// <inheritdoc />
    public partial class CSDL6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NgayLap",
                table: "DonHang",
                newName: "NgayLapDonHang");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayLapHoaDon",
                table: "HoaDon",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayLapHoaDon",
                table: "HoaDon");

            migrationBuilder.RenameColumn(
                name: "NgayLapDonHang",
                table: "DonHang",
                newName: "NgayLap");
        }
    }
}
