using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IDeveloper
    {
        void WriteCode(string code);
        void Commit();
        void Push();
        void Merge(string commitToMerge);
    }
}
