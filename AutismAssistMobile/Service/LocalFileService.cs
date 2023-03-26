using System.IO;
using System.Threading.Tasks;

public class LocalFileService : IFileService
{
    public async Task<string> SaveAsync(string filename, byte[] data)
    {
        var folderPath = FileSystem.AppDataDirectory;
        var filePath = Path.Combine(folderPath, filename);
        
        await File.WriteAllBytesAsync(filePath, data);

        return filePath;
    }

    public async Task<byte[]> LoadAsync(string filename)
    {
        var folderPath = FileSystem.AppDataDirectory;
        var filePath = Path.Combine(folderPath, filename);

        return await File.ReadAllBytesAsync(filePath);
    }
}