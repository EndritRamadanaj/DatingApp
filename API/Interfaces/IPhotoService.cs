using CloudinaryDotNet.Actions;

namespace API.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoASync(IFormFile file);
        Task<DeletionResult> DeletePhotoASync(string publicId);
    }
}