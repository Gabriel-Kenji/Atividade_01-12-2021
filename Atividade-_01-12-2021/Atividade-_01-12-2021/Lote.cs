using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_12_2021
{
    internal class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public Lote()
        {
            Id = 0;
            Qtde = 0;
            Venc = DateTime.MinValue;
        }

        public Lote(int id, int qtde, DateTime venc)
        {
            this.Id = id;
            this.Qtde = qtde;
            this.Venc = venc;
        }

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        public override string ToString()
        {
            return "id: " + this.Id + " - Qtde: " + this.Qtde + " - Val:" + this.Venc;
        }
    }
}
