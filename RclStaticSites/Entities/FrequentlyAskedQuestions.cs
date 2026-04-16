using System;
using System.Collections.Generic;
using System.Text;

namespace RclStaticSites.Entities
{
    public  class FrequentlyAskedQuestions
    {
        public string Question { get; set; }
        public IEnumerable<string> Answers { get; set; }
    }
}