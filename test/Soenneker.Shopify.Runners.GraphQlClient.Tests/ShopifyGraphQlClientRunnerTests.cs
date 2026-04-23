using Soenneker.Tests.HostedUnit;

namespace Soenneker.Shopify.Runners.GraphQlClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ShopifyGraphQlClientRunnerTests : HostedUnitTest
{

    public ShopifyGraphQlClientRunnerTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
