using ClassLibrary;
using NewLabTest;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "", "")]
        [TestCase("", "1", "2")]
        [TestCase("1", "", "2")]
        [TestCase("1", "2", "")]
        public void ClearInput(string f, string s, string t)
        {
            triangleInfo actual = Controller.GoControl(f, s, t);
            string expect = "Нечисловые данные";
            Assert.That(actual.type, Is.EqualTo(expect));
        }

        [TestCase("@", "@", "@")]
        [TestCase("@", "1", "2")]
        [TestCase("1", "@", "2")]
        [TestCase("1", "2", "@")]
        public void SymbolInput(string f, string s, string t)
        {
            triangleInfo actual = Controller.GoControl(f, s, t);
            string expect = "Нечисловые данные";
            Assert.That(actual.type, Is.EqualTo(expect));
        }

        [TestCase("a", "a", "a")]
        [TestCase("a", "1", "2")]
        [TestCase("1", "a", "2")]
        [TestCase("1", "2", "a")]
        public void NotDigitInput(string f, string s, string t)
        {
            triangleInfo actual = Controller.GoControl(f, s, t);
            string expect = "Нечисловые данные";
            Assert.That(actual.type, Is.EqualTo(expect));
        }

        [TestCase("-1", "-1", "-1")]
        [TestCase("-1", "1", "2")]
        [TestCase("1", "-1", "2")]
        [TestCase("1", "2", "-1")]
        public void InvalydDigit(string f, string s, string t)
        {
            triangleInfo actual = Controller.GoControl(f, s, t);
            string expect = "Невалидные значения";
            Assert.That(actual.type, Is.EqualTo(expect));
        }

        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "2")]
        [TestCase("1", "0", "2")]
        [TestCase("1", "2", "0")]
        public void NullInput(string f, string s, string t)
        {
            triangleInfo actual = Controller.GoControl(f, s, t);
            string expect = "Невалидные значения";
            Assert.That(actual.type, Is.EqualTo(expect));
        }

        [TestCase("2", "2", "4")]
        public void NotTriangle(string f, string s, string t)
        {
            triangleInfo actual = Controller.GoControl(f, s, t);
            string expect = "Не треугольник";
            Assert.That(actual.type, Is.EqualTo(expect));
        }
    }
}