using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoKultura.DataAccess.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "QuantityMaterial",
                table: "UsedUpMaterials",
                type: "decimal(18,0)",
                nullable: false,
                defaultValueSql: "00000.000",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "RendersServices",
                type: "decimal(18,0)",
                nullable: false,
                defaultValueSql: "00000000.00",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Count",
                table: "Materials",
                type: "decimal(18,0)",
                nullable: false,
                defaultValueSql: "00000000.000",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "HistoryOfTheChangePriceServicesPartCar",
                type: "decimal(18,0)",
                nullable: false,
                defaultValueSql: "00000000.000",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "HistoryOfTheChangePriceMaterials",
                type: "decimal(18,0)",
                nullable: false,
                defaultValueSql: "00000000.000",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "QuantityMaterial",
                table: "UsedUpMaterials",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValueSql: "00000.000");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "RendersServices",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValueSql: "00000000.00");

            migrationBuilder.AlterColumn<decimal>(
                name: "Count",
                table: "Materials",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValueSql: "00000000.000");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "HistoryOfTheChangePriceServicesPartCar",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValueSql: "00000000.000");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "HistoryOfTheChangePriceMaterials",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValueSql: "00000000.000");
        }
    }
}
