using System;
using FluentAssertions;
using HorseLibrary;
using NUnit.Framework;

namespace HorseLibraryTest
{
    [TestFixture]
    class LibraryTest
    {
        [Test]
        public void HorseHasTail()
        {
            var horseSound = new HorseSound();
            var myLittlePony = new Horse(true,horseSound);
            myLittlePony.Tail.Should().BeTrue();
        }
        [Test]
        public void HorseCanNeigh()
        {
            var horseSound = new HorseSound();
            var myLittlePony = new Horse(true,horseSound);
            myLittlePony.Speak().Should().Be("neeeeeeeiiiiiigggghhhhhhh");
        }
        [Test]
        public void RobotHorseCanBinary()
        {
            var horseSound = new RobotHorseSound();
            var myLittlePony = new Horse(true,horseSound);
            myLittlePony.Speak().Should().Be("100101010001010110101001");
        }
        
        
    }
}