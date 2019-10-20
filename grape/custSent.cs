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

        public bool containsRoot = false;

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
                    containsRoot = true;
                    break;
                }
            }

            bool properNoun = true;

            foreach (var item in sentResponse.Tokens)
            {
                if (item.DependencyEdge.HeadTokenIndex == rootIndex &&
                     !item.Text.Content.Equals(",") &&
                     !item.Text.Content.Equals(".") &&
                     !item.Text.Content.Equals("!") &&
                     !item.Text.Content.Equals("?") ||
                     (item.PartOfSpeech.Proper == PartOfSpeech.Types.Proper.Proper) &&
                      properNoun == true)  
                {
                    if (item.PartOfSpeech.Proper == PartOfSpeech.Types.Proper.Proper)
                    {
                        properNoun = false;
                    }
                    sentRoot.nouns.Add(item.Text.Content.ToString());
                }
            }
        }
    }
}
