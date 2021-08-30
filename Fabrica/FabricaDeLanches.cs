using PadraoFactory.Interface;
using System.Collections.Generic;

namespace PadraoFactory.Fabrica
{
    public abstract class FabricaDeLanchesMetodo
    {
        public abstract Lanche CriarLanche(List<ILanches> lancheEscolhido);
    }
}
