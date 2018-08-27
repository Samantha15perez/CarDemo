using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //the getcardata method accepts a car object as an argument. it assigns the data entered by the private void getcardata(car car)
        //private void GetCarData(Car car)

        private void GetCarData(Car car)
        {
            //temporary variables to hold mileage, price, and number of doors
            int mileage;
            decimal price;
            int doors;

            //get the cars make
            car.Make = makeTextBox.Text;

            //get the cars model
            car.Model = modelTextBox.Text;

            //get the cars mileage
            if (int.TryParse(mileageTextBox.Text, out mileage))
            {
                car.Mileage = mileage;

                //get the cars price
                if (decimal.TryParse(priceTextBox.Text, out price))
                {
                    //get the number of doors
                    if (int.TryParse(doorsTextBox.Text, out doors))
                    {
                        car.Doors = doors;
                    }
                    else
                    {
                        //display an error message
                        MessageBox.Show("Invalid number of doors");
                    }
                }
                else
                {
                    //display an error message
                    MessageBox.Show("Invalid price");
                }
            }
            else
            {
                //display an error message
                MessageBox.Show("Invalid mileage");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            //create a car object
            Car mycar = new Car();
            //get the car data
            GetCarData(mycar);
            //display the car data
            makeLabel.Text = mycar.Make;
            modelLabel.Text = mycar.Model;
            mileageLabel.Text = mycar.Mileage.ToString();
            priceLabel.Text = mycar.Price.ToString("c");
            doorsLabel.Text = mycar.Doors.ToString();
        }
    }
}
