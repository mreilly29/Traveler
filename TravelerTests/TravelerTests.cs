using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerTests
{
    [TestFixture]
    class TravelerTests
    {
        Beach beach = new Beach();
        [Test]
        public void Enter_Eye_Color()
        {
            Beach beach = new Beach("blue");
            string response = beach.GetColor;
            Assert.That(response, Is.EqualTo("blue"));
        }

        [Test]
        public void Enter_String_Return_Beach()
        {            
            string response = beach.GetBeach("blue");
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Enter_String_Return_Beach_Not_Empty()
        {
            string response = beach.GetBeach("green");
            Assert.That(response, Is.EqualTo("Seal Beach"));
        }

        [Test]
        public void Enter_String_Return_Beach_Color_Brown()
        {
            string response = beach.GetBeach("brown");
            Assert.That(response, Is.EqualTo("Newport Beach"));
        }

        [Test]
        public void Enter_String_Return_Beach_Color_Grey()
        {
            string response = beach.GetBeach("grey");
            Assert.That(response, Is.EqualTo("Huntington Beach"));
        }

        [Test]
        public void Set_Shoe_Size()
        {
            beach.GetShoeSize = 10.5;
            double response = beach.GetShoeSize;
            Assert.That(response, Is.EqualTo(10.5));
        }

        [Test]
        public void Get_Hotel_Size_Equals_0_And_Beach_Equals_Empty_Return_Null()
        {
            string location = beach.GetBeach(" ");
            string response = beach.GetHotel(0, location);
            Assert.That(response, Is.EqualTo(null));
        }

        [Test]
        public void Get_Hotel_Size_Equals_10_And_Beach_Equals_Seal_Beach_Return_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(10, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }
    }
}
