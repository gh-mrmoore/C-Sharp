using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    class Studio_CD : Studio_BaseDisc, IOpticalDisc
    {
        // TODO: Determine whcih fields, methods and constructors can be extended from the base class and which ones can't
        public List<string> TrackNames { get; set; }

        public Studio_CD() { }

        public Studio_CD(int cdId, double cdStorage, string cdType, List<string> cdTracks) : base(cdId, cdStorage, cdType)
        {
            TrackNames = cdTracks;
        }

        // TODO: Implement your custom interface.
        public string SpinDisc()
        {
            return "500 rpm";
        }

        public void AddData(double addSomething)
        {
            TotalDataVolume = TotalDataVolume + addSomething;
        }


    }
}
