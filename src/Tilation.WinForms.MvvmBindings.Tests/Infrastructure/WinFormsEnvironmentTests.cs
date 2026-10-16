
using NUnit.Framework;
using System.Threading;
using System.Windows.Forms;

namespace Tilation.WinForms.MvvmBindings.Tests.Infrastructure
{
    [TestFixture]
    [Apartment(ApartmentState.STA)]
    public class WinFormsEnvironmentTests
    {
        [Test]
        public void TestThread_ShouldUseSTA()
        {
            Assert.That(
                Thread.CurrentThread.GetApartmentState(),
                Is.EqualTo(ApartmentState.STA));
        }

        [Test]
        public void ShouldCreateWinFormsControl()
        {
            using (var button = new Button())
            {
                Assert.That(button, Is.Not.Null);
                Assert.That(button.Enabled, Is.True);
            }
        }
    }
}
