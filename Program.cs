var builder = new HostApplicationBuilder(args);

builder.Configuration.AddEnvironmentVariables();

var configuration = builder.Configuration.GetRequiredSection("Redis").Get<RedisConfiguration>() ?? throw new ArgumentException("Redis configuration");

builder.Services.AddStackExchangeRedisExtensions<SystemTextJsonSerializer>(configuration);

var app = builder.Build();

var client = app.Services.GetRequiredService<IRedisDatabase>();

await client.AddAsync("myKey", "It works!");

var result = await client.GetAsync<string>("myKey");

Console.WriteLine(result);

