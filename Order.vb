' Order.vb

Public Class Order
    Public Property OrderId As Integer
    Public Property Product As Product
    Public Property Quantity As Integer

    Public Sub DisplayInfo()
        Console.WriteLine($"Order ID: {OrderId}")
        Product.DisplayInfo()
        Console.WriteLine($"Quantity: {Quantity}")
    End Sub
End Class
