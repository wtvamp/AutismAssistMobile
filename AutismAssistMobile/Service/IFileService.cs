public interface IFileService
{
    Task<string> SaveAsync(string filename, byte[] data);
    Task<byte[]> LoadAsync(string filename);
}