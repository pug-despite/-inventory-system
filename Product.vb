' Product.vb

Public Class Product
    Public Property ProductId As Integer
    Public Property Name As String
    Public Property Price As Decimal
    Public Property Category As Category

    Public Sub DisplayInfo()
        Console.WriteLine($"Product ID: {ProductId}")
        Console.WriteLine($"Name: {Name}")
        Console.WriteLine($"Price: {Price:C}")
        Category.DisplayInfo()
    End Sub
End Class
