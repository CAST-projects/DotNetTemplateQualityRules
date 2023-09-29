using NUnit.Framework;
using System.Linq;

namespace CastDotNetExtension.UnitTest
{
    [TestFixture]
    class TemplateQualityRuleTests
    {
        /// Implementation of the test using the following template
        [Test]
        public void TestMethod1()
        {
            // [TODO#10] load the source code to test from resources
            // note: a source file should have been added to the resources using the Resource file "SourcesToTest.resx"
            var testSrc = UnitTestTemplateCastQualityRules.Properties.SourcesToTest.SomeSourcesToTest;

            // [TODO#11] create the checker object, parametrized with the type of the QR to test
            var checker = CastDotNetExtensionChecker<TemplateCastQualityRule>.CreateInstance();
            Assert.IsTrue(checker != null);

            // [TODO#12] Configure the analysis
            // checker.AddAssemblyRef(@"C:\Examples\Packages\myAssembly.dll");
            // checker.AddSource(@"C:\Examples\Sources\toolbox.cs");

            // [TODO#13] launch the processing on the given source code
            checker.Apply(testSrc);


            // [TODO#14] setup the expected bookmarks
            checker.AddExpected(12, 12);

            // Launch the validation
            checker.Validate();

            // [TODO#15] Compare the results with the expectation
            Assert.IsTrue(checker.IsValid(), checker.GetStatus());

            // NOTE: You can also check in more details:
            // Assert.IsFalse(checker.ResultsMissing.Any());
            // Assert.IsFalse(checker.ResultsUnexpected.Any());
        }
    }
}

