using Recursiv.FileSystemAnalyzer.Data.Models;

namespace Recursiv.FileSystemAnalyzer.Data.Service;

public class FolderCrawler
{
    public FolderCrawlerInfo StartCrawling(string startfolderPath, FolderCrawlerInfo? parentFolderInfo = null)
    {
        var folderData = new FolderCrawlerInfo
        {
            FolderName = Path.GetFileName(startfolderPath),
            Files = new List<FileCrawlerInfo>(),
            ChildFolder = new List<FolderCrawlerInfo>()
        };

        if (parentFolderInfo != null)
        {
            folderData.ParentFolder = parentFolderInfo;
        }

        var folders = Directory.GetDirectories(startfolderPath);
        var files = Directory.GetFiles(startfolderPath);

        foreach (var folderPath in folders)
        {
            folderData.ChildFolder.Add(StartCrawling(folderPath, folderData));
        }

        foreach (var filePath in files)
        {
            var fileInfo = new FileInfo(filePath);

            folderData.Files.Add(new FileCrawlerInfo
            {
                FileName = fileInfo.Name,
                FileSize = fileInfo.Length / 1024
            });
        }

        folderData.FolderSize = folderData.Files.Sum(x => x.FileSize);

        return folderData;
    }
}