using System;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";



        public int CompareTo(Loot other)
        {
            if (Kind != other.Kind)
                return Kind.ToString().CompareTo(other.Kind.ToString());

            else if (Value != other.Value)
                return -Value.CompareTo(other.Value);
            else if (Description != other.Description)
                return Description.CompareTo(other.Description);

            return 0;
        }
        public override int GetHashCode()
        {
            return Kind.GetHashCode() ^ Value.GetHashCode() ^ Description.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Loot otherLoot = obj as Loot;
            if (otherLoot == null)
            {
                return false;
            }
            else
            {
                return (otherLoot.Kind == this.Kind) &&
                (otherLoot.Value == this.Value) &&
                (otherLoot.Description == this.Description);
            }
        }
    }
}