namespace Ex01_Lampada
{
    public class Lampada
    {
        // Atributos privados
        private string _marca;
        private readonly string _tecnologia; 
        private bool _estaLigada;
        private int _brilho;

        // Construtor
        public Lampada(string marca, string tecnologia)
        {
            _marca = marca;
            _tecnologia = tecnologia;
            _estaLigada = false;
            _brilho = 100;
        }

        // Métodos
        public void Alternar() => _estaLigada = !_estaLigada;

        public void AjustarBrilho(int novoBrilho)
        {
            if (_estaLigada && novoBrilho >= 0 && novoBrilho <= 100)
            {
                _brilho = novoBrilho;
            }
        }

        public override string ToString()
        {
            string status = _estaLigada ? "Ligada" : "Desligada";
            return $"[Lâmpada] Marca: {_marca} | Tecnologia: {_tecnologia} | Status: {status} | Brilho: {_brilho}%";
        }
    }
}