using System;
using System.IO;

namespace ConsoleExploarPastasArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CopiarArquivos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }


        static public void CopiarArquivos()
        {
            string destino = @"C:\Users\Paulo\Desktop\TesteCopiaArquivos\";
            string[] files = Directory.GetFiles(@"E:\Digitalizados", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {

                var modulos = file.Split('\\');
                int tamanho = modulos.Length;
                string arquivo = modulos[tamanho - 1];
                string caminho = "";
                for (int i = 0; i < modulos.Length - 1; i++)
                {
                    caminho += modulos[i] + "\\";
                }
                //Console.WriteLine(caminho);
                //Console.WriteLine(arquivo);
                //Console.ReadKey();

                string sourceFile = System.IO.Path.Combine(caminho, arquivo);
                string destFile = System.IO.Path.Combine(destino, arquivo);
                System.IO.File.Copy(sourceFile, destFile, true);
            }

        }
    }
}
