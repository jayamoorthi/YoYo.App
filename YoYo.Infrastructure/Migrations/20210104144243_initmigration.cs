using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace YoYo.Infrastructure.Migrations
{
    public partial class initmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FitnessTests",
                columns: table => new
                {
                    FitnessTestID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PersonID = table.Column<int>(nullable: false),
                    StartDtTime = table.Column<string>(nullable: true),
                    EndDtTime = table.Column<string>(nullable: true),
                    IsWarned = table.Column<bool>(nullable: false),
                    IsWarning = table.Column<bool>(nullable: false),
                    IsStoped = table.Column<bool>(nullable: false),
                    IsStarted = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessTests", x => x.FitnessTestID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Shuttles",
                columns: table => new
                {
                    ShuttleID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FitnessTestID = table.Column<int>(nullable: false),
                    AccumulatedShuttleDistance = table.Column<string>(nullable: true),
                    SpeedLevel = table.Column<string>(nullable: true),
                    ShuttleNo = table.Column<int>(nullable: false),
                    Speed = table.Column<string>(nullable: true),
                    LevelTime = table.Column<string>(nullable: true),
                    CommulativeTime = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    CompletionTime = table.Column<string>(nullable: true),
                    ApproxVo2Max = table.Column<string>(nullable: true),
                    IsWarned = table.Column<bool>(nullable: false),
                    IsWarning = table.Column<bool>(nullable: false),
                    IsStoped = table.Column<bool>(nullable: false),
                    IsBeep = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shuttles", x => x.ShuttleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FitnessTests");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Shuttles");
        }
    }
}
