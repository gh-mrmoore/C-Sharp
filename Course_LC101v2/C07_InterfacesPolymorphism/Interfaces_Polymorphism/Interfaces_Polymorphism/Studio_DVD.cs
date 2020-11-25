using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    class Studio_DVD : Studio_BaseDisc, IOpticalDisc
    {
        // TODO: Determine whcih fields, methods and constructors can be extended from the base class and which ones can't
        public string VideoTitle { get; set; }

        public Studio_DVD( int discId, double dataVolume, string discType, string discTitle) : base(discId, dataVolume, discType)
        {
            // DiscId = discId;
            // TotalDataVolume = dataVolume;
            // TypeOfDisc = discType;
            VideoTitle = discTitle;
        }

        // TODO: Implement your custom interface.
        public string SpinDisc()
        {
            return "570-1600 rpm";
        }

        public void AddData(double addSomething)
        {
            TotalDataVolume = TotalDataVolume + addSomething;
        }


    }
}
