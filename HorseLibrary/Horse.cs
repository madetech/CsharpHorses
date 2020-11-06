using System;

namespace HorseLibrary
{
    public interface IHorseSound
    {
        public string Speak();
    }

    public class HorseSound : IHorseSound
    {
        public string Speak()
        {
            return "neeeeeeeiiiiiigggghhhhhhh";
        }
    }

    public class RobotHorseSound : IHorseSound
    {
        public string Speak()
        {
            return "100101010001010110101001";
        }
    }

    public class Horse 
    {
        public bool Tail { get; set; }
        public IHorseSound Sound { get; set; }
        
        public Horse(bool tail, IHorseSound sound)
        {
            this.Tail = tail;
            Sound = sound;
        }
        

        

        public string Speak()
        {
            return Sound.Speak();
        }
        
    }
}