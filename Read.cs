using System;
using System.Collections.Generic;
using System.Text;

namespace Between
{
    class Read
    {
        public List<int> Between(int first, int second)
        {
            List<int> ts = new List<int>();
            while (first < second-1)
            {
                first++;
                ts.Add(first);
            }
            return ts;
        }
    }
}
