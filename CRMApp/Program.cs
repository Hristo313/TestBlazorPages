using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CRMApp;
using CRMApp.CRMAppData;
using CRMApp.NorthwindSwagger;
using CRMApp.Financial;
using CRMApp.CRMAIGeneratedData;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICRMAppDataService, CRMAppDataService>();
builder.Services.AddScoped<INorthwindSwaggerService, NorthwindSwaggerService>();
builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<ICRMAIGeneratedDataService, CRMAIGeneratedDataService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbAvatarModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownHeaderModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbListModule),
        typeof(IgbChipModule),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbPaginatorModule),
        typeof(IgbActionStripModule),
        typeof(IgbInputModule),
        typeof(IgbSnackbarModule),
        typeof(IgbTabsModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbCheckboxModule),
        typeof(IgbSelectModule),
        typeof(IgbButtonGroupModule),
        typeof(IgbToggleButtonModule),
        typeof(IgbPieChartModule)
    );
}