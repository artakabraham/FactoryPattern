using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var twitter = new TwitterMessenger("UserName", "Password");
            var twitterMsg = twitter.CreateMessage("Hello my friend", "Mustafa", "Ibrahim");
            twitterMsg.Send();

            var instagram = new InstagramMessenger("Username", "Password");
            if (instagram.Connected)
            {
                var instagramMsg = instagram.CreateMessage("photo.jfif", "InstagramUser" , "InstagramUser");
                instagramMsg.Send();
            }
            else
            {
                Console.WriteLine("Connection failed");
            }
        }
    }
}
