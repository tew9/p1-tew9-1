using System;
using System.Collections.Generic;
using System.Linq;


namespace PizzaBox.Domain.Models
{
  public class Order
  {
   
   public long orderId { get; set; }
  
   public DateTime orderTime { get; set; }

  //Get the total price of the Order.
   public decimal totPrice {get; set; }
   
   #region Navigational Properties.
        public List<PizzaOrder> PizzaOrders {get; set; }
         //public List<StoreOrders> StoreOrders { get; set; }
       public long UserId {get; set; }
        public User User { get; set; }
   #endregion

    public Order()
    {
     // orderId = DateTime.Now.Ticks;
      orderTime = DateTime.Now;
      PizzaOrders = new List<PizzaOrder>();
    }
  }
}