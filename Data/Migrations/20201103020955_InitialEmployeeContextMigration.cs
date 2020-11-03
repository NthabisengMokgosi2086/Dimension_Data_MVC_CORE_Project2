using Microsoft.EntityFrameworkCore.Migrations;

namespace Dimension_Data_MVC_CORE_Project2.Data.Migrations
{
    public partial class InitialEmployeeContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<float>(nullable: false),
                    BusinessTravel = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EducationField = table.Column<float>(nullable: false),
                    EmployeeNumber = table.Column<float>(nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    HourlyRate = table.Column<float>(nullable: false),
                    JobSatisfaction = table.Column<float>(nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MonthlyIncome = table.Column<float>(nullable: false),
                    RelationshipSatisfaction = table.Column<float>(nullable: false),
                    StandardHours = table.Column<float>(nullable: false),
                    StockOptionLevel = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
