using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_times
{
    internal class Mensagem
    {
        public DateTime data { get; set; }
        public string mensagem { get; set; }
        public Usuario user { get; set; }

        public Mensagem(DateTime data, string mensagem, Usuario user)
        {
            this.data = data;
            this.mensagem = mensagem;
            this.user = user;
        }
    }
}
