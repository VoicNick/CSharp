using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableGenerator
{
    class DbUtilities
    {
        // formatted this way for clarity of demonstration
        private static string connString = "Server=tcp:s08.winhost.com;"
                                         + "Database=DB_15202_2614d162;"
                                         + "User ID=DB_15202_2614d162_user;"
                                         + "Password=93nu5#S67;"
                                         + "Integrated Security=False;";

        public static void GenerateTable(string tableName)
        {         
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string fullTableName = string.Format("[dbo].[{0}]", tableName);
                string fullKeyName = string.Format("[PK_{0}]", tableName);
                    
                // embedded SQL
                string query = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19}"
                                        , "USE [DB_15202_2614d162]"
                                        , "SET ANSI_NULLS ON"
                                        , "SET QUOTED_IDENTIFIER ON"
                                        , "CREATE TABLE ", fullTableName, " ([ClientCode] [nchar](5) NOT NULL,	[CompanyName] [nvarchar](40) NOT NULL,"
	                                    , "[Address1] [nvarchar](60) NOT NULL,	[Address2] [nvarchar](60) NULL,	[City] [nvarchar](20) NULL,"
	                                    , "[Province] [nvarchar](10) NOT NULL, [PostalCode] [nvarchar](10) NULL, [YTDSales] [decimal](18, 2) NOT NULL,"
                                        , "[CreditHold] [tinyint] NOT NULL, [Notes] [nvarchar](max) NULL,"
                                        , "CONSTRAINT ", fullKeyName, " PRIMARY KEY CLUSTERED" 
                                        , "([ClientCode] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY])"
                                        , "ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
                                        , "INSERT INTO ", fullTableName, " ([ClientCode], [CompanyName], [Address1], [Address2], [City], [Province], [PostalCode], [YTDSales], [CreditHold], [Notes]) VALUES (N'AROUT', N'Around the Horn', N'120 Hanover Sq.', NULL, N'London', N'ON', N'L4N 7G5', CAST(1500.00 AS Decimal(18, 2)), 1, null)"
                                        , "INSERT INTO ", fullTableName, " ([ClientCode], [CompanyName], [Address1], [Address2], [City], [Province], [PostalCode], [YTDSales], [CreditHold], [Notes]) VALUES (N'BOTTM', N'Bottom-Dollar Markets', N'23 Tsawassen Blvd.', NULL, N'Tsawassen', N'BC', N'V2R 7A6', CAST(4689.24 AS Decimal(18, 2)), 0, N'Longest standing customer')"
                                        );

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }        
        }
    }
}
