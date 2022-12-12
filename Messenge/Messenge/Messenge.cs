class Messenge : IMessenge
{
  public int SendUserId { get ; set ; }
  public int ReceiveUserId { get ; set ; }
  public DateTime MessengeTime { get ; set ; }
  public string Text { get ; set ; }
  public int ViewMessenge { get ; set ; }
}
