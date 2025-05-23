var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.XY_ApiService>("apiservice");

builder.AddProject<Projects.XY_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
