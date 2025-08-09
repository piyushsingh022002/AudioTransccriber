using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AudioTranscriber.Shared.Models;

public class AudioFileMetadata
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string FileName { get; set; } = default!;
    public string FilePath { get; set; } = default!;
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    public string? ContentType { get; set; } = default!;
public Dictionary<string, string>? MetaData { get; set; } // optional extra data

}
