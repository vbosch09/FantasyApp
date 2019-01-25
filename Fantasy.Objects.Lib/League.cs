using System;

namespace Fantasy.Objects.Lib
{
    public class League
    {
        public class LeagueData
        {
            public int Total_Rosters { get; set; }
            public string Status { get; set; }
            public string Sport { get; set; }
            public string Season_Type { get; set; }
            public int Season { get; set; }
            public int Previous_League_Id { get; set; }
            public string Name { get; set; }
            public long League_Id { get; set; }
            public long Draft_Id { get; set; }
            public string Avatar { get; set; }
        }
    }
}
