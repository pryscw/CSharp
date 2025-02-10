using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataDeEntrada { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }
        public Dictionary<int, Funcionario> Funcionarios { get; set; } = new Dictionary<int, Funcionario>();

        string path = "funcionarios.txt";
        int cont = 0;

        public Funcionario() { }

        public Funcionario(string nome, DateTime dataDeNascimento, DateTime dataDeEntrada, string cpf, string cargo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            DataDeEntrada = dataDeEntrada;
            Cpf = cpf;
            Cargo = cargo;
        }


        public void AddFuncionarioBanco()
        {
            List<Funcionario> lista = new List<Funcionario>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    string[] dados = linha.Split('-');

                    string nome = dados[0];
                    DateTime dataDeNascimento = DateTime.Parse(dados[1]);
                    DateTime dataDeEntrada = DateTime.Parse(dados[2]);
                    string cpf = dados[3];
                    string cargo = dados[4];

                    lista.Add(new Funcionario(nome, dataDeNascimento, dataDeEntrada, cpf, cargo));
                }
            }

            foreach (Funcionario f in lista.OrderBy(f => f.DataDeEntrada))
            {
                if (Funcionarios.Count > 0)
                {
                    cont = Funcionarios.Keys.Max() + 1;
                } else
                {
                    cont = 1;
                }
                Funcionarios.Add(cont, f);
            }
        }

        public void AddFuncionarioBanco(Funcionario funcionario)
        {
            cont++;
            Funcionarios.Add(cont, funcionario);
        }

        public void AddNovoFuncionario()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());
            DateTime dataDeEntrada = DateTime.Now;
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            while (cpf.Length < 11 && cpf.Length > 11)
            {
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
            }
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Funcionario funcionario = new Funcionario(nome, dataDeNascimento, dataDeEntrada, cpf, cargo);

            AddFuncionarioBanco(funcionario);
            AddFuncionarioArquivo(funcionario);
        }

        public void AddFuncionarioArquivo(Funcionario funcionario)
        {
            using StreamWriter sw = File.AppendText(path);
            sw.WriteLine($"{funcionario.Nome}-{funcionario.DataDeNascimento.ToString("dd/MM/yyyy")}-{funcionario.DataDeEntrada.ToString("dd/MM/yyyy")}-{funcionario.Cpf}-{funcionario.Cargo}");
            Process.Start("notepad.exe", path);
        }

        public void MostrarFuncionarios()
        {
            foreach (KeyValuePair<int, Funcionario> f in Funcionarios)
            {
                Console.WriteLine();
                Console.WriteLine($"{f.Key} - {f.Value.Nome}");
                Console.WriteLine($"{f.Value.Cpf} - {f.Value.Cargo}");
                Console.WriteLine($"Entrada: {f.Value.DataDeEntrada} - Data de Nascimento: {f.Value.DataDeNascimento}");
                Console.WriteLine();
            }
        }
    }
}

