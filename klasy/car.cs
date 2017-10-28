using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy
{
    class car
    {
        public string manufacturer;
        public string model;
        public string color;
        public int prod_year;
        public int engine_size;
        public string engine_type;
        public string car_type;
        public int driven_distance;
        public float mpg;

        public car(int year, string manufacturer, string model, string color,int enginesize,string enginetype,string cartype,float consumption)
        {
            this.prod_year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.color = color;
            this.engine_size = enginesize;
            this.engine_type = enginetype;
            this.car_type = cartype;
            this.mpg = consumption;
            this.driven_distance = 0;
        }
        public car(int year,string manufacturer,string model,string color)
        {
            this.prod_year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.color = color;
        }
        public void Drive(int distance)
        {
            this.driven_distance = this.driven_distance + distance; 
        }
        public void Fuel()
        {
        }
        public void Horn()
        {
        }
        public void Repaint(string color)
        {
            this.color = color;
        }
         
    }
}
