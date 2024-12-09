using GraphQL_in_Dot_NET.Types;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Dog>()
    .AddType<Cat>()
    .AddType<Parrot>()
    .ModifyOptions(o => o.StripLeadingIFromInterface = true);

var app = builder.Build();


app.MapGraphQL();

app.Run();


