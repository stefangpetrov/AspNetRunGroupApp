using CloudinaryDotNet.Actions;

namespace RunGroupWebAppCLone.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoResultAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
