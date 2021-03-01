namespace FactoryPattern
{
    public interface IMessage
    {
        public string Text { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }

        void Send();
    }
}
