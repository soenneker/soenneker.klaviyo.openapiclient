using Soenneker.Tests.HostedUnit;

namespace Soenneker.Klaviyo.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class KlaviyoOpenApiClientTests : HostedUnitTest
{
    public KlaviyoOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
