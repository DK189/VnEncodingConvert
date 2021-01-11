using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VnEncodingConvert
{
    partial class CharMap : IReadOnlyList<CharDatum>
    {
        public int Count => map.Count;

        public IEnumerator<CharDatum> GetEnumerator()
        {
            return map.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return map.GetEnumerator();
        }
    }
}
