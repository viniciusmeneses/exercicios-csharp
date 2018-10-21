
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploStatic
{
    public class Cliente
    {
        private static int nroClientes;

        public static int NroClientes
        {
            get { return Cliente.nroClientes; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(String nome)
        {
            this.nome = nome;
            nroClientes++;
        }
        ~Cliente()
        {
            nroClientes--;
        }
    }
}
