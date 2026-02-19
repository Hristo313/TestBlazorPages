using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Pages;
using CRMApp.Financial;
using CRMApp.CRMAIGeneratedData;

namespace TestCRMApp
{
  [Collection("CRMApp")]
  public class TestSupport
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbPieChartModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      ctx.Services.AddScoped<ICRMAIGeneratedDataService>(sp => new MockCRMAIGeneratedDataService());
      var componentUnderTest = ctx.RenderComponent<Support>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
