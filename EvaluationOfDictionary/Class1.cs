using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluationOfDictionary
{
    internal class Class1 : Tmp
    {
        private static int HashSeed = 0;
        internal int Hash = 0;
        internal Class1()
        {
            this.Hash = HashSeed++;
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
