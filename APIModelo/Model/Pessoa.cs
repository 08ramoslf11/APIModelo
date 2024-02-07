using Microsoft.AspNetCore.Mvc.Formatters;

namespace APIModelo.Model
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Celular { get; set;}

        public DateOnly DataNascimento { get; set; }

        //Metodo conteudo todos os dados
        public List<Pessoa> Dados()
        {
            var ListaPessoa = new List<Pessoa>();

            var vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "João Sebastião";

            var vPessoa2 = new Pessoa();
            vPessoa2.Id = 2;
            vPessoa2.Nome = "Maria Vitória";

            var vPessoa3 = new Pessoa();
            vPessoa3.Id = 3;
            vPessoa3.Nome = "Renato Camargo";

            ListaPessoa.Add(vPessoa);
            ListaPessoa.Add(vPessoa2);
            ListaPessoa.Add(vPessoa3);

            return ListaPessoa;
        }
    }
}
