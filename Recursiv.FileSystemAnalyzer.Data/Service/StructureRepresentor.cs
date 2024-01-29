using Recursiv.FileSystemAnalyzer.Data.Models;

namespace Recursiv.FileSystemAnalyzer.Data.Service;

public class StructurRepresenter
{
    public void Display(FolderCrawlerInfo folderStrucutre,string indent = "")
    {
        Console.WriteLine($"{indent}Folder: {folderStrucutre.FolderName}, Size: {Math.Ceiling(folderStrucutre.FolderSize)}KB");

        if (folderStrucutre.Files != null)
        {
            foreach (var file in folderStrucutre.Files)
            {
                Console.WriteLine($"{indent} - File: {file.FileName}, Size: {Math.Ceiling(file.FileSize)}KB");
            }
        }

        if (folderStrucutre.ChildFolder != null)
        {
            foreach (var childFolder in folderStrucutre.ChildFolder)
            {
                Display(childFolder, indent + "    ");
            }
        }
    }
}