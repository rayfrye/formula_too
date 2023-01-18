using Microsoft.Extensions.Logging;

namespace FT.Data;
public class TestData : IData
{
    private readonly ILogger log;
    public TestData(ILogger<TestData> _log)
    {
        log = _log;
    }
}

