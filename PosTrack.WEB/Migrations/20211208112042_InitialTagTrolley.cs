using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PosTrack.Migrations
{
    public partial class InitialTagTrolley : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    LotDetailId = table.Column<int>(type: "int", nullable: false),
                    WaterContent = table.Column<decimal>(type: "decimal(8,3)", nullable: true),
                    TimeCreatedId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagLabel = table.Column<int>(type: "int", nullable: false),
                    Rfid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trolleys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<int>(type: "int", nullable: false),
                    InService = table.Column<bool>(type: "bit", nullable: false),
                    LeftTagID = table.Column<int>(type: "int", nullable: false),
                    RightTagID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trolleys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trolleys_Tags_LeftTagID",
                        column: x => x.LeftTagID,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trolleys_Tags_RightTagID",
                        column: x => x.RightTagID,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trolleys_LeftTagID",
                table: "Trolleys",
                column: "LeftTagID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trolleys_RightTagID",
                table: "Trolleys",
                column: "RightTagID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lots");

            migrationBuilder.DropTable(
                name: "Trolleys");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
