using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp.Pages;
using Microsoft.AspNetCore.Components;
using CRMApp.NorthwindSwagger;

namespace TestCRMApp
{
  [Collection("CRMApp")]
  public class TestCustomer_details
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbTabsModule),
        typeof(IgbGridModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbAvatarModule),
        typeof(IgbCheckboxModule),
        typeof(IgbListModule),
        typeof(IgbChipModule));
      var routeData = new RouteData(typeof(Customer_details), new Dictionary<string, object>());
      ctx.Services.AddSingleton(routeData);
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Customer_details>(p => p.AddCascadingValue(routeData));
      Assert.NotNull(componentUnderTest);
    }
  }
}
