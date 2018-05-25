using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CanCreatePC()
        {
            var x = new PC("Age of Empires", "Strategy", "Microsoft Games", "PC", 30);

            Assert.IsTrue(x.Name == "Age of Empires");
            Assert.IsTrue(x.Genre == "Strategy");
            Assert.IsTrue(x.Publisher == "Microsoft Games");
            Assert.IsTrue(x.Plattform == "PC");
            Assert.IsTrue(x.Price == 30);
        }

        [Test]
        public void CannotCreatePCWithEmptyName()
        {
            Assert.Catch(() =>
            {
                var x = new PC(null, "Strategy", "Microsoft Games", "PC", 30);
            });
        }

        [Test]
        public void CannotCreatePCWithEmptyName2()
        {
            Assert.Catch(() =>
            {
                var x = new PC("", "Strategy", "Microsoft Games", "PC", 30);
            });
        }

        [Test]
        public void CannotCreatePCWithEmptyGenre1()
        {
            Assert.Catch(() =>
            {
                var x = new PC("Age of Empires",null,"Microsoft Games", "PC", 30);
            });
        }

        [Test]
        public void CannotCreatePCWithEmptyGenre2()
        {
            Assert.Catch(() =>
            {
                var x = new PC("Age of Empires", "", "Microsoft Games", "PC", 30);
            });
        }
        [Test]
        public void CannotCreatePCWithEmptyPlattform1()
        {
            Assert.Catch(() =>
            {
                var x = new PC("Age of Empires", "Strategy", "Microsoft Games", null, 30);
            });
        }

        [Test]
        public void CannotCreatePCWithEmptyPlattform2()
        {
            Assert.Catch(() =>
            {
                var x = new PC("Age of Empires", "Strategy", "Microsoft Games", "", 30);
            });
        }

        [Test]
        public void CannotCreatePCWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new PC("Age of Empires", "Strategy", "Microsoft Games", "PC", -30);
            });
        }

        [Test]
        public void CanUpdatePCWithPrice()
        {
            var x = new PC("Age of Empires", "Strategy", "Microsoft Games", "PC", 30);
            x.CalculatePrice();

            Assert.IsTrue(x.Ust != 0);
            Assert.IsTrue(x.Price > 30);
        }
    }
}
