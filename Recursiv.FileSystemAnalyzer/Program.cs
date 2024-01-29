using Recursiv.FileSystemAnalyzer.Data.Service;

namespace Recursiv.FileSystemAnalyzer;

internal class Program
{
    private static void Main(string[] args)
    {
        var folderPath = "C:\\Users\\begic.SOFTWARE\\source\\repos\\Recursiv.FileSystemAnalyzer\\TestFileSystem";

        var crawler = new FolderCrawler();
        Console.WriteLine("Start Crawling");
        var folderStrucutre = crawler.StartCrawling(folderPath);
        Console.WriteLine("Finish Crawling");
    }
}