using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Dicionario.Exercicios
{
    public class ConsoleGame
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public ConsoleGame(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }
}