using PadraoFactory.DTO;
using PadraoFactory.Interface;
using System.Collections.Generic;
using System.Linq;

namespace PadraoFactory.Fabrica
{
    public class FabricaLanche : FabricaDeLanchesMetodo
    {
        readonly SaborLancheDTO _sabor;
        public FabricaLanche(SaborLancheDTO sabor)
        {
            _sabor = sabor;
        }
     
        public override Lanche CriarLanche(List<ILanches> lancheDisponiveis)
        {
            var resultado = lancheDisponiveis.Where(x => x.EsseSabor(_sabor)).FirstOrDefault();

            return resultado.ConstroiLanche();            
        }
    }
}
