using System;
using System.Collections.Generic;
using System.Text;

namespace DadosDaFran
{
    public class MostrarDados
    {
        public MostrarDados()
        {
            var dadosDaPessoa = new DadosDaPessoa
            {
                Id = 1,
                Nome = "Nair Carvalho",
                Email = "NairdeCarvalho@gamil.com",
                Idade = 21,
                Nacionalidade = "Angola",
                Telefone = 19999999,
                Agenda = "Nair",
                Profissao = "Programadora"
            };

            Imprimir(dadosDaPessoa);
        }

        public void Imprimir(DadosDaPessoa dadosDaPessoa)
        {
            Console.WriteLine("Id da Pessoa: " + dadosDaPessoa.Id);
            Console.WriteLine("Nome: " + dadosDaPessoa.Nome);
            Console.WriteLine("Email: " + dadosDaPessoa.Email);
            Console.WriteLine("Idade: " + dadosDaPessoa.Idade);
            Console.WriteLine("Nacionalida: " + dadosDaPessoa.Nacionalidade);
            Console.WriteLine("Telefone: " + dadosDaPessoa.Telefone);
            Console.WriteLine("Agenda: " + dadosDaPessoa.Agenda);
            Console.WriteLine("Profissão: " + dadosDaPessoa.Profissao);
        }
    }
}
