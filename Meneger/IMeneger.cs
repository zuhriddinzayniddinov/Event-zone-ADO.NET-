interface IMeneger
{
  public User user{get;set;}
  public FrontEnd frontEnd { get; set; }
  public SqlConnection SqlConnection { get; set; }
  public void StartProgram();
  public void CreateAccaunt();
  public void GetAccaunt();
  public void CreateOrder();
  public void OrderEventCapasity();
  public void GetEvents();
  public void EventEssign();
  public void AdminEssign();
}