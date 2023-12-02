﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proper.Context.Migrations
{
    public partial class addBannerTypeColToBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannerType",
                table: "Banners",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerType",
                table: "Banners");
        }
    }
}
