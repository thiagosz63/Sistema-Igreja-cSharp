using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Igreja.model.entitie
{
    class Register
    {
        private int? cod;
        private String nome;
        private String sexo ;
        private String estadoCivil;
        private String email;
        private String cargo;
        private String rg;
        private String cpf;
        private String situacao;
        private DateTime nascimento;
        private int? congregacao;
        private int? v1;
        private string text1;
        private string v2;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private string text7;
        private string customFormat;
        private int? v3;

        public Register(int? cod, String nome, String sexo, String estadoCivil, String email, String cargo, String rg,
            String cpf, String situacao,DateTime nascimento, int? congregacao)
        {
            this.cod = cod;
            this.nome = nome;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.email = email;
            this.cargo = cargo;
            this.rg = rg;
            this.cpf = cpf;
            this.situacao = situacao;
            this.nascimento = nascimento;
            this.congregacao = congregacao;
        }

        public Register(int? v1, string text1, string v2, string text2, string text3, string text4, string text5, string text6, string text7, string customFormat, int? v3)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.v2 = v2;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.text7 = text7;
            this.customFormat = customFormat;
            this.v3 = v3;
        }

        public int? Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int? Congregacao { get => congregacao; set => congregacao = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
