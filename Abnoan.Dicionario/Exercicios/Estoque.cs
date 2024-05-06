using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Dicionario.Exercicios
{
    class Estoque
    {
        private Dictionary<string, ConsoleGame> consoles;

        public Estoque()
        {
            consoles = new Dictionary<string, ConsoleGame>();
        }

        public void AdicionarConsole(string codigo, string nome, int quantidade)
        {
            consoles[codigo] = new ConsoleGame(nome, quantidade);
            Console.WriteLine($"Console adicionado: {nome}, Quantidade: {quantidade}");
        }

        public void AtualizarEstoque(string codigo, int quantidadeVendida)
        {
            if (consoles.ContainsKey(codigo))
            {
                consoles[codigo].Quantidade -= quantidadeVendida;
                Console.WriteLine($"Estoque atualizado. {consoles[codigo].Nome} restantes: {consoles[codigo].Quantidade}");
            }
            else
            {
                Console.WriteLine("Console não encontrado!");
            }
        }

        public void RemoverConsole(string codigo)
        {
            if (consoles.ContainsKey(codigo))
            {
                Console.WriteLine($"Console removido: {consoles[codigo].Nome}");
                consoles.Remove(codigo);
            }
            else
            {
                Console.WriteLine("Console não encontrado!");
            }
        }

        public void ListarConsoles()
        {
            Console.WriteLine("Lista de Consoles em Estoque:");
            foreach (var item in consoles)
            {
                Console.WriteLine($"Código: {item.Key}, Console: {item.Value.Nome}, Quantidade: {item.Value.Quantidade}");
            }
        }
    }
}