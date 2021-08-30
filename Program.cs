using PadraoFactory.DTO;
using PadraoFactory.Fabrica;
using PadraoFactory.Interface;
using PadraoFactory.Lanches;
using System;
using System.Collections.Generic;

namespace PadraoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escolha o seu lanche: (1)Bauru | (2)Torrada | (3)Xis Frango | (4)Xis Carne Queijo");
                var opcao = int.Parse(Console.ReadLine());

                SaborLancheDTO saborEscolhido = new(opcao);

                var saboresDisponiveis = new List<ILanches> {
                    new Bauru(),
                    new Torrada(),
                    new XisFrango(),
                    new EhXisCarneQueijo(),
                };

                FabricaLanche fabricar = new(saborEscolhido);

                var lanche = fabricar.CriarLanche(saboresDisponiveis);

                Console.WriteLine($"Lanche escolhido: {lanche.Nome}");

                Console.WriteLine($"\nIngredientes:");

                foreach (var ingredientes in lanche.Ingredientes)
                {
                    Console.Write($"{ingredientes} | ");
                }

                Console.Write($"\n\nLanche pronto!!");

                Console.Write($"\n\n");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
    }
}
