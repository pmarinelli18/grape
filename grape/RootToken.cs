using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace grape
{
    class RootToken
    {
        public string root;
        public List<String> nouns;

        public RootToken(string _root)
        {
            root = _root;
        }
    }
}
