namespace InventoryMangementSystem.Intefaces
{
    public interface IUploudFile
    {
        Task<string> UploadFileAsync(string filePath, IFormFile file);
    }
}
