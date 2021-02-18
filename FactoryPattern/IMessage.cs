namespace FactoryPattern
{
    public interface IMessage
    {
        string Text { get; set; }
        string Target { get; set; }
        string Source { get; set; }

        void Send();
    }
}
