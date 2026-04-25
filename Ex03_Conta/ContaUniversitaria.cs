namespace Ex03_Conta
{
    public class ContaUniversitaria
    {
        // Atributos privados
        private readonly int _numeroConta;
        private string _titular;
        private double _saldo;
        private readonly double _limite;

        // Propriedades (Titular pode mudar, o resto é leitura)
        public string Titular { get => _titular; set => _titular = value; }
        public double Saldo => _saldo;

        // Campos Calculados
        public double SaldoTotal => _saldo + _limite;
        public string StatusConta => _saldo < 0 ? "Negativo" : "Positivo";

        // Construtor
        public ContaUniversitaria(int numero, string titular)
        {
            _numeroConta = numero;
            _titular = titular;
            _saldo = 0;
            _limite = 500;
        }

        // Métodos de Negócio
        public void Depositar(double valor)
        {
            if (valor > 0) _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= SaldoTotal)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Conta: {_numeroConta} | Titular: {_titular} | Saldo: {_saldo:C2} | Limite: {_limite:C2} | Total Disp: {SaldoTotal:C2}";
        }
    }
}