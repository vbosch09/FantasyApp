using System;
using Fantasy.Common.Lib;
using Fantasy.Objects.Lib;


namespace FantasyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerUpdatesFirst
            Configs oRunPlayerUpdates = ConfigHelper.GetConfigByName(Constants.RUN_PLAYER_UPDATES);
            if (oRunPlayerUpdates.Value == Constants.TRUE)
            {
                //update config first, dont want running continuously if error occurs
                oRunPlayerUpdates.Value = Constants.FALSE;
                ConfigHelper.UpdateConfig(oRunPlayerUpdates);

                PlayerUpdates.RunPlayerUpdates();
            }

        }
    }
}
