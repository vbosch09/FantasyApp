using System;
using System.Net;
using Newtonsoft.Json;
using Fantasy.Objects.Lib;
using System.IO;
using System.Collections.Generic;
namespace Fantasy.Common.Lib
{
    public static class SleeperAPI
    {
        public static Dictionary<string, Player.SleeperPlayer> GetPlayerData()
        {

            string szRequestAddress = "https://api.sleeper.app/v1/players/nfl";

            WebRequest oRequest = WebRequest.Create(szRequestAddress);
            oRequest.UseDefaultCredentials = true;

            WebResponse oResponse = oRequest.GetResponse();
            Stream oStream = oResponse.GetResponseStream();
            StreamReader oReader = new StreamReader(oStream);
            string szRespone = oReader.ReadToEnd();
            Dictionary<string, Player.SleeperPlayer> oPlayers =
                JsonConvert.DeserializeObject<Dictionary<string, Player.SleeperPlayer>>(szRespone);

            return oPlayers;
        }

        public static List<Drafts.DraftPicks> GetDraftPicks(long iDraftId)
        {
            string szRequestAddress = $"https://api.sleeper.app/v1/draft/{iDraftId}/picks";

            WebRequest oRequest = WebRequest.Create(szRequestAddress);
            oRequest.UseDefaultCredentials = true;

            WebResponse oResponse = oRequest.GetResponse();
            Stream oStream = oResponse.GetResponseStream();
            StreamReader oReader = new StreamReader(oStream);
            string szRespone = oReader.ReadToEnd();
            List<Drafts.DraftPicks> oDraftPicks =
                JsonConvert.DeserializeObject<List<Drafts.DraftPicks>>(szRespone);

            return oDraftPicks;
        }

        public static Drafts.DraftDetails GetDraftDetails(long iDraftId)
        {
            string szRequestAddress = $"https://api.sleeper.app/v1/draft/{iDraftId}";

            WebRequest oRequest = WebRequest.Create(szRequestAddress);
            oRequest.UseDefaultCredentials = true;

            WebResponse oResponse = oRequest.GetResponse();
            Stream oStream = oResponse.GetResponseStream();
            StreamReader oReader = new StreamReader(oStream);
            string szRespone = oReader.ReadToEnd();

            Drafts.DraftDetails oDraftDetails =
                JsonConvert.DeserializeObject<Drafts.DraftDetails>(szRespone);

            return oDraftDetails;
        }
    }
}
