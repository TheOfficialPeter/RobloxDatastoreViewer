using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxDatastoreViewer.Components.Pages
{
    public class DatastoreResponse
    {
        public List<Datastore>? dataStores { get; set; }
        public string? nextPageToken { get; set; }
    }

    public class Datastore
    {
        public required string path { get; set; }
        public DateTime? createTime { get; set; }
        public required string id { get; set; }
    }

    public class DatastoreEntry
    {
        public string path { get; set; }
        public string id { get; set; }
    }

    public class DataStoreResponseEntry
    {
        public required List<DatastoreEntry> dataStoreEntries { get; set; }
    }

    public class DatastoreResponseData
    {
        public string? path { get; set; }
        public string? createTime { get; set; }
        public string? revisionId { get; set; }
        public string? revisionCreateTime { get; set; }
        public string? state { get; set; }
        public string? etag { get; set; }
        public object? value { get; set; }
        public string? id { get; set; }
        public Attributes? attributes { get; set; }
    }

    public class DatastoreDataList
    {
       public List<DatastoreResponseData> datastoreData { get; set; }
    }

    public class Attributes
    {
    }

    public class DatastoreEntryFields
    {
        public string etag { get; set; }
        public string value { get; set; }
    }

    public class DatastoreEntryPayload
    {
        public object? value { get; set; }
    }
}
