using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExemploInterface
{
    class Consulta
    {
        private DateTime data;
        private String sintomas;
        private String avaliacao;
        private Medico medico;
        private Paciente paciente;

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Sintomas
        {
            get
            {
                return sintomas;
            }

            set
            {
                sintomas = value;
            }
        }

        public string Avaliacao
        {
            get
            {
                return avaliacao;
            }

            set
            {
                avaliacao = value;
            }
        }

        /*internal Medico Medico
        {
            get
            {
                return medico;
            }

            set
            {
                medico = value;
            }
        }*/

        public Consulta()
        {
            this.data = new DateTime();
            this.sintomas = "";
            this.avaliacao = "";
            this.medico = new Medico();
            this.paciente = null;
        }

        public Consulta(DateTime data, String sintomas, String avalicao, Medico medico, Paciente paciente)
        {
            this.data = data;
            this.sintomas = sintomas;
            this.avaliacao = avalicao;
            this.medico = medico;
            this.paciente = paciente;
        }

        public override String ToString()
        {
            return "Médico:\n" + medico.ToString() + "\n\nPaciente:\n" + paciente.ToString() + "\n\nConsulta:\nData: " + this.data.ToShortDateString() + "\nSintomas: " + this.sintomas.ToString() + "\nAvaliação: " + this.avaliacao.ToString();
        }

        public Boolean Equals(Consulta consulta)
        {
            Boolean retorno = false;
            if (this.data.Equals(consulta.Data) && this.sintomas.Equals(consulta.Sintomas) && this.avaliacao.Equals(consulta.Avaliacao))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
