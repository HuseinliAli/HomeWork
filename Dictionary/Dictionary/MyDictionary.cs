using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<TMyKey , TMyValue>
    {
        TMyKey[] keys;
        TMyValue[] values;
        
        public MyDictionary()
        {
            keys = new TMyKey[0];
            values = new TMyValue[0];
        }

        public void Add(TMyKey key, TMyValue value)
        {
            TMyKey[] myKeys = keys;
            keys = new TMyKey[keys.Length+1];
            TMyValue[] myValues = values;
            values = new TMyValue[myValues.Length+1];

            for(int i =0; i< myKeys.Length; i++)
            {
                keys[i] = myKeys[i];
                values[i] = myValues[i];
            }
            keys[keys.Length-1] = key;
            values[values.Length-1] = value;
        }

        public void List()
        {
            for(int i =0; i<keys.Length; i++)
            {
                Console.WriteLine(keys[i]+" "+values[i]);
            }
        }
    }
}
