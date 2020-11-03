using Microsoft.EntityFrameworkCore.Migrations;

namespace Dimension_Data_MVC_CORE_Project2.Data.Migrations
{
    public partial class InitialHumanResourceContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanResources",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<float>(nullable: false),
                    BusinessTravel = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DistanceFromHome = table.Column<float>(nullable: false),
                    EducationField = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EmployeeNumber = table.Column<float>(nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    JobRole = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    NumCompaniesWorked = table.Column<float>(nullable: false),
                    OverTime = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    TotalWorkingYears = table.Column<float>(nullable: false),
                    TrainingTimesLastYear = table.Column<float>(nullable: false),
                    YearsAtCompany = table.Column<float>(nullable: false),
                    YearsInCurrentRole = table.Column<float>(nullable: false),
                    YearsSinceLastPromotion = table.Column<float>(nullable: false),
                    YearsWithCurrManager = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResources", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HumanResources");
        }
    }
}
