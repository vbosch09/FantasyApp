namespace Fantasy.Objects.Lib
{
    public class Player
    {
        public class SleeperPlayer
        {
            public string hashtag { get; set; }
            public string status { get; set; }
            public string sport { get; set; }
            public string fantasy_positions { get; set; }
            public int number { get; set; }
            public string position { get; set; } 
            public string team { get; set; }
            public string last_name { get; set; }
            public string player_id { get; set; }
            public string age { get; set; }
            public string stats_id { get; set; }
            public string first_name { get; set; }
        }

        public class PlayerData
        {
            public int? PlayerId { get; set;}
            public int SleeperId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Team { get; set; }
            public string Position { get; set; }
        }
    }
}
