namespace WorldDefender.Models
{
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
