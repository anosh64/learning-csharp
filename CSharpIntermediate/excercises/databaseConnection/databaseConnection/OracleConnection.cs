using System;
using databaseConnection;

public class OracleConnection : DBConnection
{


    public override void OpenConnection()
    {
        Console.WriteLine("connected to oracle database");
    }        
    public override void CloseConnection()
    {
        Console.WriteLine("connection closed!");
    }
}