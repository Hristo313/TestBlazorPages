using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Pages;
using CRMApp.Financial;
using CRMApp.NorthwindSwagger;
using CRMApp.CRMAppData;

namespace TestCRMApp
{
  [Collection("CRMApp")]
  public class TestHome
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbButtonModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbListModule),
        typeof(IgbChipModule));
      ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      ctx.Services.AddScoped<ICRMAppDataService>(sp => new MockCRMAppDataService());
      var componentUnderTest = ctx.RenderComponent<Home>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
