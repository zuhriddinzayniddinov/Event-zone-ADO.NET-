interface IFrontEnd
{
  public string[] HeadMenu { get; set; }
  public string[] SingUp { get; set; }
  public string[] SingIn { get; set; }
  public string[] CreateOrders { get; set; }
  public string[] CreateOrderCapasity { get; set; }
  public string[] EventEssigns { get; set; }
  public string[] AdminEssigns { get; set; }
  public void CreateAccaunt();
  public void GetAccaunt();
  public void CreateOrder();
  public void OrderEventCapasity();
  public void GetEvents();
  public void EventEssign();
  public void AdminEssign();
}