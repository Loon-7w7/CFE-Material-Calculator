using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionDeMateriales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "materials",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "materials",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationId",
                table: "devices",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_devices_ConsultationId",
                table: "devices",
                column: "ConsultationId");

            migrationBuilder.AddForeignKey(
                name: "FK_devices_consultations_ConsultationId",
                table: "devices",
                column: "ConsultationId",
                principalTable: "consultations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_devices_consultations_ConsultationId",
                table: "devices");

            migrationBuilder.DropIndex(
                name: "IX_devices_ConsultationId",
                table: "devices");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "materials");

            migrationBuilder.DropColumn(
                name: "ConsultationId",
                table: "devices");

            migrationBuilder.AlterColumn<float>(
                name: "Total",
                table: "materials",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);
        }
    }
}
