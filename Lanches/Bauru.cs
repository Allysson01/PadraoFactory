using PadraoFactory.DTO;
using PadraoFactory.Interface;

namespace PadraoFactory.Lanches
{
    public class Bauru : Lanche, ILanches
    {
        private readonly string _nomeLanche;
        public Bauru()
        {
            _nomeLanche = "Bauru";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Presunto");
            Ingredientes.Add("Mussarela");
            Ingredientes.Add("Tomate e maionese");
        }
        public override string Nome { get => _nomeLanche; }

        public dynamic ConstroiLanche()
        {
            return new Bauru();
        }

        public bool EsseSabor(SaborLancheDTO sabor)
        {
            return sabor.EhBauru;
        }
    }
}
