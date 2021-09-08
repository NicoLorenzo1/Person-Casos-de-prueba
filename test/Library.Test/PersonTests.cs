using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void TestType() // Cambiá el nombre para indicar qué estás probando
        {
            string value = "identification";
            bool result = IdUtils.IdIsValid(value);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void TestValidLength() 
        {
            string value = "1111111-1";
            bool result = IdUtils.IdIsValid(value);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestShortLength() 
        {
            string value = "111111-1";
            bool result = IdUtils.IdIsValid(value);
            Assert.False(result); //como el resultado es bool se puede usar Assert.false
        }

        [Test]
        public void TestMissingDash() 
        {
            string value = "11111111";
            bool result = IdUtils.IdIsValid(value);
            Assert.True(result);
        }

        [Test]
        public void TestDashWrongPosition() 
        {
            string value = "111-11111";
            bool result = IdUtils.IdIsValid(value);
            Assert.True(result);
        }

        [Test]
        public void TestNameNull() 
        {
           Person persona1 = new Person("", "1111111-1");
           Assert.AreEqual(null, persona1.Name);
        }

        [Test]
        public void TestValidName() 
        {
           Person persona1 = new Person("Juan Lopez", "1111111-1");
           Assert.AreEqual("Juan Lopez", persona1.Name);
        }
        
        [Test]
        public void TestName() 
        {
           Person persona1 = new Person(null, "1111111-1");
           Assert.AreEqual(null, persona1.Name);
        }

        [Test]
        public void TestChangeName() 
        {
           Person persona1 = new Person("Juan Lopez", "1111111-1");
           persona1.Name = "Sebastian Fernandez";
           Assert.AreEqual("Sebastian Fernandez", persona1.Name);
        }
    }
}
