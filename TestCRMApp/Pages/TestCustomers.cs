using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Pages;
using CRMApp.NorthwindSwagger;

namespace TestCRMApp
{
  [Collection("CRMApp")]
  public class TestCustomers
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.ComponentFactories.AddStub<IgbPaginator>();
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbPaginatorModule),
        typeof(IgbActionStripModule),
        typeof(IgbInputModule),
        typeof(IgbSnackbarModule));
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Customers>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
