using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace VnEncodingConvert
{
    public partial class CharMap
    {
        List<CharDatum> map = new List<CharDatum>();

        internal CharMap(char[] raw_char_map)
            :this(raw_char_map.Select(c => $"{c}"))
        {
            
        }

        internal CharMap(string[] raw_char_map)
            :this(raw_char_map.AsEnumerable())
        {
            
        }

        internal CharMap(IEnumerable<string> raw_char_map)
        {
            map.AddRange(
                raw_char_map.Select((c, i) => new CharDatum(i, $"{c}"))
            );
        }

        public CharDatum this[int index]
        {
            get
            {
                return map.Where(c => c.Index == index).FirstOrDefault();
            }
        }

        public CharDatum this[string value]
        {
            get
            {
                return map.Where(c => c.Value == value).FirstOrDefault();
            }
        }
    }
}