using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    interface Paciente
    {
         String getNome();
         void setNome(String nome);
         int getIdade();
         void setIdade(int Idade);
         String getNroConvenio();
         void setNroConvenio(String nroConvenio);
    }
}
