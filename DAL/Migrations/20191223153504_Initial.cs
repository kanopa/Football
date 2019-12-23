using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountPlayers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    BornDate = table.Column<DateTime>(nullable: false),
                    ContractDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    Team2Id = table.Column<int>(nullable: false),
                    StadiumId = table.Column<int>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Capacity", "City", "Name" },
                values: new object[,]
                {
                    { 1, 70050, "Киев", "Олимпийский" },
                    { 2, 52667, "Донецк", "Донбасс Арена" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "CountPlayers", "Name" },
                values: new object[,]
                {
                    { 1, "Киев", 5, "Динамо" },
                    { 2, "Донецк", 5, "Шахтер" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "End", "Name", "Region", "Start" },
                values: new object[] { 1, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Украинская премьер лига", "Украина", new DateTime(2019, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BornDate", "ContractDate", "FullName", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Виктор Цыганков", 1 },
                    { 2, new DateTime(1997, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Миккель Дуэлунд", 1 },
                    { 3, new DateTime(1995, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Жерсон Родригес", 1 },
                    { 4, new DateTime(1993, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Беньямин Вербич", 1 },
                    { 5, new DateTime(1988, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Денис Бойко", 1 },
                    { 6, new DateTime(1988, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Тайсон Барселлос Фреда", 2 },
                    { 7, new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Тете", 2 },
                    { 8, new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Жуниор Мораес", 2 },
                    { 9, new DateTime(1984, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Андрей Пятов", 2 },
                    { 10, new DateTime(1988, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Марлос", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_StadiumId",
                table: "Matches",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamId",
                table: "Matches",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
