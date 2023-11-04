using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
namespace ArrayOps
{
    public class PriorityQueueHelper<TPriority, TValue> : IPriorityQueueHelper<TPriority, TValue>
    {
        public bool Clear(TValue[][] arr)
        {
            throw new NotImplementedException();
        }

        public TValue DeQueue(TValue[][] arr)
        {
            throw new NotImplementedException();
        }

        public bool DeQueue(KeyValuePair<TPriority, TValue> item, TValue[][] arr)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TPriority, TValue> item, TValue[][] arr)
        {
            throw new NotImplementedException();
        }
    }
}