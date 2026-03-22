using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Shopify.Runners.GraphQlClient.Tests;

[Collection("Collection")]
public sealed class ShopifyGraphQlClientRunnerTests : FixturedUnitTest
{

    public ShopifyGraphQlClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
