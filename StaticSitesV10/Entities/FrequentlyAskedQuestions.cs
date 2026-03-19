using System;
using System.Collections.Generic;
using System.Text;

namespace StaticSitesV10.Entities
{
    public  class FrequentlyAskedQuestions
    {
        public string Question { get; set; }
        public IEnumerable<string> Answers { get; set; }
    }
}