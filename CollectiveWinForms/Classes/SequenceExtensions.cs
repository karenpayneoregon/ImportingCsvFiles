using System.Collections.Generic;

namespace CollectiveWinForms.Classes
{
    public static class SequenceExtensions
    {
        public static IEnumerable<int> Sequence(int pStart, int pStop)
        {
            return Sequence(pStart, pStop, pStart < pStop ? 1 : -1);
        }
        public static IEnumerable<int> Sequence(int pStart, int pStop, int pStep)
        {
            long current = pStart;

            while (pStep >= 0 ? pStop >= current : pStop <= current)
            {
                yield return (int)current;
                current += pStep;
            }
        }
    }
}