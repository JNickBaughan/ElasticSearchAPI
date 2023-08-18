using Nest;

namespace ElasticSearchAPI
{
    public static class Extensions
    {
            public static void AddElasticSearchClient(this IServiceCollection services, 
            IConfiguration configuration)
            {
                var url = configuration["ElasticSearchConfiguration:url"];

                var client = new ElasticClient(new ConnectionSettings(new Uri(url)));

                services.AddSingleton<IElasticClient>(client);

            }

        }
    }