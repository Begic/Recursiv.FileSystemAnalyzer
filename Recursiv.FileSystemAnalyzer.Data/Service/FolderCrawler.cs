namespace Recursiv.FileSystemAnalyzer.Data.Service;

public class FolderCrawler
{
    public void StartCrawling(string folderPath)
    {
        var startFolder = Directory.GetDirectories(folderPath);
        var startFiles = Directory.GetFiles(folderPath);
        




    }
}