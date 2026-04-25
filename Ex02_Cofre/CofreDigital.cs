namespace Ex02_Cofre
{
    public class CofreDigital
    {
        // Atributos privados
        private readonly string _dono;
        private string _senha;
        private bool _estaAberto;
        private int _tentativasErradas;

        // Construtor
        public CofreDigital(string dono, string senhaInicial)
        {
            _dono = dono;
            _senha = senhaInicial;
            _estaAberto = false;
            _tentativasErradas = 0;
        }

        // Método para abrir
        public string Abrir(string senhaInformada)
        {
            if (_tentativasErradas >= 3) 
                return "Cofre Bloqueado";

            if (senhaInformada == _senha)
            {
                _estaAberto = true;
                _tentativasErradas = 0;
                return "Cofre aberto com sucesso!";
            }
            
            _tentativasErradas++;
            return _tentativasErradas >= 3 ? "Cofre Bloqueado" : "Senha incorreta!";
        }

        // Método para fechar
        public void Fechar() => _estaAberto = false;

        // Sobrescrita para exibir dados
        public override string ToString()
        {
            string estado = _tentativasErradas >= 3 ? "BLOQUEADO" : (_estaAberto ? "Aberto" : "Fechado");
            return $"[Cofre Digital] Proprietário: {_dono} | Estado: {estado} | Erros: {_tentativasErradas}/3";
        }
    }
}