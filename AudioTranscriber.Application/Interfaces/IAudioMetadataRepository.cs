using AudioTranscriber.Shared.Models;

namespace AudioTranscriber.Application.Interfaces;

public interface IAudioMetadataRepository
{
    Task InsertAsync(AudioFileMetadata metadata);
}
