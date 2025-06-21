using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisHekimiRandevuSistemi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class M1_TablolarOlusturuldu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hizmetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    HizmetId = table.Column<int>(type: "int", nullable: false),
                    RandevuTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RandevuDurum = table.Column<int>(type: "int", nullable: false),
                    OnayTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevular_Hizmetler_HizmetId",
                        column: x => x.HizmetId,
                        principalTable: "Hizmetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevular_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HizmetId",
                table: "Randevular",
                column: "HizmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_KullaniciId",
                table: "Randevular",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevular");

            migrationBuilder.DropTable(
                name: "Hizmetler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
