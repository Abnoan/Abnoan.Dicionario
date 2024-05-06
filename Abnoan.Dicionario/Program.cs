using Abnoan.Dicionario.Exercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Criando e Inicializando

        Dictionary<int, string> idString = new Dictionary<int, string>();

        var produtos = new Dictionary<int, string>
            {
                {1, "Caneta"},
                {2, "Lápis"},
                {3, "Borracha"}
            };

        #endregion

        #region Adicionando Itens

        idString.Add(4, "João");

        idString[5] = "Maria";  // Adiciona uma nova chave
        idString[4] = "Carlos"; // Atualiza o valor da chave existente

        #endregion

        #region Acessando Valores

        // Retorna "Carlos" se a chave 4 estiver presente
        string nome = idString[4];

        if (idString.ContainsKey(4))
        {
            Console.WriteLine("A chave existe no dicionário.");
        }
        else
        {
            Console.WriteLine("A chave não foi encontrada.");
        }

        #endregion


        #region Removendo e Atualizando Elementos

        // Atualiza o valor para "Ana" se a chave 6 existir, se não, vai adicionar.
        idString[6] = "Ana";

        // Remove o par chave-valor onde a chave é 4
        idString.Remove(4);

        #endregion

        #region Vamos Praticar - LINQ    
        // Criando o dicionário livrosPorAutor
        Dictionary<string, List<string>> livrosPorAutor = Util.PreencherDicionario();

        //LINQ - Filtrar e Selecionar Autores por Critério Específico
        //var autoresComMaisDeDoisLivros = 

        // foreach (var autor in autoresComMaisDeDoisLivros) {
        // Console.WriteLine($"Autor: {autor.Nome}");
        // foreach (var livro in autor.Livros) {
        //     Console.WriteLine($" - {livro}");
        // }
        // Console.WriteLine();

        //LINQ - Ordenar Autores pelo Número de Livros

        //var autoresOrdenados = 

        // foreach (var autor in autoresOrdenados)
        // {
        //     Console.WriteLine($"Autor: {autor.Nome}, Quantidade de Livros: {autor.QuantidadeDeLivros}");
        // }

        //LINQ - Encontrar o Autor com o Maior Número de Livros
        //var autorComMaisLivros = 

        //Console.WriteLine($"Autor com mais livros: {autorComMaisLivros.Key} - {autorComMaisLivros.Value.Count} livros");
        #endregion

        #region Vamos Praticar Operações

        //Ver os livros por autor
        Console.Write("Digite o nome do autor para ver seus livros: ");
        string autorBuscado = Console.ReadLine();


        //Remover Autor
        Console.Write("Digite o nome do autor para remover: ");
        string autorParaRemover = Console.ReadLine();

        // Exibindo todos os autores
        Console.WriteLine("Autores:");

        // Exibindo todos os livros
        Console.WriteLine("Livros:");

        // Verificando se um autor existe
        Console.Write("Digite o nome de um autor para verificar se existe no dicionário: ");
        string autorVerificar = Console.ReadLine();

        //Adicionar Autor e Livro;
        Console.Write("Digite o nome do autor para adicionar um novo livro: ");
        string autor = Console.ReadLine();
        Console.Write("Digite o nome do novo livro: ");
        string novoLivro = Console.ReadLine();

        #endregion

        #region Exercicio


        Estoque estoque = new Estoque();
        estoque.AdicionarConsole("C001", "PlayStation 5", 30);
        estoque.AdicionarConsole("C002", "Xbox Series X", 20);
        estoque.AtualizarEstoque("C001", 3); // Vende 3 PS5
        estoque.ListarConsoles();
        estoque.RemoverConsole("C002"); // Remove o Xbox Series X

        #endregion
    }
}
