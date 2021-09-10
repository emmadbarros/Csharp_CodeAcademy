using System;
namespace AbstractClassDemonstration
{
    //The child class must implement every abstract member
    public class SamsungGalaxy : Device
    {
        //FIELD(s)



        //PROPERTIES(s)
        public override int BatteryPercentage
        {
            //specific code for getter and setter here
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }


        //METHOD(s)
        public override void PlayVideo()
        {
            //define functionality of video play
            throw new NotImplementedException();
        }


        //CONSTRUCTOR(s)
        public SamsungGalaxy()
        {
        }
    }
}
