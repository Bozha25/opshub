using System.Reflection;

namespace OpsHub.UnitTests.Architecture;

public class LayerDependencyTests
{
    private const string Application = "OpsHub.Application";
    private const string Infrastructure = "OpsHub.Infrastructure";
    private const string Api = "OpsHub.Api";

    [Fact]
    public void Domain_ShouldNotDependOnAnyOtherLayer()
    {
        var refs = ReferencedOpsHubAssemblies(OpsHub.Domain.AssemblyReference.Assembly);
        Assert.DoesNotContain(Application, refs);
        Assert.DoesNotContain(Infrastructure, refs);
        Assert.DoesNotContain(Api, refs);
    }

    [Fact]
    public void Application_ShouldOnlyDependOnDomain()
    {
        var refs = ReferencedOpsHubAssemblies(OpsHub.Application.AssemblyReference.Assembly);
        Assert.DoesNotContain(Infrastructure, refs);
        Assert.DoesNotContain(Api, refs);
    }

    private static string[] ReferencedOpsHubAssemblies(Assembly assembly) =>
        assembly.GetReferencedAssemblies()
            .Select(a => a.Name!)
            .Where(n => n.StartsWith("OpsHub.", StringComparison.Ordinal))
            .ToArray();
}