using Google.Cloud.BigQuery.Storage.V1;
using Google.Protobuf;
using System.Net;
using static Google.Cloud.BigQuery.Storage.V1.AppendRowsRequest.Types;

namespace bigquery_storage_write_api_high_memory_allocation;

internal class StorageWriteTest
{
    internal void RunTest(TestConfiguration configuration)
    {
        var stream = new MemoryStream();

        for (int i = 0; i < configuration.Requests; i++)
        {
            var request = CreateRequest(configuration);
            request.WriteTo(stream);
            stream.Position = 0;
        }
    }

    private AppendRowsRequest CreateRequest(TestConfiguration configuration) =>
        new AppendRowsRequest
        {            
            ProtoRows = new ProtoData
            {
                // TODO: Try using a fixed schema
                WriterSchema = new ProtoSchema { ProtoDescriptor = WatchtowerRecord.Descriptor.ToProto() },
                Rows = new ProtoRows
                {
                    SerializedRows =
                    { 
                        Enumerable.Range(0, configuration.RowsPerRequest).Select(_ => CreateRecord().ToByteString()) 
                    }
                }
            }
        };

    private WatchtowerRecord CreateRecord()
    {
        var random = Random.Shared;
        return new WatchtowerRecord
        {
            // fields
            MinuteBucket = (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + random.Next(1000, 9000)) * 1000,
            UserReference = Guid.NewGuid().ToString(),
            SystemId = random.Next(1, 10),
            ApplicationName = "ApplicationName",
            RequestTypeName = "RequestTypeName",
            StatusCode = random.Next(101, 999),
            Revision = random.Next(100000, 999999),
            HostName = Environment.MachineName,
            ExternalApplicationName = "ExternalApplicationName",
            IpAddress = IPAddress.Any.ToString(),
            // counters
            TotalDuration = random.Next(1000, 9000),
            TotalSquareDuration = random.Next(1000, 9000),
            RequestBytes = random.Next(1000, 9000),
            ResponseBytes = random.Next(1000, 9000),
            PgSessions = random.Next(1000, 9000),
            SqlSessions = random.Next(1000, 9000),
            PgStatements = random.Next(1000, 9000),
            SqlStatements = random.Next(1000, 9000),
            PgEntities = random.Next(1000, 9000),
            SqlEntities = random.Next(1000, 9000),
            CassandraStatements = random.Next(1000, 9000),
            Hits = random.Next(1, 100),
        };
    }
}
