using System.Collections.Generic;

namespace TravelerTests
{
    public class Beach
    {
        //FIELDS
        private string eyeColor;
        private double shoeSize;
        private List<string> name = new List<string>();

        //PROPERTIES
        public string GetColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }

        public double GetShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        public List<string> Names
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //CONSTRUCTOR
        public Beach(string value)
        {
            this.GetColor = value;
        }

        public Beach() //default constructor
        {

        }

        //METHODS
        public string GetBeach(string value)
        {
            if (value == "green")
            {
                return "Seal Beach";
            }
            else if (value == "brown")
            {
                return "Newport Beach";
            }
            else if (value == "grey")
            {
                return "Huntington Beach";
            }
            else
            {
                return " ";
            }
        }
        
        public string GetHotel(double num, string value)
        {
            if(((num >=6) && (num <= 10)) && (value == "Seal Beach"))
            {
                return "Hilton";
            }
            else if(((num > 10) && (num <= 12)) && (value == "Huntington Beach"))
            {
                return "Best Western";
            }
            else if ((num > 12) && (value == "Newport Beach"))
            {
                return "Marriot";
            }
            else
            {
                return null;
            }           
        }

        public string GetNames()
        {
            if (Names.Count > 0 && Names.Count <= 4)
            {
                return "Toyota";
            }
            else
            {
                return null;
            }
        }
    }
}