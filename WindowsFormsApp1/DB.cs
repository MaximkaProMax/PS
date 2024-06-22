using MySql.Data.MySqlClient; //Библиотека клиента SQL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=database"); //Новое подключение к БД (Название сервера, порт, имя, пароль, БД)

        public void openConnection() //Подкл
        {
            if (connection.State == System.Data.ConnectionState.Closed) //Если не подкл к БД (Closed)
                connection.Open(); //То подкл к БД (Open)        
        }

        public void closeConnection() //Откл
        {
            if (connection.State == System.Data.ConnectionState.Open) //Если подкл к БД (Open)
                connection.Close(); //То откл к БД (Close)        
        }

        public MySqlConnection getConnection() //Какое соединение/БД
        {
            return connection; //Вернуть соединение
        }
    }
}