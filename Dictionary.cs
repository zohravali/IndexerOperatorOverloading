using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class Dictionary
    {
        public  string[,] DictionaryArray { get; set; }

        public string  this[int i, int j]
        {
            get => DictionaryArray[i, j];
            set => DictionaryArray[i,j] =  value; 
        }

    }
}
