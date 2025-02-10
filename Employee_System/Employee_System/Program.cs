using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Employee_System
{
    class Program
    {
        static void Main()
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Funcionários adicionados ao banco.");
            funcionario.AddFuncionarioBanco();
            Console.WriteLine("Adicionar novo funcionário: ");
            funcionario.AddNovoFuncionario();
            Console.WriteLine("Funionários:");
            funcionario.MostrarFuncionarios();

        }       
    }
}