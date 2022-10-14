using System;
using System.Text;

namespace EditorHtml{
    public static class Editor{
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("----------------");
            Start();
        }

        public static void Start(){
            var file = new StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("1 - Salvar");
            Console.WriteLine("0 - Não salvar");

            var option = short.Parse(Console.ReadLine());

            if (option == 1){
                SaveFile.Show(file.ToString());
            }
            else{
                Console.WriteLine("Arquivo não foi salvo.");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                Menu.Show();
            }
        }
    }
}