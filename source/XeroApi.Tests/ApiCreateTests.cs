using NUnit.Framework;
using NUnit.Framework.Syntax.CSharp;
using XeroApi.Model;
using XeroApi.Tests.Stubs;

namespace XeroApi.Tests
{
    [TestFixture]
    public class ApiCreateTests
    {
        private StubIntegrationProxy _integrationProxy;
        private Repository _repository;

        [SetUp]
        public void SetUp()
        {
            _integrationProxy = new StubIntegrationProxy();
            _repository = new Repository(_integrationProxy);
        }
    }
}
