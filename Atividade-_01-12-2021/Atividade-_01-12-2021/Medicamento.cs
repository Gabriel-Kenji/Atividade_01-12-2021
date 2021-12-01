using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01_12_2021
{
    internal class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private List<Lote> lotes = new List<Lote>();

        public Medicamento()
        {
            this.id = 0;
            this.nome = " ";
            this.laboratorio = " ";
            this.lotes = new List<Lote>();
        }

        public Medicamento(int id, string nome, string laboratorio, List<Lote> lotes)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = lotes;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal List<Lote> Lotes { get => lotes; set => lotes = value; }

        public int qtdeDisponivel()
        {
            int total = 0;
            foreach(Lote lote in Lotes)
            {
                total += lote.Qtde;
            }

            return total;
        }

        public void comprar(Lote lote)
        {
            this.Lotes.Add(lote);
            this.Lotes.Sort((x, y) => DateTime.Compare(x.Venc, y.Venc));
        }

        public bool vender(int qtde)
        {
            bool res = false;
            if (qtde > 0 && qtde <= this.qtdeDisponivel())
            {
                    List<int> a = new List<int>();
                    int cont = 0;
                    foreach (Lote lote in Lotes)
                    {
                        if(qtde > 0)
                        {
                            if (lote.Qtde >= qtde)
                            {
                                lote.Qtde = lote.Qtde - qtde;
                                if (lote.Qtde == 0)
                                {
                                    a.Add(cont);
                                }
                            }
                            else if (lote.Qtde < qtde)
                            {
                                qtde = qtde - lote.Qtde;
                                    a.Add(cont);
                        }
                            cont++;
                        }  
                    }
                    foreach(int cont1 in a)
                    {
                        Lotes.RemoveAt(cont1);
                    }
                res = true;
            }
            return res;
            
            
        }

        public override string ToString()
        {
            return "id: "+ this.id + " - nome: " + this.nome + " - laboratorio: " + this.laboratorio + " - quantidade: " + qtdeDisponivel();
        }

        public override bool Equals(object? obj)
        { 
            return this.id.Equals(((Medicamento)obj).id);
        }
    }
    
}
