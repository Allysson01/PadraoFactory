using System.Collections;

namespace PadraoFactory
{
    public abstract class Lanche
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new();
    }
}
