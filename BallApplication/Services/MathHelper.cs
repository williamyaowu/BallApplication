using System;

namespace BallApplication.Services
{
    public class MathHelper
    {
        private static Random randomSeed;

        static MathHelper()
        {
            randomSeed = new Random(DateTime.Now.Millisecond);
        }

        //generate a random number
        public static int GetRandomNumber()
        {
            return randomSeed.Next(100);
        }
    }
}
