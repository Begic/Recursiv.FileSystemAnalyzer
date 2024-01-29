using Recursiv.FileSystemAnalyzer.Data.Service;

namespace Recursiv.FileSystemAnalyzer;

internal class Program
{
    private static void Main(string[] args)
    {
        var folderPath = "C:\\Users\\begic.SOFTWARE\\source\\repos\\Recursiv.FileSystemAnalyzer\\TestFileSystem";

        Console.WriteLine("Start Crawling");
        
        var crawler = new FolderCrawler();
        var folderStrucutre = crawler.StartCrawling(folderPath);
        
        Console.WriteLine("Finish Crawling");

        var structurRepresenter = new StructurRepresenter();
        structurRepresenter.Display(folderStrucutre);
    }
}