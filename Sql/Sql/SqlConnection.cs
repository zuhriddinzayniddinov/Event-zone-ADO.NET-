using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
class SqlConnection : ISqlConnection
{
  public string Database { get; } = @"Server=DESKTOP-6661VFP; Database=MessengerProg; Trusted_Connection=True; MultipleActiveResultSets=true;";
  public void BrounRoom(User user, Order order)
  {
    using (var connection = new SqlConnection(Database))
    {
      string query = 
          $"EXECUTE [CreateOrders] {user.Id},'{order.StartTime}','{order.FinishTime}',{order.RoomId},'{order.EventName}'";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();
    }
  }

  public void BrounRoomPlace(int EventId, User user)
  {
    using (var connection = new SqlConnection(Database))
    {
      // hali chala
      string query = 
          $"";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();
    }
  }

  public void CreateRoom(Room room)
  {
    using (var connection = new SqlConnection(Database))
    {
      string query = 
          $"EXECUTE [CreateRoom] N'{room.RoomName}',{room.Capasity}";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();
    }
  }

  public User CreateUser(User user,string password)
  {
    using (var connection = new SqlConnection(Database))
    {
      string query = 
          $"EXECUTE [CreateAccaunt] N'{user.FirstName}',N'{user.LastName}',N'{user.PhoneNumber}',N'{password}',{1}";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();

      while (dataReader.Read())
      {
        user = new User
        {
          Id = (int)dataReader["id"],
          FirstName = (string)dataReader["FirstName"],
          LastName = (string)dataReader["LastName"],
          PhoneNumber = (string)dataReader["PhoneNumber"],
          Roll = (int)dataReader["Roll"]
        };
      }
      return user;
    }
  }

  public List<Order> GetEvents()
  {
    using (var connection = new SqlConnection(Database))
    {
      string query = 
          $"EXECUTE [GetOrders] N'{DateTime.Now}'";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();
      List<Order> orders = new List<Order>();
      while (dataReader.Read())
      {
        orders.Add(new Order
        {
            RoomName = (string)dataReader["RoomName"],
            UserName = (string)dataReader["FirstName"],
            StartTime = (DateTime)dataReader["StartTime"],
            EventName = (string)dataReader["EventName"]

        });
      }
      return orders;
    }

  }

  public List<Room> GetRoom()
  {
    using (var connection = new SqlConnection(Database))
    {
      string query = 
          $"EXECUTE [GetRoom]";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();
      List<Room> rooms = new List<Room>();
      while (dataReader.Read())
      {
        rooms.Add(new Room
        {
          Id = (int)dataReader["id"],
          RoomName = (string)dataReader["RoomName"],
          Capasity = (int)dataReader["Capasity"]
        });
      }
      return rooms;
    }
  }

  public User GetUser(string PhoneNumber, string Password)
  {
    using (var connection = new SqlConnection(Database))
    {
      string query = 
          $"EXECUTE [GetAccaunt] N'{PhoneNumber}',N'{Password}'";

      SqlCommand command = new SqlCommand(query, connection);

      connection.Open();

      SqlDataReader dataReader = command.ExecuteReader();
      User user = new User();
      while (dataReader.Read())
      {
        user = new User
        {
          Id = (int)dataReader["id"],
          FirstName = (string)dataReader["FirstName"],
          LastName = (string)dataReader["LastName"],
          PhoneNumber = (string)dataReader["PhoneNumber"],
          Roll = (int)dataReader["Roll"]
        };
      }
      return user;
    }
  }

  public void SendMesseng(Messenge messenge)
  {
    throw new NotImplementedException();
  }

  public List<Messenge> ViewMessenge(int UserId)
  {
    throw new NotImplementedException();
  }
}