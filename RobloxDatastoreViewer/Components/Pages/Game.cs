using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxDatastoreViewer.Components.Pages
{
    public class Creator
    {
        public long? id { get; set; }
        public string? type { get; set; }
    }

    public class GameData
    {
        public long id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public Creator? creator { get; set; }
        public required RootPlace rootPlace { get; set; }
        public DateTime? created { get; set; }
        public DateTime updated { get; set; }
        public int placeVisits { get; set; }
    }

    public class GameRoot
    {
        public object? previousPageCursor { get; set; }
        public object? nextPageCursor { get; set; }
        public required List<GameData> data { get; set; }
    }

    public class RootPlace
    {
        public long id { get; set; }
        public string? type { get; set; }
    }
}
