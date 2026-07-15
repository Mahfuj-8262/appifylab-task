namespace Appifylab.Services;

public interface IImageStorageService
{
    Task<string> UploadAsync(Stream content, string contentType, string fileExtension, CancellationToken ct = default);

    Task DeleteAsync(string imageUrl, CancellationToken ct = default);
}
