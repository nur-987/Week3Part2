using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckerEvent
{
    class StringHelper
    {
        public event stringCounting counterEvent;

        public void Count(string str)
        {

            string[] words = str.Split(' ');
            int wordCount = words.Length;

            if (counterEvent != null)
            {
                counterEvent.Invoke(wordCount);
            }

        }

    }
    
}
