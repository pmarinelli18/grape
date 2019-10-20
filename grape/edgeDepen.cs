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
        findNoun finNoun;
        AnnotateTextResponse response;
        int rootIndex;

        Noun rootVerb;

        public edgeDepen(string info)
        {
            finNoun = new findNoun();
            response = finNoun.AnalyzeSyntaxFromText(info);
        }

        public void findRoot()
        {
            foreach (var item in response.Tokens)
            {
                if (item.DependencyEdge.Label == DependencyEdge.Types.Label.Root)
                {
                    rootVerb = new Noun(item.Text.Content.ToString());
                    rootIndex = item.DependencyEdge.HeadTokenIndex;
                    break;
                }
            }

            foreach (var item in response.Tokens)
            {
                if (item.DependencyEdge.HeadTokenIndex == rootIndex)
                {
                    rootVerb.nouns.Add(item.Text.Content.ToString());
                }
            }
        }
    }
}
