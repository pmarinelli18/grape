using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace grape
{
    class edgeDepen
    {
        public resultsAuth resultObj;
        public AnnotateTextResponse response;
        public int rootIndex;

        public RootToken root;

        public edgeDepen(string info)
        {
            resultObj = new resultsAuth();
            response = resultObj.AnalyzeSyntaxFromText(info);
        }

        public void findRoot()
        {
            foreach (var item in response.Tokens)
            {
                if (item.DependencyEdge.Label == DependencyEdge.Types.Label.Root)
                {
                    root = new RootToken(item.Text.Content.ToString());
                    rootIndex = item.DependencyEdge.HeadTokenIndex;
                    break;
                }
            }

            foreach (var item in response.Tokens)
            {
                if (item.DependencyEdge.HeadTokenIndex == rootIndex)
                {
                    root.nouns.Add(item.Text.Content.ToString());
                }
            }
        }
    }
}

