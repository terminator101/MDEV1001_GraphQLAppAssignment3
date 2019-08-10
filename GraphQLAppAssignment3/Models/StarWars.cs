using System;
namespace GraphQLAppAssignment3.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class StarWars
    {
        public string title { get; set; }
        public string director { get; set; }
        public string id { get; set; }

        public string directorId { get { return "Director: " + director + " ) ID: " + id; } }
    }
}
