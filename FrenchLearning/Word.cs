using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchLearning
{
    class Word
    {
        String francais;
        String english;

        public Word(String francais, String english)
        {
            this.francais = francais;
            this.english = english;
        }

        public String getFrancais()
        {
            return francais;
        }

        public String getEnglish()
        {
            return english;
        }
    }
}
