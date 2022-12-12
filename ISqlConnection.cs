interface ISqlConnection
{
  public string Database { get; set; }
  public User GetUser(string PhoneNumber,string Password);
  public User CreateUser(User user);
  public void BrounRoom(User user,Order order);
  public void SendMesseng(Messenge messenge);
  public List<Messenge> ViewMessenge(int UserId);
  public void BrounRoomPlace(int EventId,User user);
  public List<Event> GetEvents();
}