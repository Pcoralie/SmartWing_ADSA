using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWing_ADSA
{
    class Vector
    {
        //magnitude : length or size of the vector
        //direction

        //Attributes : 

        private double x;
        private double y; //float ? 

        //Getters and setters 
        
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

         /*
        public double GetX(){
             return this.x;
        }

        public double SetX(double value) {
             return this.x = value; 

         }

    */


        // Constructors 

        public Vector()
        {
           
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        //Functions : 

        public Vector CreateVector(double x , double y)
        {
            Vector vect = new Vector(x, y);
            return vect; 
        }

        public void SetAngle( double angle)
        {
            var length = this.GetLength();
            this.x = Math.Cos(angle) * length;
            this.y = Math.Sin(angle) * length;
        }

        public double GetAngle()
        {
            return Math.Atan2(this.y, this.x);
        }

        public void SetLength(double length)
        {
            var angle = this.GetAngle();
            this.x = Math.Cos(angle) * length;
            this.y = Math.Sin(angle) * length;
        }

        public double GetLength()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

        public Vector Add(Vector vect)
        {
            return CreateVector(this.x + vect.X, this.y + vect.Y); 
           // return create(this.x + vect.GetX(), this.y + vect.GetY());
        }

        public Vector Subtract(Vector vect)
        {
            return CreateVector(this.x - vect.X , this.y - vect.Y);
        }

        public Vector Multiply(double value)
        {
            return CreateVector(this.x * value, this.y * value); 
        }

        public Vector Divide( double value)
        {
            return CreateVector(this.x / value, this.y / value); 
        }

        public void AddTo( Vector vect)
        {
            this.x += vect.X;
            this.y += vect.Y; 
        }

        public void SubstractFrom(Vector vect)
        {
            this.x -= vect.X;
            this.y -= vect.Y; 
        }

        public void MultiplyBy( double value)
        {
            this.x *= value;
            this.y *= value; 
        }

        public void divideBy( double value)
        {
            this.x /= value;
            this.y /= value; 
        }

    }
}
