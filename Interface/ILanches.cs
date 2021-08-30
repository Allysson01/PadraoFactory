using PadraoFactory.DTO;

namespace PadraoFactory.Interface
{
    public interface ILanches
    {
        bool EsseSabor(SaborLancheDTO sabor);

        dynamic ConstroiLanche();
    }
}
