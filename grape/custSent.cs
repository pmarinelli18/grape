using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace grape
{
    class custSent
    {
        public resultsAuth sentAuth;
        public AnnotateTextResponse sentResponse;
        
        public RootToken sentRoot;
        public int rootIndex;

        public custSent(string _sentence)
        {
            sentAuth = new resultsAuth();
            sentResponse = sentAuth.AnalyzeSyntaxFromText(_sentence);
        }

        public void findRoot()
        {
            foreach (var item in sentResponse.Tokens)
            {
                if (item.DependencyEdge.Label == DependencyEdge.Types.Label.Root)
                {
                    sentRoot = new RootToken(item.Text.Content.ToString());
                    rootIndex = item.DependencyEdge.HeadTokenIndex;
                    break;
                }
            }

            foreach (var item in sentResponse.Tokens)
            {
                if (item.DependencyEdge.HeadTokenIndex == rootIndex)
                {
                    sentRoot.nouns.Add(item.Text.Content.ToString());
                }
            }
        }
    }
}
