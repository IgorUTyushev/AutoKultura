using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoKultura.DataAccess.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDecimal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "HistoryOfTheChangePriceMaterials",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldDefaultValueSql: "00000000.000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "HistoryOfTheChangePriceMaterials",
                type: "decimal(18,0)",
                nullable: false,
                defaultValueSql: "00000000.000",
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
