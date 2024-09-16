using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoKultura.DataAccess.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class initDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodyworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodyworks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrandsCars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandsCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOrderOnOutfit = table.Column<int>(type: "int", nullable: false),
                    PathToFilesOrderOnOutfit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinqMaterialForServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinqMaterialForServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasureUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MethodDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicesTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelsCars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandCarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BodyworkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelsCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelsCars_Bodyworks_BodyworkId",
                        column: x => x.BodyworkId,
                        principalTable: "Bodyworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelsCars_BrandsCars_BrandCarId",
                        column: x => x.BrandCarId,
                        principalTable: "BrandsCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    MeasureUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_MeasureUnits_MeasureUnitId",
                        column: x => x.MeasureUnitId,
                        principalTable: "MeasureUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinqMaterialForServiceEntityServiceTypeEntity",
                columns: table => new
                {
                    LinqMaterialsForServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesTypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinqMaterialForServiceEntityServiceTypeEntity", x => new { x.LinqMaterialsForServicesId, x.ServicesTypesId });
                    table.ForeignKey(
                        name: "FK_LinqMaterialForServiceEntityServiceTypeEntity_LinqMaterialForServices_LinqMaterialsForServicesId",
                        column: x => x.LinqMaterialsForServicesId,
                        principalTable: "LinqMaterialForServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinqMaterialForServiceEntityServiceTypeEntity_ServicesTypes_ServicesTypesId",
                        column: x => x.ServicesTypesId,
                        principalTable: "ServicesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartsOfTheCar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsOfTheCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartsOfTheCar_ServicesTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServicesTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vechicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelCarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterNumberCar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vechicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vechicles_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vechicles_ModelsCars_ModelCarId",
                        column: x => x.ModelCarId,
                        principalTable: "ModelsCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryOfTheChangePriceMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryOfTheChangePriceMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryOfTheChangePriceMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinqMaterialForServiceEntityMaterialEntity",
                columns: table => new
                {
                    LinqsServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinqMaterialForServiceEntityMaterialEntity", x => new { x.LinqsServicesId, x.MaterialsId });
                    table.ForeignKey(
                        name: "FK_LinqMaterialForServiceEntityMaterialEntity_LinqMaterialForServices_LinqsServicesId",
                        column: x => x.LinqsServicesId,
                        principalTable: "LinqMaterialForServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinqMaterialForServiceEntityMaterialEntity_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryOfTheChangePriceServicesPartCar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PartOfTheCarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryOfTheChangePriceServicesPartCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryOfTheChangePriceServicesPartCar_PartsOfTheCar_PartOfTheCarId",
                        column: x => x.PartOfTheCarId,
                        principalTable: "PartsOfTheCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VechicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfDeliveryOfTheOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_PymentMethods_PymentMethodId",
                        column: x => x.PymentMethodId,
                        principalTable: "PymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Vechicles_VechicleId",
                        column: x => x.VechicleId,
                        principalTable: "Vechicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RendersServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartOfTheCarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendersServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RendersServices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RendersServices_PartsOfTheCar_PartOfTheCarId",
                        column: x => x.PartOfTheCarId,
                        principalTable: "PartsOfTheCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LinqSpecialistForRenderServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RenderServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinqSpecialistForRenderServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinqSpecialistForRenderServices_RendersServices_RenderServiceId",
                        column: x => x.RenderServiceId,
                        principalTable: "RendersServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinqSpecialistForRenderServices_Specialists_SpecialistId",
                        column: x => x.SpecialistId,
                        principalTable: "Specialists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsedUpMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantityMaterial = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    RenderServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedUpMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsedUpMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsedUpMaterials_RendersServices_RenderServiceId",
                        column: x => x.RenderServiceId,
                        principalTable: "RendersServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoryOfTheChangePriceMaterials_MaterialId",
                table: "HistoryOfTheChangePriceMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryOfTheChangePriceServicesPartCar_PartOfTheCarId",
                table: "HistoryOfTheChangePriceServicesPartCar",
                column: "PartOfTheCarId");

            migrationBuilder.CreateIndex(
                name: "IX_LinqMaterialForServiceEntityMaterialEntity_MaterialsId",
                table: "LinqMaterialForServiceEntityMaterialEntity",
                column: "MaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinqMaterialForServiceEntityServiceTypeEntity_ServicesTypesId",
                table: "LinqMaterialForServiceEntityServiceTypeEntity",
                column: "ServicesTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinqSpecialistForRenderServices_RenderServiceId",
                table: "LinqSpecialistForRenderServices",
                column: "RenderServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_LinqSpecialistForRenderServices_SpecialistId",
                table: "LinqSpecialistForRenderServices",
                column: "SpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MeasureUnitId",
                table: "Materials",
                column: "MeasureUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelsCars_BodyworkId",
                table: "ModelsCars",
                column: "BodyworkId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelsCars_BrandCarId",
                table: "ModelsCars",
                column: "BrandCarId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PymentMethodId",
                table: "Orders",
                column: "PymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VechicleId",
                table: "Orders",
                column: "VechicleId");

            migrationBuilder.CreateIndex(
                name: "IX_PartsOfTheCar_ServiceTypeId",
                table: "PartsOfTheCar",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RendersServices_OrderId",
                table: "RendersServices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RendersServices_PartOfTheCarId",
                table: "RendersServices",
                column: "PartOfTheCarId");

            migrationBuilder.CreateIndex(
                name: "IX_UsedUpMaterials_MaterialId",
                table: "UsedUpMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_UsedUpMaterials_RenderServiceId",
                table: "UsedUpMaterials",
                column: "RenderServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Vechicles_CustomerId",
                table: "Vechicles",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vechicles_ModelCarId",
                table: "Vechicles",
                column: "ModelCarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "HistoryOfTheChangePriceMaterials");

            migrationBuilder.DropTable(
                name: "HistoryOfTheChangePriceServicesPartCar");

            migrationBuilder.DropTable(
                name: "LinqMaterialForServiceEntityMaterialEntity");

            migrationBuilder.DropTable(
                name: "LinqMaterialForServiceEntityServiceTypeEntity");

            migrationBuilder.DropTable(
                name: "LinqSpecialistForRenderServices");

            migrationBuilder.DropTable(
                name: "UsedUpMaterials");

            migrationBuilder.DropTable(
                name: "LinqMaterialForServices");

            migrationBuilder.DropTable(
                name: "Specialists");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "RendersServices");

            migrationBuilder.DropTable(
                name: "MeasureUnits");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PartsOfTheCar");

            migrationBuilder.DropTable(
                name: "PymentMethods");

            migrationBuilder.DropTable(
                name: "Vechicles");

            migrationBuilder.DropTable(
                name: "ServicesTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ModelsCars");

            migrationBuilder.DropTable(
                name: "Bodyworks");

            migrationBuilder.DropTable(
                name: "BrandsCars");
        }
    }
}
