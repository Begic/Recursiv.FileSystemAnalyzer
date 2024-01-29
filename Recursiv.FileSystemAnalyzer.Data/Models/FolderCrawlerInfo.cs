namespace Recursiv.FileSystemAnalyzer.Data.Models;

public class FolderCrawlerInfo
{
    public int Id { get; set; }
    public string FolderName { get; set; }
    public List<FileCrawlerInfo>? Files { get; set; }
    public double FolderSize { get; set; }

    public FolderCrawlerInfo? ParentFolder { get; set; }
    public List<FolderCrawlerInfo>? ChildFolder { get; set; }
}