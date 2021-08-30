namespace PadraoFactory.DTO
{
    public class SaborLancheDTO
    {
        public SaborLancheDTO(int escolha)
        {
            Escolha = escolha;
        }

        public int Escolha { get; set; }
        public bool EhBauru { get => Escolha == 1; }
        public bool EhTorrada { get => Escolha == 2; }
        public bool EhXisFrango { get => Escolha == 3; }
        public bool EhXisCarneQueijo { get => Escolha == 4; }
    }
}
