using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.API.Migrations
{
    public partial class initMysql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Registro = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunosCursos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosCursos", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CargaHorario = table.Column<int>(nullable: false),
                    PrerequisitoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                        column: x => x.PrerequisitoId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataIni", "DataNasc", "Idade", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(7794), new DateTime(2004, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "Marta", "Kent", "33225555" },
                    { 2, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(9504), new DateTime(2006, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, "Paula", "Isabela", "3354288" },
                    { 3, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(9566), new DateTime(2007, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, "Laura", "Antonia", "55668899" },
                    { 4, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(9572), new DateTime(2007, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, "Luiza", "Maria", "6565659" },
                    { 5, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(9577), new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, "Lucas", "Machado", "565685415" },
                    { 6, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(9585), new DateTime(2010, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 6, "Pedro", "Alvares", "456454545" },
                    { 7, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 993, DateTimeKind.Local).AddTicks(9590), new DateTime(2011, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 7, "Paulo", "José", "9874512" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Tecnologia da Informação" },
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" }
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataIni", "Nome", "Registro", "Sobrenome" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 989, DateTimeKind.Local).AddTicks(3607), "Lauro", 1, "Oliveira" },
                    { 2, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 990, DateTimeKind.Local).AddTicks(3210), "Roberto", 2, "Soares" },
                    { 3, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 990, DateTimeKind.Local).AddTicks(3264), "Ronaldo", 3, "Marconi" },
                    { 4, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 990, DateTimeKind.Local).AddTicks(3267), "Rodrigo", 4, "Carvalho" },
                    { 5, true, null, new DateTime(2021, 4, 28, 16, 43, 14, 990, DateTimeKind.Local).AddTicks(3268), "Alexandre", 5, "Montanha" }
                });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHorario", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 1, 0, 1, "Matemática", null, 1 },
                    { 2, 0, 3, "Matemática", null, 1 },
                    { 3, 0, 3, "Física", null, 2 },
                    { 4, 0, 1, "Português", null, 3 },
                    { 5, 0, 1, "Inglês", null, 4 },
                    { 6, 0, 2, "Inglês", null, 4 },
                    { 7, 0, 3, "Inglês", null, 4 },
                    { 8, 0, 1, "Programação", null, 5 },
                    { 9, 0, 2, "Programação", null, 5 },
                    { 10, 0, 3, "Programação", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataIni", "Nota" },
                values: new object[,]
                {
                    { 2, 1, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1505), null },
                    { 4, 5, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1521), null },
                    { 2, 5, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1510), null },
                    { 1, 5, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1503), null },
                    { 7, 4, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1537), null },
                    { 6, 4, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1531), null },
                    { 5, 4, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1522), null },
                    { 4, 4, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1519), null },
                    { 1, 4, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1467), null },
                    { 7, 3, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1535), null },
                    { 5, 5, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1523), null },
                    { 6, 3, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1528), null },
                    { 7, 2, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1534), null },
                    { 6, 2, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1526), null },
                    { 3, 2, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1513), null },
                    { 2, 2, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1506), null },
                    { 1, 2, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(868), null },
                    { 7, 1, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1533), null },
                    { 6, 1, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1525), null },
                    { 4, 1, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1518), null },
                    { 3, 1, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1512), null },
                    { 3, 3, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1515), null },
                    { 7, 5, null, new DateTime(2021, 4, 28, 16, 43, 14, 994, DateTimeKind.Local).AddTicks(1538), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_CursoId",
                table: "AlunosCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosCursos");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
