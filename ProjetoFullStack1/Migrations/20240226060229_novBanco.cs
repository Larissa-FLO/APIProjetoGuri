using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFullStack1.Migrations
{
    public partial class novBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "turmas",
                columns: table => new
                {
                    codTurma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profResponsavel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    instrumento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    turno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__turmas__8EE1EC2F224B1FD3", x => x.codTurma);
                });

            migrationBuilder.CreateTable(
                name: "alunos",
                columns: table => new
                {
                    IdAluno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeAluno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    dataNasc = table.Column<DateTime>(type: "date", nullable: false),
                    nomeResponsavel1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    nomeResponsavel2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    telContato = table.Column<int>(type: "int", nullable: false),
                    codTurma = table.Column<int>(type: "int", nullable: false),
                    dataInicio = table.Column<DateTime>(type: "date", nullable: false),
                    frequencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__alunos__8092FCB384CA9662", x => x.IdAluno);
                    table.ForeignKey(
                        name: "FK__alunos__codTurma__398D8EEE",
                        column: x => x.codTurma,
                        principalTable: "turmas",
                        principalColumn: "codTurma");
                });

            migrationBuilder.CreateIndex(
                name: "IX_alunos_codTurma",
                table: "alunos",
                column: "codTurma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alunos");

            migrationBuilder.DropTable(
                name: "turmas");
        }
    }
}
