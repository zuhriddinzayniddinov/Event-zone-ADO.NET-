class FrontEnd : IFrontEnd
{
  public FrontEnd()
  {
    this.HeadMenu = new string[]{" 1.SignUp "," 2.SignIn ", " 3.Exit "};
    this.SingIn = new string[]{" PhoneNumber: "," Password: "};
    this.SingUp = new string[]{" FirstName: "," LastName: "," PhoneNumber: "," Password: "};
    this.CreateOrders = new string[]{" Start Time: "," Finish Time: "," Room number: "," Event of name: "};
    this.CreateOrderCapasity = new string[]{" Event Number: "," Capasity Number: "};
    this.EventEssigns = new string[]{};
    this.AdminEssigns = new string[]{" User number: "};
  }

  public string[] HeadMenu { get; set; }
  public string[] SingUp { get; set; }
  public string[] SingIn { get; set; }
  public string[] CreateOrders { get; set; }
  public string[] CreateOrderCapasity { get; set; }
  public string[] EventEssigns { get; set; }
  public string[] AdminEssigns { get; set; }

  public void AdminEssign()
  {
    
  }

  public void CreateAccaunt()
  {
    
  }

  public void CreateOrder()
  {
    
  }

  public void EventEssign()
  {
    
  }

  public void GetAccaunt()
  {
    
  }

  public void GetEvents()
  {
    
  }

  public void OrderEventCapasity()
  {
    
  }
}