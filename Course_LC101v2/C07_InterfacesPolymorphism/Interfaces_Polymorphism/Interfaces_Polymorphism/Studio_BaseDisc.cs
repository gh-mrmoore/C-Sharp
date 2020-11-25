using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public abstract class Studio_BaseDisc
    {
        public const string DiscShape = "Circular";  // shape will be constant, no such thing as a square disc
        public double TotalDataVolume { get; set; }  // how much data can a CD or DVD hold?
        public int DiscId { get; set; }
        public string TypeOfDisc { get; set; }

        public Studio_BaseDisc() { }

        public Studio_BaseDisc(int idDisc, double volumeDisc, string typeDisc)
        {
            DiscId = idDisc;
            TotalDataVolume = volumeDisc;
            TypeOfDisc = typeDisc;
        }


    }
}
