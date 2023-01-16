using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Objects
{
    public class TeamResponse
    {
        public TeamResponse() 
        { 
        }
        public Team @Team { get; set; }
        public HttpResponseMessage Response { get; set; }
    }
}
