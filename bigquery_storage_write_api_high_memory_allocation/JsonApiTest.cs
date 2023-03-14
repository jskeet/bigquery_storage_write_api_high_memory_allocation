using Google.Apis.Bigquery.v2.Data;
using Google.Cloud.BigQuery.V2;
using System.Net;
using System.Reflection;
using static Google.Apis.Bigquery.v2.TabledataResource;

namespace bigquery_storage_write_api_high_memory_allocation;

internal class JsonApiTest
{
    // See https://github.com/googleapis/google-cloud-dotnet/blob/main/apis/Google.Cloud.BigQuery.V2/Google.Cloud.BigQuery.V2/BigQueryClientImpl.InsertData.cs#L300
    private delegate InsertAllRequest CreateInsertAllRequest(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions? options, out IReadOnlyList<BigQueryInsertRow> validatedRows);

    private CreateInsertAllRequest _requestConverter;

    public JsonApiTest()
    {
        var client = new BigQueryClientBuilder
        {
            ApiKey = "placeholder",
            ProjectId = "project"
        }.Build();
        var method = client.GetType().GetMethod("CreateInsertAllRequest", BindingFlags.NonPublic | BindingFlags.Instance);
        if (method is null)
        {
            throw new Exception("Couldn't find CreateInsertAllRequest method");
        }
        _requestConverter = (CreateInsertAllRequest) Delegate.CreateDelegate(typeof(CreateInsertAllRequest), client, method);
    }

    public void RunTest(TestConfiguration configuration)
    {
        for (int i = 0; i < configuration.Requests; i++)
        {
            var request = CreateRequest(configuration);
            // Creates an HttpRequestMessage with the serialized content
            request.CreateRequest(overrideGZipEnabled: null);
        }
    }

    private InsertAllRequest CreateRequest(TestConfiguration configuration)
    {
        var table = new TableReference { DatasetId = "dataset", ProjectId = "project", TableId = "table" };
        InsertOptions? options = null;
        var rows = Enumerable.Range(0, configuration.RowsPerRequest).Select(_ => CreateRecord());
        return _requestConverter(table, rows, options, out _);
    }

    private static BigQueryInsertRow CreateRecord()
    {
        var random = Random.Shared;

        return new BigQueryInsertRow
        {
            //fields
            ["minute_bucket"] = (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + random.Next(1000, 9000)) * 1000,
            ["user_reference"] = Guid.NewGuid().ToString(),
            ["system_id"] = random.Next(1, 10),
            ["application_name"] = "ApplicationName",
            ["request_type_name"] = "RequestTypeName",
            ["status_code"] = random.Next(101, 999),
            ["revision"] = random.Next(100000, 999999),
            ["host_name"] = Environment.MachineName,
            ["external_application_name"] = "ExternalApplicationName",
            ["ip_address"] = IPAddress.Any.ToString(),
            //counters
            ["total_duration"] = random.Next(1000, 9000),
            ["total_square_duration"] = random.Next(1000, 9000),
            ["request_bytes"] = random.Next(1000, 9000),
            ["response_bytes"] = random.Next(1000, 9000),
            ["pg_sessions"] = random.Next(1000, 9000),
            ["sql_sessions"] = random.Next(1000, 9000),
            ["pg_statements"] = random.Next(1000, 9000),
            ["sql_statements"] = random.Next(1000, 9000),
            ["pg_entities"] = random.Next(1000, 9000),
            ["sql_entities"] = random.Next(1000, 9000),
            ["cassandra_statements"] = random.Next(1000, 9000),
            ["hits"] = random.Next(1, 100),
        };
    }
}
