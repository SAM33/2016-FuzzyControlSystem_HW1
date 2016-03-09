using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FuzzyControlSystem_Demo1
{
    abstract class car
    {
        double _x, _y;
        double _theta;
        double _end_x, _end_y;
        const double radius = 3.0;
        public car(double start_x, double start_y, double start_theta, double end_x, double end_y)
        {

        }
        public abstract void draw(Graphics g);
        public abstract double decide(double x, double y, double theta, double f_dis, double r45_dis, double l45_dis);
        public abstract void gameover();
        
    }
}
