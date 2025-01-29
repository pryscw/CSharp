using System;
namespace program_times
{
    class Program
    {
        static List<Mensagem> Mensagens = new List<Mensagem>();
        static List<Usuario> Usuarios = new List<Usuario>();

        static void Main()
        {
            Console.WriteLine("--||| Centro de Mensagens |||--");
            Cadastro();
        }

        static void Centro(Usuario user)
        {
            Console.WriteLine("- Enviar mensagem [ m ]");
            Console.WriteLine("- Ler mensagens [ l ]");
            Console.WriteLine("- Ver informações gerais [ i ]");
            Console.WriteLine("- Sair [ esc ]");
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.M)
            {
                NovaMensagem(user);

            }
            else if (tecla.Key == ConsoleKey.L)
            {
                LerMensagens(user);

            }
            else if(tecla.Key == ConsoleKey.I)
            {
                VerInfo(user);
            }
            else if (tecla.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Você saiu do programa...");
            }
        }

        static void Cadastro()
        {
            
            if(Usuarios.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("< CADASTRO USUÁRIO >");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Usuario user = new Usuario(nome, email);
                Usuarios.Add(user);
                Console.WriteLine();
                Centro(user);
                
            } else
            {
                foreach (Usuario user in Usuarios)
                {
                    Centro(user);
                }
            }  
        }

        static void NovaMensagem(Usuario user)
        {
            Console.WriteLine();
            DateTime data = DateTime.Now;
            Console.WriteLine("Mensagem: ");
            Console.Write("> ");
            string novaMensagem = Console.ReadLine();
            Console.WriteLine("Enter para enviar e voltar.");
            Console.WriteLine();
            Mensagens.Add(new Mensagem(data, novaMensagem, user));
            Enter();
        }

        static void LerMensagens(Usuario user)
        {
            Console.WriteLine();
            Console.WriteLine("Mensagens > ");
            Mensagens.Reverse();

            foreach (Mensagem msg in Mensagens)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"{msg.user.Nome} - ({msg.user.Email}): [{msg.data}]\n   >> {msg.mensagem}");              
                Console.WriteLine("---------------------------------------------------");
            }
            Console.WriteLine("Enter para voltar.");
            Mensagens.Reverse();
            Enter();
        }

        static void VerInfo(Usuario user)
        {
            Mensagem ultimaMensagem = Mensagens.Last();
            DateTime dataUltimaMensagem = ultimaMensagem.data;
            TimeSpan intervalo = DateTime.Now - dataUltimaMensagem;
            
            Console.WriteLine();
            Console.WriteLine("< INFORMAÇÕES GERAIS >");
            Console.WriteLine($"- Nome: {user.Nome}\n- Email: {user.Email}");
            Console.WriteLine($"- Útima mensagem foi escrita à {intervalo.Hours} horas atrás.");
            Console.WriteLine($"- Você possui {Mensagens.Count} mensagens no total.");
        }

        static void Enter()
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Main();
            }
        }
    }

}