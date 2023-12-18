' InventorySystem.vb

Module InventorySystem
    Sub Main()
        ' Create categories
        Dim category1 As New Category With {.CategoryId = 1, .Name = "Electronics"}
        Dim category2 As New Category With {.CategoryId = 2, .Name = "Clothing"}

        ' Create products
        Dim product1 As New Product With {.ProductId = 101, .Name = "Laptop", .Price = 800.0, .Category = category1}
        Dim product2 As New Product With {.ProductId = 102, .Name = "T-Shirt", .Price = 20.0, .Category = category2}

        ' Create orders
        Dim order1 As New Order With {.OrderId = 1001, .Product = product1, .Quantity = 2}
        Dim order2 As New Order With {.OrderId = 1002, .Product = product2, .Quantity = 5}

        ' Display information
        Console.WriteLine("Order Information:")
        order1.DisplayInfo()
        Console.WriteLine()
        order2.DisplayInfo()
    End Sub
End Module
