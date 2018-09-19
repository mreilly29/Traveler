namespace TravelerTests
{
    public class Beach
    {
        //FIELDS
        private string eyeColor;
        private double shoeSize;

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
            if((num == 10) && (value == "Seal Beach"))
            {
                return "Hilton";
            }
            return null;
        }
    }
}