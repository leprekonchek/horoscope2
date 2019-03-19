using System;

namespace _02_Lopukhina.Tools.Exceptions
{
    class OldToBeAlive : Exception
    {
        public OldToBeAlive(int age) : base($"Hmm, you are too old to be alive!\n The oldest man on the Erath was 122, and you are {age}. \n If you are alive, than congratulation and I'm pressing F")
        { }
    }

    class NotBorn : Exception
    {
        public NotBorn() : base("Hey, you haven't born yet!")
        { }
    }

    class NotValidEmail : Exception
    {
        public NotValidEmail(string email) : base($"You must have missed something in your email address {email}. \n Check it one more time!")
        { }
    }
}
