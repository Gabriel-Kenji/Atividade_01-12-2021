using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_12_2021
{
    internal class Medicamentos
    {
        private List<Medicamento> listaMedicamentos = new List<Medicamento>();

        public Medicamentos()
        {
            this.ListaMedicamentos = new List<Medicamento>();
        }

        internal List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public void adicionar(Medicamento medicamento)
        {
            this.ListaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            foreach (Medicamento medicamentos in listaMedicamentos)
            {
                if(medicamentos.Equals(medicamento))
                {
                    if(medicamentos.qtdeDisponivel() == 0)
                    {
                        this.listaMedicamentos.Remove(medicamentos);
                        return true;
                    }
                }
            }


            return false;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            foreach (Medicamento medicamentos in listaMedicamentos)
            {
                if (medicamentos.Equals(medicamento))
                {
                    return medicamentos;
                }
            }

            return new Medicamento();
        }
    }
}
