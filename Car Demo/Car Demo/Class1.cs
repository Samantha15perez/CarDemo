using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Demo
{
    class Automobile
    {
        //fields
        private string _make;
        private string _model;
        private int _mileage;
        private decimal _price;
        
        //constructor
        public Automobile()
        {
            _make = "";
            _model = "";
            _mileage = 0;
            _price = 0;
        }

        //make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //mileage property
        public int Mileage
        {
            get { return _mileage;}
            set { _mileage = value; }
        }

        //price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }

    class Car : Automobile
    {
        //field
        private int _doors;

        //constructor
        public Car()
        {
            _doors = 0;
        }

        //doors property
        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }
    }

    class truck : Automobile
    {
        //field
        private string _drive;

        //constructor
        public truck()
        {
            _drive = "";
        }
        //drive property
        public string drive
        {
            get { return _drive; }
            set {  _drive = value; }
        }
    }

    class sportutility : Automobile
    {
        //field
        private int _passengers;
        //constructor
        public sportutility()
        {
            _passengers = 0;
        }
        //passengers property
        public int passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }
    }
}
