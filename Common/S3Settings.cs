namespace Appifylab.Common;

public class S3Settings
{
    public string BucketName { get; set; } = string.Empty;
    public string Region { get; set; } = "us-east-1";

    public string? AccessKey { get; set; }
    public string? SecretKey { get; set; }

    public string KeyPrefix { get; set; } = "uploads/";

    public string? PublicBaseUrl { get; set; }

    public string? ServiceUrl { get; set; }
}
