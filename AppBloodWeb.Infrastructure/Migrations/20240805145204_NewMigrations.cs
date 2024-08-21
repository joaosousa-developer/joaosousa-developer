using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppBloodWeb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Idpermissao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Idpermissao);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data_nascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    municipio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    provincia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numeroBI = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numerotelefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idpermissao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Permissao_Idpermissao",
                        column: x => x.Idpermissao,
                        principalTable: "Permissao",
                        principalColumn: "Idpermissao",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Adiministrador",
                columns: table => new
                {
                    IdAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adiministrador", x => x.IdAdmin);
                    table.ForeignKey(
                        name: "FK_Adiministrador_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doador",
                columns: table => new
                {
                    IdDoador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doador", x => x.IdDoador);
                    table.ForeignKey(
                        name: "FK_Doador_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    IdAgenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdDoador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.IdAgenda);
                    table.ForeignKey(
                        name: "FK_Agenda_Doador_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BolsaDeSangue",
                columns: table => new
                {
                    Idbolsa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoSanguineo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VolumeMl = table.Column<double>(type: "double", nullable: false),
                    IdDoador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolsaDeSangue", x => x.Idbolsa);
                    table.ForeignKey(
                        name: "FK_BolsaDeSangue_Doador_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistoricoDoador",
                columns: table => new
                {
                    Idhistorico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataDoacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TipoDoacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDoador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoDoador", x => x.Idhistorico);
                    table.ForeignKey(
                        name: "FK_HistoricoDoador_Doador_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "triagemodel",
                columns: table => new
                {
                    TriagemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataTriagem = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PressaoArterial = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pulso = table.Column<int>(type: "int", nullable: false),
                    Temperatura = table.Column<double>(type: "double", nullable: false),
                    Hemoglobina = table.Column<double>(type: "double", nullable: false),
                    IdDoador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_triagemodel", x => x.TriagemID);
                    table.ForeignKey(
                        name: "FK_triagemodel_Doador_IdDoador",
                        column: x => x.IdDoador,
                        principalTable: "Doador",
                        principalColumn: "IdDoador",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "triagemaptidaomodel",
                columns: table => new
                {
                    AptidaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Apto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MotivoInaptidao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObservacoesAdicionais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TriagemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_triagemaptidaomodel", x => x.AptidaoId);
                    table.ForeignKey(
                        name: "FK_triagemaptidaomodel_triagemodel_TriagemID",
                        column: x => x.TriagemID,
                        principalTable: "triagemodel",
                        principalColumn: "TriagemID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "triagemdetalhesmodel",
                columns: table => new
                {
                    detalhesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HistoricoDoencas = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Medicamentos = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alergias = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ViagensRecentes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComportamentoRisco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    triagemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_triagemdetalhesmodel", x => x.detalhesId);
                    table.ForeignKey(
                        name: "FK_triagemdetalhesmodel_triagemodel_triagemId",
                        column: x => x.triagemId,
                        principalTable: "triagemodel",
                        principalColumn: "TriagemID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Adiministrador_Id",
                table: "Adiministrador",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_IdDoador",
                table: "Agenda",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_BolsaDeSangue_IdDoador",
                table: "BolsaDeSangue",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_Doador_Id",
                table: "Doador",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoDoador_IdDoador",
                table: "HistoricoDoador",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_triagemaptidaomodel_TriagemID",
                table: "triagemaptidaomodel",
                column: "TriagemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_triagemdetalhesmodel_triagemId",
                table: "triagemdetalhesmodel",
                column: "triagemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_triagemodel_IdDoador",
                table: "triagemodel",
                column: "IdDoador");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Idpermissao",
                table: "Usuario",
                column: "Idpermissao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adiministrador");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "BolsaDeSangue");

            migrationBuilder.DropTable(
                name: "HistoricoDoador");

            migrationBuilder.DropTable(
                name: "triagemaptidaomodel");

            migrationBuilder.DropTable(
                name: "triagemdetalhesmodel");

            migrationBuilder.DropTable(
                name: "triagemodel");

            migrationBuilder.DropTable(
                name: "Doador");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Permissao");
        }
    }
}
