using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fantasy.Objects.Lib;
using Fantasy.Common.Lib;
namespace UnitTests
{
    [TestClass]
    public class SleeperAPITests
    {
        //TODO -- Setup and tear down!!!!!

        [TestMethod]
        [Ignore]
        //this call returns a lot of data, so dont run frequently
        public void GetPlayerDataTests()
        {
            Dictionary<string, Player.SleeperPlayer> oPlayers = SleeperAPI.GetPlayerData();
        }

        [TestMethod]
        public void GetDraftPicks()
        {
            long iDraftId = 333861762015178752; //2018 Draft -- Best way to get this each year??
            List<Drafts.DraftPicks> oDraftPicks = SleeperAPI.GetDraftPicks(iDraftId);
        }

        [TestMethod]
        public void GetDraftDetails()
        {
            long iDraftId = 333861762015178752; 
            Drafts.DraftDetails oDraftDetails = SleeperAPI.GetDraftDetails(iDraftId);
        }
    }
}
