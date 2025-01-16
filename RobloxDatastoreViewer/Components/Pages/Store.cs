using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxDatastoreViewer.Components.Pages
{
    public class DataStore
    {
        public string? path { get; set; }
        public DateTime? createTime { get; set; }
        public string? id { get; set; }
    }

    public class DataStoreRoot
    {
        public List<DataStore>? dataStores { get; set; }
        public string? nextPageToken { get; set; }
    }
}
