using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace TestDataBase.Controller
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;

        public Query(string connectionString)
        {
            connection = new OleDbConnection(connectionString);
        }

        public void Add(int kod, string name, string surname, string position)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Сотрудники ([Код сотрудника], Имя, Фамилия, Должность) " +
                "VALUES('" + kod + "','" + name + "','" + surname + "','" + position + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delite(int kod)
        {
            connection.Open();
            command = new OleDbCommand("DELETE FROM Сотрудники WHERE [Код сотрудника] = " + kod, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void ChangePosition(int kod, string newPosition) 
        {
            connection.Open();
            command = new OleDbCommand("UPDATE Сотрудники SET Должность ='" + newPosition + 
                "' WHERE [Код сотрудника] = " + kod, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
