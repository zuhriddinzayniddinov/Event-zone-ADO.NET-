interface ISqlConnection
{
  public string Database { get; }
  public User GetUser(string PhoneNumber,string Password);
  public User CreateUser(User user,string password);
  public void BrounRoom(User user,Order order);
  public void SendMesseng(Messenge messenge);
  public List<Messenge> ViewMessenge(int UserId);
  public void BrounRoomPlace(int EventId,User user);
  public List<Order> GetEvents(); 
  public void CreateRoom(Room room);
  public List<Room> GetRoom();
}