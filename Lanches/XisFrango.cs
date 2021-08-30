using PadraoFactory.DTO;
using PadraoFactory.Interface;

namespace PadraoFactory.Lanches
{
    public class XisFrango : Lanche, ILanches
    {
        private readonly string _nomeLanche;
        public XisFrango()
        {
            _nomeLanche = "Xis de Frango";
            Ingredientes.Add("Peito de frango");
            Ingredientes.Add("Maionese e tomate");
        }
        public override string Nome { get => _nomeLanche; }

        public dynamic ConstroiLanche()
        {
            return new XisFrango();
        }

        public bool EsseSabor(SaborLancheDTO sabor)
        {
            return sabor.EhXisFrango;
        }
    }
}
