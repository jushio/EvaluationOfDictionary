using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluationOfDictionary
{
    class Class2 : Tmp
    {
        internal int Hash = 0;
        internal Class2()
        {
        }

        public override int GetHashCode()
        {
            return this.Hash;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
