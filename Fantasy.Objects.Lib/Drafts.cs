using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Fantasy.Objects.Lib
{
    public class Drafts
    {
        //TODO -- remove attributes not needed
        public class DraftPicks
        {

            public string player_id { get; set; }
            public string picked_by { get; set; }
            public string roster_id { get; set; }
            public int round { get; set; }
            public int draft_slot { get; set; }
            public int pick_no { get; set; }
            public object is_keeper { get; set; }
            public string draft_id { get; set; }

            public class Metadata
            {
                public string team { get; set; }
                public string status { get; set; }
                public string sport { get; set; }
                public string position { get; set; }
                public string player_id { get; set; }
                public string number { get; set; }
                public string news_updated { get; set; }
                public string last_name { get; set; }
                public string injury_status { get; set; }
                public string first_name { get; set; }
            }
        }

        public class DraftDetails
        {
            public string type { get; set; }
            public string status { get; set; }
            public long? start_time { get; set; }
            public string sport { get; set; }
            public string season_type { get; set; }
            public string season { get; set; }
            public string league_id { get; set; }
            public long last_picked { get; set; }
            public long last_message_time { get; set; }
            public string last_message_id { get; set; }
            public string draft_id { get; set; }
            public object creators { get; set; }
            public long created { get; set; }
        }

    }
}
