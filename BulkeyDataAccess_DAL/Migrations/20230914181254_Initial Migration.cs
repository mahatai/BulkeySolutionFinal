using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkeyDataAccess_DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "ID", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("7469fc0c-9c23-48a7-8909-7c678243e786"), 1, "Action" },
                    { new Guid("c81c000c-41c0-41b4-8c34-561bee24bea9"), 2, "SciFi" },
                    { new Guid("f36a0935-38b6-4721-86f1-d8eb43f45279"), 3, "History" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catagories");
        }
    }
}
