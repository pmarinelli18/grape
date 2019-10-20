using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grape
{
    class results
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public List<articles> articles { get; set; }
    }

    public class articles
    {
        public string title     { get; set; }
        public string content   { get; set; }
    }
}
