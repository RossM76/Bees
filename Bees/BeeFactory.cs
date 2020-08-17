using System;
using System.Collections.Generic;

namespace Bees
{
    public static class BeeFactory
    {
        public static Bee CreateBee(BeeType beeType)
        {
            switch (beeType)
            {
                case BeeType.Drone:
                    return new Drone();
                case BeeType.Queen:
                    return new Queen();
                case BeeType.Worker:
                    return new Worker();
                default:
                    throw new Exception("Invalid bee type specified");
            }            
        }

        public static IEnumerable<Bee> CreateBees(BeeType beeType, int number)
        {
            for (int i = 0; i < number; i++)
            {
                yield return CreateBee(beeType);
            }
        }
    }
}
