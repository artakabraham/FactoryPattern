using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Messenger messenger = new Messenger("Usernmame", "Password");
            //messenger.SendMessage("Lorem Impus", "From", "To");

            var twitter = new TwitterMessenger("UserName", "Password");
            var twitterMsg = twitter.CreateMessage("Mustafa","Ibrahim","Hello my friend");
            twitterMsg.Send();


            //var instagram = new InstagramMessenger("Username","Password");         
            //var instagramMsg = new InstagramMessage("InstagramUser", "InstagramUser", "Please, like this page!");
            //instagramMsg.Send();


            //var instagram = new InstagramMessenger("Username","Password");         
            //var twitter = new TwitterMessage("InstagramUser", "InstagramUser", "Please, like this page!");
            //twitter.Send();

        }
    }
}
