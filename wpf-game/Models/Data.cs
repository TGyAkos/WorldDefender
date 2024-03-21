namespace WorldDefender.Models
{
    // Generic osztaly a key-value pair-eknek
    // Hasznalata: Data<int, string> data = new Data<int, string>(1, "Egy");
    internal class Data<T, G> : Dictionary<T, G>
    {
        public T Key { get; set; }
        public G Value { get; set; }

        public Data(T key, G value)
        {
            Key = key;
            Value = value;
        }
    }
}
