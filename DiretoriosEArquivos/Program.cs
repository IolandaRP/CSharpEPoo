class Program
{
    static void Main(string[] args)
    {
        #region Directory e DirectoryInfo
        //para gerenciar diretórios, pode ser utilizada tanto a classe estática Directory quanto instanciar a classe DirectoryInfo 

       /* var pasta = "pasta";
        var subpasta = "subpasta";
        var subpastaStatic = "subpastaStatic";

        var directoryInfoSubpasta = new DirectoryInfo(subpasta);

        if (!directoryInfoSubpasta.Exists || !Directory.Exists(subpasta))
        {
            directoryInfoSubpasta.Create();
            Directory.CreateDirectory(subpastaStatic);
            Directory.CreateDirectory(pasta);

            directoryInfoSubpasta.MoveTo($"{pasta}//{subpasta}");
            Directory.Move(subpastaStatic, @$"{pasta}\{subpastaStatic}");
        }

        var name = directoryInfoSubpasta.Name;
        var parent = directoryInfoSubpasta.Parent;
        var root = directoryInfoSubpasta.Root;
        var exists = directoryInfoSubpasta.Exists;

        foreach (var directory in Directory.GetDirectories(pasta))
        {
            Console.WriteLine(directory);
        }

        Directory.Delete($@"{pasta}\{subpastaStatic}");*/

        #endregion

        #region File e FileInfo
        var file = @"pasta\texto.txt";

        if (!File.Exists(file))
        {
            File.CreateText(file);
        }

        var fileInfo = new FileInfo(file);

        Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de atualização: {fileInfo.LastWriteTime}");
        #endregion

        Console.ReadKey();
    }
}
