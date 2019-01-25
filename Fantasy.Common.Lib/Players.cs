using System.Collections.Generic;
using System.Linq;
using Fantasy.Objects.Lib;
using Dapper;
using System.Data;

namespace Fantasy.Common.Lib
{
    public static class Players
    {
        //Insert Player
        public static void InsertPlayer(Player.PlayerData oPlayer)
        {
            using (IDbConnection oSql = DatabaseHelper.CreateSqlConnection())
            {
                DynamicParameters oParameters = new DynamicParameters();
                oParameters.Add("@in_SleeperId", oPlayer.SleeperId, DbType.Int64, ParameterDirection.Input);
                oParameters.Add("@in_FirstName", oPlayer.FirstName, DbType.String, ParameterDirection.Input);
                oParameters.Add("@in_LastName", oPlayer.LastName, DbType.String, ParameterDirection.Input);
                oParameters.Add("@in_Team", oPlayer.Team, DbType.String, ParameterDirection.Input);
                oParameters.Add("@in_Position", oPlayer.Position, DbType.String, ParameterDirection.Input);

                oSql.Execute("Fantasy_InsertPlayer", oParameters, commandType: CommandType.StoredProcedure);
            }
        }

        //Select Player
        public static Player.PlayerData GetPlayerDataBySleeperId(long lSleeperPlayerId)
        {
            using (IDbConnection oSql = DatabaseHelper.CreateSqlConnection())
            {
                DynamicParameters oParameters = new DynamicParameters();
                oParameters.Add("@in_SleeperId", lSleeperPlayerId, DbType.Int64, ParameterDirection.Input);
                
                return oSql.Query<Player.PlayerData>("Fantasy_SelectPlayerBySleeperId", oParameters,commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public static List<Player.PlayerData> GetAllPlayerData()
        {
            using (IDbConnection oSql = DatabaseHelper.CreateSqlConnection())
            {
                return oSql.Query<Player.PlayerData>("Fantasy_SelectPlayerBySleeperId", commandType: CommandType.StoredProcedure).ToList();
            }
        }



    }
}
