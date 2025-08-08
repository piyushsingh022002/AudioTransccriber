using AudioTranscriber.Application.Models;

namespace AudioTranscriber.Application.Interfaces.Services
{
    public interface IAudioUploadService
    {
        Task<string> UploadAsync(AudioUploadRequest request);
    }
}
