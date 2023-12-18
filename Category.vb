' Category.vb

Public Class Category
    Public Property CategoryId As Integer
    Public Property Name As String

    Public Sub DisplayInfo()
        Console.WriteLine($"Category ID: {CategoryId}")
        Console.WriteLine($"Name: {Name}")
    End Sub
End Class
