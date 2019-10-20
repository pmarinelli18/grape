using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace grape
{
    class resultsAuth
    {
        public AnnotateTextResponse AnalyzeSyntaxFromText(string info)
        {

            var client = new LanguageServiceClientBuilder();
            client.CredentialsPath = ("creds.json");


            var langClient = client.Build();

            var response = langClient.AnnotateText(new Document()
            {
                Content = info,
                Type = Document.Types.Type.PlainText
            },
            new Features() { ExtractSyntax = true });
            return response;
        }
    }
}
