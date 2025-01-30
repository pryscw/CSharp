namespace file_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Usuarios = new Dictionary<string, string>();

            var path = "usuarios.txt";
            using (StreamReader sr = new StreamReader(File.OpenRead(path)))
            {
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    string[] valores = linha.Split(" ");
                    string id = valores[0];
                    string name = valores[1];

                    Usuarios.Add(id, name);
                }
            }

            foreach (KeyValuePair<string, string> valuePair in Usuarios)
            {
                Console.WriteLine($"{valuePair.Key} - {valuePair.Value}");
            }

        }
    }
}