using NUnit.Framework;
using NUnitTestOrdering.FixtureOrdering;
using NUnitTestOrdering.FixtureOrdering.Internal;

[assembly: EnableTestOrdering]

namespace Tests
{
    [OrderedTestGlobalSetUpFixture]
    [SetUpFixture]
    public sealed class OneTime
    {
        [OneTimeSetUp]
        public void CallRunBeforeAnyTests()
        {
           
        }

        [OneTimeTearDown]
        public void CallRunAfterAnyTests()
        {
           
        }
    }

    public class MyFixture
    {
        [OneTimeSetUp]
        public void CallPrepareAll()
        {
           
        }

        [SetUp]
        public void CallStartUpTest()
        {
            
        }

        [TearDown]
        public void CallAfterTest()
        {
            
        }

        [OneTimeTearDown]
        public void CallCloseAll()
        {

        }

        [Test]
        public void MyTest()
        {
            Assert.Pass();
        }
    }

    [OrderedTestFixture]
    public sealed class RootOrderedTestFixture : TestOrderingSpecification
    {
        public RootOrderedTestFixture() { }
        protected override bool ContinueOnError => true;
        protected override void DefineTestOrdering()
        {
            /*#######################
              #### FIXTURE ORDER ####
              #######################*/

            TestFixture<MyFixture>();         
                                                       
        }
    }
}



