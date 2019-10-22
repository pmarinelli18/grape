﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace grape
{
    class Noun
    {
        public string verb;
        public List<String> nouns;

        public Noun(string _verbs)
        {
            verb = _verbs;
        }
    }
}