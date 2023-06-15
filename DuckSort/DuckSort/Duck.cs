namespace TemplatePattern.DuckSort
{
    internal class Duck : IComparable<Duck>
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Duck(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string ToString()
        {
            return Name + " weighs: " + Weight;
        }

        public int CompareTo(Duck? other)
        {
            if (Weight < other.Weight)
            {
                return -1;
            }

            return Weight == other.Weight ? 0 : 1;
        }
    }
}
