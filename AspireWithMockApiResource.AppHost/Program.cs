using AspireWithMockApiResource.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

var mockApi = builder.AddWireMockNet("apiservice", 5900)
    .WithApiMappingBuilder(WeatherForecastMock.Build);

builder.AddProject<Projects.AspireWithMockApiResource_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(mockApi);

builder.Build().Run();
