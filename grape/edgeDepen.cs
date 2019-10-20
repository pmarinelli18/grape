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
        List<custSent> sentenceList;

        public edgeDepen(string info)
        {
            resultObj = new resultsAuth();
            response = resultObj.AnalyzeSyntaxFromText(info);
        }
        
        public List<custSent> makeCustSents()
        {
            sentenceList = new List<custSent>();
            foreach (var sentence in response.Sentences)
            {
                custSent sent = new custSent(sentence.Text.Content.ToString());
                sentenceList.Add(sent);
            }
            return sentenceList;
        }
    }
}

