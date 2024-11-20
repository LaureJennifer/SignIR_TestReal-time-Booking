using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatColumn = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code", "Price", "Row", "SeatColumn", "Status" },
                values: new object[,]
                {
                    { new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec0f"), "A1", 45.0, "A1", 1, 2 },
                    { new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec1f"), "A2", 45.0, "A2", 2, 2 },
                    { new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec2f"), "B1", 45.0, "B2", 1, 2 },
                    { new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec3f"), "B2", 45.0, "B2", 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seats");
        }
    }
}
