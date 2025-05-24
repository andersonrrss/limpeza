using System;
using System.Runtime.ExceptionServices;

namespace CleanUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum padrão fornecido para a remoção");
                Console.WriteLine("Uso: CleanUp.exe <diretório a ser limpado> <padrão de arquivo(ex: *.exe) ou diretório>");
                return;
            }

            string RootDirectory = args[0];

            RemoveItems(RootDirectory, args.Skip(1).ToArray());
            
            Console.WriteLine("Operação concluída com sucesso!");

        }

        static void RemoveItems(string RootDirectory, string[] itemsToRemove)
        {
            foreach (string itemToRemove in itemsToRemove)
            {
                if (itemToRemove.Contains("*."))
                {
                    RemoveFiles(RootDirectory, itemToRemove);
                }
                else
                {
                    RemoveDirectories(RootDirectory, itemToRemove);
                }
            }
        }

        static void RemoveFiles(string Root, string searchPattern)
        {
            string[] files = Directory.GetFiles(Root, searchPattern, SearchOption.AllDirectories);
            if(files.Length == 0)
            {
                Console.WriteLine($"Nenhum arquivo {searchPattern} foi encontrado");
                return;
            }

            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                    Console.WriteLine($"-{file}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"!!{file}: {ex.Message} ");
                }
            }
        }

        static void RemoveDirectories(string root, string dirName)
        {
            string[] directories = Directory.GetDirectories(root, dirName, SearchOption.AllDirectories);

            if(directories.Length == 0)
            {
                Console.WriteLine($"Nenhum diretório com o nome {dirName} foi encontrado");
                return;
            }

            foreach (string directory in directories) 
            {
                try
                {
                    Directory.Delete(directory, true);
                    Console.WriteLine($"-{directory}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"!!{directory}: {ex.Message}");
                }
            }
        }
    }
}
