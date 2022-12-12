class Meneger : IMeneger
{
  public User user { get; set; }
  public FrontEnd frontEnd { get; set; }
  public SqlConnection SqlConnection { get; set; }
  public void AdminEssign()
  {
   frontEnd.AdminEssign();
  }

  public void CreateAccaunt()
  {
    user = frontEnd.CreateAccaunt();
  }

  public void CreateOrder()
  {
    frontEnd.CreateOrder();
  }

  public void EventEssign()
  {
   frontEnd.EventEssign();
  }

  public void GetAccaunt()
  {
    user = frontEnd.GetAccaunt();
  }

  public void GetEvents()
  {
   frontEnd.GetEvents();
  }

  public void OrderEventCapasity()
  {
   frontEnd.OrderEventCapasity();
  }

  public void StartProgram()
  {
    frontEnd.HeadMenu();
  }
}
