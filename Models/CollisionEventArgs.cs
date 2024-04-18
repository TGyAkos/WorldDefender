using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDefender.Models
{
    internal class CollisionEventArgs : EventArgs
    {
        public object Sender { get;set; }
        public double PosY { get;set; } 
        public double MinX { get;set; }
        public double MaxX { get; set; }
    }
}
