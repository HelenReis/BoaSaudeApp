using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Camilla Cabelo', 'Cami', '123456', '1997-06-10',0,1,10,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Joana Souza', 'juju', '123456', '1990-06-10',0,2,20,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Lauro Souza','lalau', '123456','1990-06-10',0,3,30,1,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Rogério Santos','rogerio', '123456','1990-06-10',0,3,30,1,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Clara Camilo','clarinha', '123456','1990-03-10',0,1,10,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Laura Mendonça','lauraa', '123456','1990-04-10',2,1,10,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Alisson Mendonça','aliali', '123456','1990-04-10',0,1,10,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Fernando Ribeiro','fefe', '123456','1990-04-10',0,1,10,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Shawn Mendes','shashaw', '123456','1990-04-10',0,4,15,0,0)");
            migrationBuilder.Sql("INSERT INTO Associado (nome, nomeUsuario, senha, dataNascimento, status, planoId, quantidadeExamesAno, possuiOdontologico, valorPlanoAdicional) VALUES ('Loris Ribeiro','lori', '123456','1990-04-10',0,5,25,0,0)");

            migrationBuilder.Sql("INSERT INTO Prestador (nome, crm, nomeUsuario, senha) VALUES ('Alisson Mendonça', 'mr6565', 'alisson', '12345')");
            migrationBuilder.Sql("INSERT INTO Prestador (nome, crm, nomeUsuario, senha) VALUES ('Clara Mendonça', 'mr6685', 'clara', '12345')");
            migrationBuilder.Sql("INSERT INTO Prestador (nome, crm, nomeUsuario, senha) VALUES ('Rogério Mendonça', 'mr6765', 'roger', '12345')");
            migrationBuilder.Sql("INSERT INTO Prestador (nome, crm, nomeUsuario, senha) VALUES ('Felipe Mendonça', 'mr6525', 'felipe', '12345')");

            migrationBuilder.Sql("INSERT INTO Conveniado (nomeFantasia, cnpj, nomeUsuario, senha) VALUES ('Consultório Mendonça', '63306684000174', 'consul', '12345')");
            migrationBuilder.Sql("INSERT INTO Conveniado (nomeFantasia, cnpj, nomeUsuario, senha) VALUES ('Consultório Iris', '42269347000184', 'consul1', '12345')");
            migrationBuilder.Sql("INSERT INTO Conveniado (nomeFantasia, cnpj, nomeUsuario, senha) VALUES ('Consultório Balance', '95508022000173', 'consul2', '12345')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
