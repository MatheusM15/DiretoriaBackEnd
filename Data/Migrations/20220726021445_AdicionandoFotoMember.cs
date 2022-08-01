using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class AdicionandoFotoMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FotoId",
                table: "Members",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Members_FotoId",
                table: "Members",
                column: "FotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Arquivos_FotoId",
                table: "Members",
                column: "FotoId",
                principalTable: "Arquivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Arquivos_FotoId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_FotoId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "FotoId",
                table: "Members");
        }
    }
}
