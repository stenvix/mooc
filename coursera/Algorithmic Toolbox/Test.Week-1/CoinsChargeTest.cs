using System;
using System.Linq;
using AutoFixture;
using AutoFixture.Xunit2;
using Week_1;
using Xunit;

namespace Test.Week_1
{
    public class CoinsChargeTest
    {
        [Theory, AutoData]
        public void Test1()
        {
            var fixture = new Fixture();
            var generator = fixture.Create<Generator<int>>();
            var random = new Random();
            var coins = generator.Where(i => CoinsCharge.CoinsDenominations.Contains(i)).Take(random.Next(1, 5));
            var charge = new CoinsCharge();
            var result = charge.GetCoins(77, CoinsCharge.CoinsDenominations); //TODO: Write simple test
        }
    }
}