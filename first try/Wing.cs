using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWing_ADSA
{
    class Wing
    {
        //Attributes : 
        private Vector position; // ( x , y )
        private Vector velocity; // ( xspeed , yspeed ) 
        // mass ? 
        // gravity ? 


        public void Function( double x , double y , double speed , double direction)
        {
            this.position = new Vector(x, y);
            this.velocity = new Vector(0, 0);
            this.velocity.SetLength(speed);
            this.velocity.SetAngle(direction);
           
        }

        public void Accelerate( Vector acceleration)
        {
            this.velocity.AddTo(acceleration);
            // velocity = velocity + acceleration; 
            // velocity.Add(acceleration); 
        }

        public void UpdatePosition()
        {
            //position = position + velocity; 
            // x = x + xspeed ; 
            // y += yspeed ; 
            //position.Add(velocity); 
            this.position.AddTo(this.velocity); 
        }


    }
}
