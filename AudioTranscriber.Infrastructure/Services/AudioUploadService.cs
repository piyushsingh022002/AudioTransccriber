using AudioTranscriber.Application.Interfaces;
using AudioTranscriber.Application.Interfaces;
using AudioTranscriber.Application.Interfaces.Services;
using AudioTranscriber.Application.Models;
using AudioTranscriber.Shared.Models;

namespace AudioTranscriber.Infrastructure.Services;

public class AudioUploadService : IAudioUploadService
{
    private readonly string _uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
    private readonly IAudioMetadataRepository _repository;

    public AudioUploadService(IAudioMetadataRepository repository)
    {
        _repository = repository;
    }

    public async Task<string> UploadAsync(AudioUploadRequest request)
    {
        if (!Directory.Exists(_uploadDirectory))
            Directory.CreateDirectory(_uploadDirectory);

        var uniqueFileName = $"{Guid.NewGuid()}_{request.FileName}";
        var filePath = Path.Combine(_uploadDirectory, uniqueFileName);

        await File.WriteAllBytesAsync(filePath, request.FileContent);

        var metadata = new AudioFileMetadata
        {
            FileName = uniqueFileName,
            FilePath = filePath,
            ContentType = request.ContentType,
            UploadedAt = DateTime.UtcNow,
            MetaData = request.MetaData
        };

        await _repository.InsertAsync(metadata);

        return filePath;
    }
}
