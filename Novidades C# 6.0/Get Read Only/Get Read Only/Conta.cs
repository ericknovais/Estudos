namespace Get_Read_Only
{
    public class Conta
    {
        // Antes do C# 6.0
        /// public double Saldo { get; private set; } = 1000;
        // Agora do C# 6.0
        private double _saldo; // armazena 
        public double Saldo { get { return _saldo; } } // mapeamento
        public string Cliente { get; set; }
        public void Sacar(double valor)
        {
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        //public double GetSaldo()
        //{
        //    return Saldo;
        //}
    }
}
