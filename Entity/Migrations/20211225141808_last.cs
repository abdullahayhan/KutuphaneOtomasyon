using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    //Veritabanı değişiklikleri için migration ekleme ve sonrasında güncelleme işlemleri yapılmaktadır.
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    BarkodNo = table.Column<string>(type: "TEXT", nullable: false),
                    KitapAdi = table.Column<string>(type: "TEXT", nullable: true),
                    KitapYazari = table.Column<string>(type: "TEXT", nullable: true),
                    KitapBaskiTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KitapSayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapTuru = table.Column<int>(type: "INTEGER", nullable: false),
                    alinabilirMi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.BarkodNo);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciTc = table.Column<string>(type: "TEXT", nullable: false),
                    OgrenciAdi = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciSoyadi = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciOkul = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciBorc = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciTc);
                });

            migrationBuilder.CreateTable(
                name: "Islemler",
                columns: table => new
                {
                    IslemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapID = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciTC = table.Column<string>(type: "TEXT", nullable: true),
                    KitapAlimTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KitapIadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Ucret = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islemler", x => x.IslemID);
                    table.ForeignKey(
                        name: "FK_Islemler_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "BarkodNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Islemler_Ogrenciler_OgrenciTC",
                        column: x => x.OgrenciTC,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciTc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Islemler_KitapID",
                table: "Islemler",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_Islemler_OgrenciTC",
                table: "Islemler",
                column: "OgrenciTC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Islemler");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
