using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Igreja.model.entitie
{
    class RegisterIgreja
    {
        private int? cod;
        private string congregacao;
        private string dirigente;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string telefone;
        private string tipo;

        public RegisterIgreja(int? cod, string congregacao, string dirigente, string rua, string numero, 
            string bairro, string cidade, string estado, string telefone, string tipo)
        {
            this.cod = cod;
            this.congregacao = congregacao;
            this.dirigente = dirigente;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.telefone = telefone;
            this.tipo = tipo;
        }

        public int? Cod { get => cod; set => cod = value; }
        public string Congregacao { get => congregacao; set => congregacao = value; }
        public string Dirigente { get => dirigente; set => dirigente = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
