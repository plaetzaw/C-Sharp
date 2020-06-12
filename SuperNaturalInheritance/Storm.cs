// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
        { get; private set; }
        public bool IsStrong
        { get; private set; }
        public string Caster
        { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        public string Announce()
        {
            if (IsStrong)
            {
                return $"{Caster} cast a Strong {Essence} Storm";
            }
            else
            {
                return $"{Caster} cast a Weak {Essence} Storm";
            }
        }
    }
}
