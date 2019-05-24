using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessores__e_Propriedades
{
    public class Aluno
    {
        private int _matricula;
        private string _nome;
        private double _mensalidade;
        private TipoAluno _tipo;

        public int Matricula
        {
            get { return this._matricula; }
            set { this._matricula = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                if (value < 0)
                    throw new MesalidadeNegativaException("Valor da mensalidade não pode ser negativo");
                else
                    _mensalidade = value;
            }
        }

        public TipoAluno Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }

    public enum TipoAluno
    {
        Regular,
        Especial
    }

    public class MesalidadeNegativaException : Exception
    {
        public MesalidadeNegativaException(string mensagem) : base(mensagem)
        { }
    }
}
