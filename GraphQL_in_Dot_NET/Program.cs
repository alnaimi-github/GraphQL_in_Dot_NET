using GraphQL_in_Dot_NET.Types;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Dog>()
    .AddType<Cat>()
    .AddType<Parrot>();

var app = builder.Build();


app.MapGraphQL();

app.Run();


