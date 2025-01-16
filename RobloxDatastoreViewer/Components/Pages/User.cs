using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxDatastoreViewer.Components.Pages
{
    public class UserRequest
    {
        public List<string>? usernames { get; set; }
        public bool excludeBannedUsers { get; set; }
    }

    public class User
    {
        public string? requestedUsername { get; set; }
        public bool hasVerifiedBadge { get; set; }
        public long id { get; set; }
        public string? name { get; set; }
        public string? displayName { get; set; }
    }

    public class UserResponse
    {
        public required List<User> data { get; set; }
    }
}
