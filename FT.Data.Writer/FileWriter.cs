using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Data.Writer
{
    public class FileWriter : IDataWriter
    {
        private readonly ILogger log;

        public FileWriter(ILogger<FileWriter> _log)
        {
            log = _log;
        }
    }
}
