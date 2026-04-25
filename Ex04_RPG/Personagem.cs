namespace Ex04_RPG
{
    public class Personagem
    {
        private string _nome;
        private string _classe;
        private int _vida;
        private int _experiencia;

        public Personagem(string nome, string classe)
        {
            _nome = nome;
            _classe = classe;
            _vida = 100;
            _experiencia = 0;
        }

        public void ReceberDano(int dano)
        {
            _vida -= dano;
            if (_vida < 0) _vida = 0;
        }

        public void Curar(int cura)
        {
            if (_vida > 0)
            {
                _vida += cura;
                if (_vida > 100) _vida = 100;
            }
        }

        public void GanharXP(int xp) => _experiencia += xp;

        public override string ToString()
        {
            string status = _vida > 0 ? "Vivo" : "Derrotado";
            return $"[Heroi] {_nome} ({_classe}) | Vida: {_vida}/100 | XP: {_experiencia} | Status: {status}";
        }
    }
}