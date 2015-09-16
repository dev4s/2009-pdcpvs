using System.Collections.Generic;
using NUnit.Framework;
using PDCPVS;

namespace Tests
{
    [TestFixture]
    public class PdcpvsMethodsTest
    {
        private Pdcpvs _mainForm;

        [TestFixtureSetUp]
        public void Init()
        {
            _mainForm = new Pdcpvs();
        }

        [TestFixtureTearDown]
        public void CleanUp()
        {
            _mainForm = null;
        }

        [Test]
        public void TestIfTurningOffControlsIsTurningOffAllControls()
        {
            Pdcpvs.TurnOffEnableProperty(_mainForm.Controls);

            for (int i = 0; i < _mainForm.Controls.Count; i++)
            {
                Assert.That(_mainForm.Controls[i].Enabled, Is.False, "Wartości nie są false!");
            }
        }

        [Test]
        public void TestIfTurningOffControlsIsNotForgettingControlsEnabledProperty()
        {
            var enabledPropertyList = new List<bool>();
            enabledPropertyList.AddRange(Pdcpvs.TurnOffEnableProperty(_mainForm.Controls));

            Assert.That(_mainForm.Controls.Count, Is.EqualTo(enabledPropertyList.Count), 
                "Nie zwraca poprawnej wielkości tablicy!");

            for (int i = 0; i < _mainForm.Controls.Count; i++)
            {
                Assert.That(_mainForm.Controls[i].Enabled, Is.EqualTo(enabledPropertyList[i]), 
                    "Nie zwraca poprawnych wartości!");
            }
        }
    }
}
