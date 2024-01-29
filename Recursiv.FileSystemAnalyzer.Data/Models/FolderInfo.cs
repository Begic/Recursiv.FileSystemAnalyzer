namespace Recursiv.FileSystemAnalyzer.Data.Models;

public class FolderInfo
{
    public int Id { get; set; }
    public string FolderName { get; set; }
    public List<FileInfo>? Files { get; set; } = new();
    public byte[] FolderSize { get; set; }

    public FolderInfo? ParentFolder { get; set; } = new();
    public FolderInfo? ChildFolder { get; set; } = new();
}

public class FileInfo
{
    public int Id { get; set; }
    public string FileName { get; set; }
    public byte[] FileSize { get; set; }
}