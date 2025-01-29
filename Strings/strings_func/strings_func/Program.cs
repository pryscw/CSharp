using System;
using System.Xml;

namespace strings_func
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verbatim strings
            string pulandoLinhas = "laranja\nleite\nfarinha\novos\nmanteiga";
            Console.WriteLine(pulandoLinhas);

            Console.WriteLine();

            string corte = "porque\b isso\b está\b incompleto\b?";
            Console.WriteLine(corte);

            Console.WriteLine();

            string alerta = "isso\a faz som\a?";
            Console.WriteLine(alerta);

            Console.WriteLine();

            string guiaHorizontal = "não entendi porque a\tdistância";
            Console.WriteLine(guiaHorizontal);

            Console.WriteLine();

            string guiaVertical = "como\v isso funciona?";
            Console.WriteLine(guiaVertical);

            Console.WriteLine();

            string aspasSimples = "\'aspas simples\'";
            Console.WriteLine(aspasSimples);

            Console.WriteLine();

            string aspasDuplas = "\"aspas duplas\"";
            Console.WriteLine(aspasDuplas);

            Console.WriteLine();

            string diretorio1 = "C:\\temp\\codigo";
            string diretorio2 = @"C:\temp\codigo";
            Console.WriteLine(diretorio1);
            Console.WriteLine(diretorio2);

            Console.WriteLine();

            string deQualquerForma = @"posso pular daqui
apenas fazendo
isso.
.
.";
            Console.WriteLine(deQualquerForma);

            Console.WriteLine();

            //Métodos e propriedade para strings
            string tico = "Tico";
            string teco = "Teco!";
            var ticoEteco = String.Join(" e ", new String[] { tico, teco });
            Console.WriteLine(ticoEteco);

            Console.WriteLine();

            string frase = "-macarrão.-arroz.-detergente.-pano.-prato";
            string[] lista = frase.Split('.');
            foreach (var palavras in lista)
            {
                Console.WriteLine(palavras);
            }

            Console.WriteLine();

            string mensagem = "Era uma vez um gato xadrez";
            Console.WriteLine("Letra A no índice: "+ mensagem.IndexOf('a'));
            Console.WriteLine("Letra A no índice: " + mensagem.LastIndexOf('a'));
            Console.WriteLine();
            for (int i =0; i<mensagem.Length; i++)
            {
                Console.WriteLine($"{i}: {mensagem[i]}");
            }

            Console.WriteLine();

            string trocas = "Minha cor favorita é azul.";
            Console.WriteLine(trocas);
            trocas = trocas.Replace("cor", "comida");
            trocas = trocas.Replace("azul", "sanduíche");
            Console.WriteLine("e... " + trocas);

            Console.WriteLine();

            string palavra = "Olá, mundo!";
            Console.WriteLine(palavra.Substring(0, 3));
            string codigoAleatoria = Guid.NewGuid().ToString();
            Console.WriteLine(codigoAleatoria.Substring(0, 3));

            string palavra1 = "palavra";
            string palavra2 = "Palavra";
            Console.WriteLine(palavra1.Equals(palavra2));

            Console.WriteLine();

            // StringBuilder

        }
    }
}