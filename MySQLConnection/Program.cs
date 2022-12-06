using MySql.Data.MySqlClient;
using System;


string conStr ="server =localhost; uid = root; password= root; database=classicmodels";

MySqlConnection con = new MySqlConnection();


try{

    con.ConnectionString=conStr;
    con.Open();
    string query ="SELECT * FROM  CUSTOMERS";
    MySqlCommand cmd = new MySqlCommand(query, con);
    MySqlDataReader rdr= cmd.ExecuteReader();
    while (rdr.Read())
    {
        System.Console.WriteLine(rdr[0]+"---"+rdr[1]+"---");
    }
    rdr.Close();
}
catch(Exception ee)
{
    System.Console.WriteLine(ee.Message);
}
finally
{
    con.Clone();
}
