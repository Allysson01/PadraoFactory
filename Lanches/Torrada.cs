using PadraoFactory.DTO;
using PadraoFactory.Interface;

namespace PadraoFactory.Lanches
{
    public class Torrada : Lanche, ILanches
    {
        private readonly string _nomeLanche;
        public Torrada()
        {
            _nomeLanche = "Torrada";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Presunto e Mussarela na chapa");
        }
        public override string Nome { get => _nomeLanche; }

        public dynamic ConstroiLanche()
        {
            return new Torrada();
        }

        public bool EsseSabor(SaborLancheDTO sabor)
        {
            return sabor.EhTorrada;
        }
    }
}
