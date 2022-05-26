using FlaUI.Core;
using FlaUI.Core.Conditions;
using FlaUI.UIA2;
using NUnit.Framework;

namespace SpikySpamShellTest
{
    [TestFixture]
    public class ApplicationTests
    {
        [Test]
        public void AppLaunchTest()
        {

            using (var app = Application.Launch(@".\SpikySpamShellExtension\bin\Debug\SpikySpamShellExtension.exe"))
            {
                using (var automation = new UIA2Automation())
                {
                    var window = app.GetMainWindow(automation);
                    Assert.That(window, Is.Not.Null);
                    Assert.That(window.Title, Is.Not.Null);
                }
                app.Close();
            }

        }

        [Test]
        public void AddTest()
        {

            using (var app = Application.Launch(@".\SpikySpamShellExtension\bin\Debug\SpikySpamShellExtension.exe"))
            {
                using (var automation = new UIA2Automation())
                {
                    var window = app.GetMainWindow(automation);
                    var cf = new ConditionFactory(new UIA2PropertyLibrary());

                    Assert.DoesNotThrow(() =>
                    {
                        var btnAdd = window.FindFirstDescendant(cf.ByAutomationId("btnAdd"));
                        btnAdd.Click();
                    });
                }
                app.Close();
            }

        }
    }
}
