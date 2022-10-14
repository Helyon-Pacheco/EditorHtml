using System;
using System.IO;

namespace EditorHtml{
    public static class SaveFile{

        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Salvando o arquivo");
            Console.WriteLine("----------------");
            Save(text);
        }
        public static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso.!");
            Console.ReadKey();
            Viewer.Show(text);
        }
    } 
}