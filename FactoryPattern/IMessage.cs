namespace FactoryPattern
{
    public interface IMessage
    {
        public string Text { get; set; }
        public string Target { get; set; }
        public string Source { get; set; }

        void Send();
    }
}
