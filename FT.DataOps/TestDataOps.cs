using Microsoft.Extensions.Logging;

namespace FT.DataOps;
public class TestDataOps : IDataOps
{
    private readonly ILogger log;
    public TestDataOps(ILogger<TestDataOps> _log)
    {
        log = _log;
    }
}

