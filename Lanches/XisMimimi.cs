using PadraoFactory.DTO;
using PadraoFactory.Interface;

namespace PadraoFactory.Lanches
{
    public class EhXisCarneQueijo : Lanche, ILanches
    {
        private readonly string _nomeLanche;
        public EhXisCarneQueijo()
        {
            _nomeLanche = "Xis Carne/Queijo";
            Ingredientes.Add("Carne");
            Ingredientes.Add("Queijo");
        }
        public override string Nome { get => _nomeLanche; }

        public dynamic ConstroiLanche()
        {
            return new EhXisCarneQueijo();
        }

        public bool EsseSabor(SaborLancheDTO sabor)
        {
            return sabor.EhXisCarneQueijo;
        }
    }
}
