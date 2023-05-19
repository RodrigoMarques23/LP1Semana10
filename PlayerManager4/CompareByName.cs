using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool _ascending;

        public CompareByName(bool ascending)
        { _ascending = ascending; }

        public int Compare(Player x, Player y)
        {
            return x.Name.CompareTo(y.Name) * (_ascending ? 1 : -1);
        }
        
    }
}
