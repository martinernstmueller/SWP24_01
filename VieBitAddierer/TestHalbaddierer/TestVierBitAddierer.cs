namespace TestHalbaddierer
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(true, false, true, false)]
        [TestCase(false, false, false, false)]
        [TestCase(false, true, true, false)]
        [TestCase(true, true, false, true)]
        public void HalbAddierer_DifferentInputs_ReturnsCorrectValues(bool x, bool y, bool s, bool c)
        {
            var myAdder = new FourBitAdd();
            var res = myAdder.HalfAdding(x, y);
            Assert.That(res == ((s, c)));
        }

        [Test]
        [TestCase(true, false, true, false, true)]
        [TestCase(false, false, false, false, true)]
        [TestCase(false, true, true, false, true)]
        [TestCase(true, true, true, true, true)]

        public void FullAdder_DifferentInputs_ReturnsCorrectValues(bool a0, bool b0, bool ue, bool S, bool Uee)
        {
            var myAdder = new FourBitAdd();
            var res = myAdder.FullAdding(a0, b0, ue);
            Assert.That(res == ((S, Uee)));
        }

        [Test]
        public void OutInt()
        {
            int b = 41;
            var myAdder = new FourBitAdd();
            myAdder.a(out b);
            Assert.That(b == 42);
       }

    }
}