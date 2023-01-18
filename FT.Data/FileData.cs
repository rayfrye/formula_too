using Microsoft.Extensions.Logging;

namespace FT.Data;
public class FileData : IData
{
    private readonly ILogger log;
    public FileData(ILogger<FileData> _log)
    {
        log = _log;
    }
}

