using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Igreja.model.entitie
{
    class Register
    {
        private int cod;
        private String nome;
        private String sexo ;
        private string estadoCivil;
        private String email;
        private String cargo;
        private String rg;
        private String cpf;
        private String situacao;
        private int congregacao;

        public Register(string nome, string sexo, string estadoCivil, string email, string cargo, string rg, string cpf, string situacao, int congregacao)
        {
            
            this.nome = nome;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.email = email;
            this.cargo = cargo;
            this.rg = rg;
            this.cpf = cpf;
            this.situacao = situacao;
            this.congregacao = congregacao;
            
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int Congregacao { get => congregacao; set => congregacao = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
