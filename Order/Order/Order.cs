class Order : IOrder
{
  public DateTime StartTime { get ; set ; }
  public DateTime FinishTime { get ; set ; }
  public int RoomId { get ; set ; }
  public string EventName { get ; set ; }
  public int Status { get ; set ; }
  public string UserName { get ; set; }
  public string RoomName { get; set; }
}
