using System;
using System.IO;
class File
{
    public static void Main()
    {
        string path_base = @"W:\Work\VC\Games";

        string path_src = @"W:\Work\VC\Games\src";
        string path_main = @"W:\Work\VC\Games\src\main";
        string path_Main = @"W:\Work\VC\Games\src\main\Main";
        string path_Utils = @"W:\Work\VC\Games\src\main\Utils";
        string path_test = @"W:\Work\VC\Games\src\test";
        string path_res = @"W:\Work\VC\Games\res";
        string path_dravables = @"W:\Work\VC\Games\res\dravables";
        string path_vectors = @"W:\Work\VC\Games\res\vectors";
        string path_icons = @"W:\Work\VC\Games\res\icons";
        string path_savegames = @"W:\Work\VC\Games\savegames";
        string path_temp = @"W:\Work\VC\Games\temp";

        string filePath = @"W:\Work\VC\Games\temp\Temp.txt";



        Console.WriteLine("Установщик игр (лицензия 100%)");
        Console.WriteLine("Выберите действие :");
        Console.WriteLine(" 1 - Установить игру");
        Console.WriteLine(" 2 - Удалить игру");
        try
        {
            if (Directory.Exists(path_base))
            {
                Console.WriteLine("Игра установлена по адресу W:\\Work\\VC\\Games");
            }
            string choice = Console.ReadLine();
            DirectoryInfo directory_base = Directory.CreateDirectory(path_base);

            DirectoryInfo directory_src = Directory.CreateDirectory(path_src);
            DirectoryInfo directory_main = Directory.CreateDirectory(path_main);
            DirectoryInfo directory_Main = Directory.CreateDirectory(path_Main);
            DirectoryInfo directory_Utils = Directory.CreateDirectory(path_Utils);
            DirectoryInfo directory_test = Directory.CreateDirectory(path_test);
            DirectoryInfo directory_res = Directory.CreateDirectory(path_res);
            DirectoryInfo directory_dravables = Directory.CreateDirectory(path_dravables);
            DirectoryInfo directory_vectors = Directory.CreateDirectory(path_vectors);
            DirectoryInfo directory_icons = Directory.CreateDirectory(path_icons);
            DirectoryInfo directory_savegames = Directory.CreateDirectory(path_savegames);
            DirectoryInfo directory_temp = Directory.CreateDirectory(path_temp);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Директория установлена по адресу: {path_base}");
                writer.WriteLine($"{path_src}\n    {path_main}\n       {path_Main}\n       {path_Utils}");
                writer.WriteLine($"{path_test}");
                writer.WriteLine($"{path_res}\n    {path_dravables}\n    {path_vectors}\n    {path_icons}");
                writer.WriteLine($"{path_savegames}");
                writer.WriteLine($"{path_temp}");
                writer.WriteLine($"\nСейчас вы читаете файл Temp.txt, расположенный по адресу {filePath}");
            }

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Директория успешно создана {0}.", Directory.GetCreationTime(path_base));
                    }
                    break;

                case "2":
                    {
                        directory_base.Delete(true);

                        Console.WriteLine("Директория успешно удалена.");

                        break;
                    }

            }
        }

        catch (Exception error)
        {
            Console.WriteLine("Ошибка: {0}", error.ToString());
        }
        finally { }
    }
}