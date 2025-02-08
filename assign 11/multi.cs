using System;
// Base class representing an Order
public class Order
{
public int OrderId { get; set; }
public string OrderDate { get; set; }
public Order(int orderId, string orderDate)
{
OrderId = orderId;
OrderDate = orderDate;
}
// Virtual method to be overridden in subclasses
public virtual string GetOrderStatus()
{
return "Order placed";
}
}
// Subclass ShippedOrder
public class ShippedOrder : Order
{
public string TrackingNumber { get; set; }
public ShippedOrder(int orderId, string orderDate, string
trackingNumber) : base(orderId, orderDate)
{
TrackingNumber = trackingNumber;
}
public override string GetOrderStatus()
{
return "Order shipped with tracking number: " + TrackingNumber;
}
}
// Subclass DeliveredOrder
public class DeliveredOrder : ShippedOrder
{
public string DeliveryDate { get; set; }
public DeliveredOrder(int orderId, string orderDate, string
trackingNumber, string deliveryDate)
: base(orderId, orderDate, trackingNumber)
{
DeliveryDate = deliveryDate;
}
public override string GetOrderStatus()
{
return "Order delivered on: " + DeliveryDate;
}
}
// Main Program
public class Program
{
public static void Main()
{
Order order = new Order(1001, "2025-02-06");
Console.WriteLine(order.GetOrderStatus());
ShippedOrder shippedOrder = new ShippedOrder(1002, "2025-02-05",
"XYZ123456");
Console.WriteLine(shippedOrder.GetOrderStatus());
DeliveredOrder deliveredOrder = new DeliveredOrder(1003,
"2025-02-04", "ABC789101", "2025-02-07");
Console.WriteLine(deliveredOrder.GetOrderStatus());
}
}
