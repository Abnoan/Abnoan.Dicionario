using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Dicionario.Exercicios
{
    public static class Util
    {
        public static Dictionary<string, List<string>> PreencherDicionario()
        {
            return new Dictionary<string, List<string>> {
                {"Machado de Assis", new List<string> {"Dom Casmurro", "Memórias Póstumas de Brás Cubas"}},
                {"Clarice Lispector", new List<string> {"A Hora da Estrela", "Perto do Coração Selvagem", "A Paixão Segundo G.H."}},
                {"Jorge Amado", new List<string> {"Gabriela, Cravo e Canela"}},
                {"Carlos Drummond", new List<string> {"A Pedra no Caminho", "Falta de Ar", "Tempo Vida Poesia", "Cidadezinha Qualquer"}},
                {"Cecília Meireles", new List<string> {"Romanceiro da Inconfidência", "Mar Absoluto", "Viagem"}},
                {"Manuel Bandeira", new List<string> {"Libertinagem", "Estrela da Manhã"}},
                {"Rachel de Queiroz", new List<string> {"O Quinze", "Memorial de Maria Moura"}},
                {"João Guimarães Rosa", new List<string> {"Grande Sertão: Veredas", "Sagarana"}},
                {"Lima Barreto", new List<string> {"Triste Fim de Policarpo Quaresma", "Recordações do Escrivão Isaías Caminha"}},
                {"Lygia Fagundes Telles", new List<string> {"Ciranda de Pedra", "As Meninas"}},
                {"José de Alencar", new List<string> {"Iracema", "O Guarani", "Senhora"}},
                {"Aluísio Azevedo", new List<string> {"O Cortiço", "Casa de Pensão"}},
                {"Rui Barbosa", new List<string> {"Cartas de Inglaterra", "Oração aos Moços"}}
            };

        }
    }
}