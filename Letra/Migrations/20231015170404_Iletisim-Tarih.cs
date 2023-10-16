﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Letra.Migrations
{
    public partial class IletisimTarih : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "İletisim",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "İletisim");
        }
    }
}
