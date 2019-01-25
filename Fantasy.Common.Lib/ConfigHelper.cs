using System.Linq;
using Fantasy.Objects.Lib;
using Dapper;
using System.Data;
using System;
using System.Data.SqlClient; 

namespace Fantasy.Common.Lib
{
    public static class ConfigHelper
    {
        public static Configs GetConfigByName(string szConfigName)
        {

            using (IDbConnection oSql = DatabaseHelper.CreateSqlConnection())
            {
                DynamicParameters oParameters = new DynamicParameters();
                oParameters.Add("@in_ConfigName", szConfigName, DbType.String, ParameterDirection.Input);
                
                return oSql.Query<Configs>("Fantasy_GetConfigByName", oParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public static void UpdateConfig(Configs oConfigData)
        {
            using (IDbConnection oSql = DatabaseHelper.CreateSqlConnection())
            {
                DynamicParameters oParameters = new DynamicParameters();
                oParameters.Add("@in_ConfigId", oConfigData.ConfigId, DbType.Int32, ParameterDirection.Input);
                oParameters.Add("@in_ConfigValue", oConfigData.Value, DbType.String, ParameterDirection.Input);
                oParameters.Add("@in_ModTime", DateTime.Now, DbType.DateTime, ParameterDirection.Input);

                oSql.Execute("Fantasy_UpdateConfig", oParameters, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
