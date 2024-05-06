using Abnoan.Dicionario.Exercicios;

public static class Pratica
{
    private static void Main2(string[] args)
    {
        #region Vamos Praticar - LINQ    
        // Criando o dicionário livrosPorAutor
        Dictionary<string, List<string>> livrosPorAutor = Util.PreencherDicionario();

        //LINQ - Filtrar e Selecionar Autores por Critério Específico
        var autoresComMaisDeDoisLivros = livrosPorAutor
           .Where(autor => autor.Value.Count > 2)
           .Select(autor => new
           {
               Nome = autor.Key,
               Livros = autor.Value
           });

        foreach (var autor in autoresComMaisDeDoisLivros)
        {
            Console.WriteLine($"Autor: {autor.Nome}");
            foreach (var livro in autor.Livros)
            {
                Console.WriteLine($" - {livro}");
            }
            Console.WriteLine();
        }

        //LINQ - Ordenar Autores pelo Número de Livros
        var autoresOrdenados = livrosPorAutor
          .OrderByDescending(autor => autor.Value.Count)
          .Select(autor => new
          {
              Nome = autor.Key,
              QuantidadeDeLivros = autor.Value.Count
          });

        foreach (var autor in autoresOrdenados)
        {
            Console.WriteLine($"Autor: {autor.Nome}, Quantidade de Livros: {autor.QuantidadeDeLivros}");
        }

        //LINQ - Encontrar o Autor com o Maior Número de Livros
        var autorComMaisLivros = livrosPorAutor
            .OrderByDescending(autor => autor.Value.Count)
            .FirstOrDefault();

        //Console.WriteLine($"Autor com mais livros: {autorComMaisLivros.Key} - {autorComMaisLivros.Value.Count} livros");
        #endregion

        #region Vamos Praticar Operações

        //Ver os livros por autor
        Console.Write("Digite o nome do autor para ver seus livros: ");
        string autorBuscado = Console.ReadLine();

        if (livrosPorAutor.ContainsKey(autorBuscado))
        {
            Console.WriteLine($"Livros de {autorBuscado}:");
            foreach (var livro in livrosPorAutor[autorBuscado])
            {
                Console.WriteLine($" - {livro}");
            }
        }
        else
        {
            Console.WriteLine("Autor não encontrado!");
        }

        //Remover Autor
        Console.Write("Digite o nome do autor para remover: ");
        string autorParaRemover = Console.ReadLine();

        if (livrosPorAutor.ContainsKey(autorParaRemover))
        {
            livrosPorAutor.Remove(autorParaRemover);
            Console.WriteLine($"{autorParaRemover} e seus livros foram removidos com sucesso!");
        }
        else
        {
            Console.WriteLine("Autor não encontrado!");
        }

        // Exibindo todos os autores
        Console.WriteLine("Autores:");
        foreach (var autor in livrosPorAutor.Keys)
        {
            Console.WriteLine($" - {autor}");
        }

        // Exibindo todos os livros
        Console.WriteLine("\nLivros:");
        foreach (var listaLivros in livrosPorAutor.Values)
        {
            foreach (var livro in listaLivros)
            {
                Console.WriteLine($" - {livro}");
            }
        }

        // Verificando se um autor existe
        Console.Write("\nDigite o nome de um autor para verificar se existe no dicionário: ");
        string autorVerificar = Console.ReadLine();

        if (livrosPorAutor.ContainsKey(autorVerificar))
        {
            Console.WriteLine("Este autor existe no dicionário.");
        }
        else
        {
            Console.WriteLine("Este autor não existe no dicionário.");
        }


        //Adicionar Autor e Livro;
        Console.Write("Digite o nome do autor para adicionar um novo livro: ");
        string nomeAutor = Console.ReadLine();
        Console.Write("Digite o nome do novo livro: ");
        string novoLivro = Console.ReadLine();

        if (livrosPorAutor.ContainsKey(nomeAutor))
        {
            livrosPorAutor[nomeAutor].Add(novoLivro);
            Console.WriteLine($"Livro '{novoLivro}' adicionado com sucesso a lista de {nomeAutor}.");
        }
        else
        {
            livrosPorAutor.Add(nomeAutor, new List<string> { novoLivro });
            Console.WriteLine($"Autor '{nomeAutor}' adicionado com sucesso com o livro '{novoLivro}'.");
        }
        #endregion
    }
}
