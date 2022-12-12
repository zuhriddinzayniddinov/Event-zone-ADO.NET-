interface IFrontEnd
{
  public string[] HeadMenus { get; set; }
  public string[] SingUp { get; set; }
  public string[] SingIn { get; set; }
  public string[] CreateOrders { get; set; }
  public string[] CreateOrderCapasity { get; set; }
  public string[] EventEssigns { get; set; }
  public string[] AdminEssigns { get; set; }
  public void HeadMenu();
  public User CreateAccaunt();
  public User GetAccaunt();
  public void CreateOrder();
  public void OrderEventCapasity();
  public void GetEvents();
  public void EventEssign();
  public void AdminEssign();
}