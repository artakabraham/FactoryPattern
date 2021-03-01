namespace FactoryPattern
{
    interface IMessenger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        public IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }
}
