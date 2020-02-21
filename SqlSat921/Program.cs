using System.Threading.Tasks;

namespace SqlSat921
{
    internal class Program
    {
        private const string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SqlSat921;Integrated Security=True";

        private static Task Main(string[] args)
        {
            //return Parameters.RunSample(connectionString);

            //return MultipleResultsets.RunSampleAsync(connectionString);

            //return MultipleMappings.RunSampleAsync(connectionString);

            //return CustomColumnMapping.RunSampleAsync(connectionString);

            return CustomTypeHandling.RunSampleAsync(connectionString);
        }
    }
}
