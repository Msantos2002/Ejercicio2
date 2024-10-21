using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSwebBurger2.Migrations
{
    /// <inheritdoc />
    public partial class segundoCambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    PromoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPromo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BurgerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.PromoId);
                    table.ForeignKey(
                        name: "FK_Promo_Burger_BurgerID",
                        column: x => x.BurgerID,
                        principalTable: "Burger",
                        principalColumn: "BurgerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_BurgerID",
                table: "Promo",
                column: "BurgerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
