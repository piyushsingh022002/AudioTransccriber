namespace AudioTranscriber.Application.Models;

public class AudioUploadRequest
{
    public string FileName { get; set; } = default!;
    public byte[] FileContent { get; set; } = default!;
    public string ContentType { get; set; } = default!;
    public Dictionary<string, string>? MetaData { get; set; }
}
