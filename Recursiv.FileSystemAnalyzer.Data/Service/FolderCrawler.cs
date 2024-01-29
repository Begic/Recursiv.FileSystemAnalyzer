using Recursiv.FileSystemAnalyzer.Data.Models;

namespace Recursiv.FileSystemAnalyzer.Data.Service;

public class FolderCrawler
{
    public FolderCrawlerInfo StartCrawling(string startfolderPath, FolderCrawlerInfo? parentFolderInfo = null)
    {
        var folderData = new FolderCrawlerInfo
        {
            FolderName = Path.GetFileName(startfolderPath)
        };

        if (parentFolderInfo != null) folderData.ParentFolder = parentFolderInfo;

        var newFolders = Directory.GetDirectories(startfolderPath);
        var newFiles = Directory.GetFiles(startfolderPath);

        if (newFolders.Any()) folderData.ChildFolder = new List<FolderCrawlerInfo>();

        if (newFiles.Any()) folderData.Files = new List<FileCrawlerInfo>();

        foreach (var folderPath in newFolders) folderData?.ChildFolder?.Add(StartCrawling(folderPath, folderData));

        foreach (var filePath in newFiles)
        {
            var fileInfo = new FileInfo(filePath);

            folderData?.Files?.Add(new FileCrawlerInfo
            {
                FileName = fileInfo.Name,
                FileSize = fileInfo.Length / 1024
            });
        }

        if (folderData?.Files != null) folderData.FolderSize = folderData.Files.Sum(x => x.FileSize);

        return folderData;
    }
}