Imports System
Imports System.Collections.Generic

Namespace CustomParametersExample
    Public Class Invoices
        Private Shared rnd As New Random()
        Public Property Country() As String
        Public Property City() As String
        Public Property ProductName() As String
        Public Property OrderDate() As Date
        Public Property Quantity() As Integer
        Public Property Discount() As Double
        Public Property ExtendedPrice() As Double
        Public Property Freigth() As Double
        Public Property UnitPrice() As Double

        Public Shared Function CreateData() As List(Of Invoices)
            Dim data As New List(Of Invoices)()
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Aachen", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 30, _
                .Discount = 0, _
                .ExtendedPrice = 1650, _
                .Freigth = 149.47, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Berlin", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 15, _
                .Discount = 0, _
                .ExtendedPrice = 825, _
                .Freigth = 69.53, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Brandenburg", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 61, _
                .Discount = 0, _
                .ExtendedPrice = 2959, _
                .Freigth = 42.33, _
                .UnitPrice = 99 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Brandenburg", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 24, _
                .Discount = 0, _
                .ExtendedPrice = 1320, _
                .Freigth = 29.59, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Cunewalde", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 55, _
                .Discount = 0.1, _
                .ExtendedPrice = 1346.4, _
                .Freigth = 183.17, _
                .UnitPrice = 27.2 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Cunewalde", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 139, _
                .Discount = 0.2, _
                .ExtendedPrice = 4204.1, _
                .Freigth = 568.62, _
                .UnitPrice = 68 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Cunewalde", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 49, _
                .Discount = 0.25, _
                .ExtendedPrice = 1249.5, _
                .Freigth = 31.89, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Cunewalde", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 70, _
                .Discount = 0, _
                .ExtendedPrice = 3850, _
                .Freigth = 401.88, _
                .UnitPrice = 110 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Frankfurt a.M.", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 20, _
                .Discount = 0.25, _
                .ExtendedPrice = 408, _
                .Freigth = 76.56, _
                .UnitPrice = 27.2 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Frankfurt a.M.", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 35, _
                .Discount = 0.25, _
                .ExtendedPrice = 892.5, _
                .Freigth = 58.88, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Frankfurt a.M.", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 25, _
                .Discount = 0, _
                .ExtendedPrice = 1375, _
                .Freigth = 91.28, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Cologne", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 30, _
                .Discount = 0, _
                .ExtendedPrice = 1020, _
                .Freigth = 145.63, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Leipzig", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 12, _
                .Discount = 0, _
                .ExtendedPrice = 660, _
                .Freigth = 127.34, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Mannheim", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 21, _
                .Discount = 0, _
                .ExtendedPrice = 714, _
                .Freigth = 31.14, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Munich", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 70, _
                .Discount = 0.15, _
                .ExtendedPrice = 2618, _
                .Freigth = 208.58, _
                .UnitPrice = 44 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Munich", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 30, _
                .Discount = 0, _
                .ExtendedPrice = 1320, _
                .Freigth = 4.93, _
                .UnitPrice = 44 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Munich", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 20, _
                .Discount = 0.1, _
                .ExtendedPrice = 612, _
                .Freigth = 93.25, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "Germany", _
                .City = "Munich", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 36, _
                .Discount = 0.05, _
                .ExtendedPrice = 1162.8, _
                .Freigth = 242.95, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Albuquerque", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 60, _
                .Discount = 0, _
                .ExtendedPrice = 2640, _
                .Freigth = 708.95, _
                .UnitPrice = 44 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Albuquerque", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 21, _
                .Discount = 0, _
                .ExtendedPrice = 571.2, _
                .Freigth = 147.26, _
                .UnitPrice = 27.2 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Albuquerque", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 2, _
                .Discount = 0.06, _
                .ExtendedPrice = 63.92, _
                .Freigth = 8.53, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Anchorage", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 8, _
                .Discount = 0, _
                .ExtendedPrice = 440, _
                .Freigth = 135.63, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Boise", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 40, _
                .Discount = 0.15, _
                .ExtendedPrice = 1496, _
                .Freigth = 214.27, _
                .UnitPrice = 44 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Boise", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 7, _
                .Discount = 0, _
                .ExtendedPrice = 385, _
                .Freigth = 8.19, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Boise", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 100, _
                .Discount = 0.25, _
                .ExtendedPrice = 4125, _
                .Freigth = 830.75, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Boise", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 70, _
                .Discount = 0, _
                .ExtendedPrice = 2380, _
                .Freigth = 896.77, _
                .UnitPrice = 68 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Boise", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 45, _
                .Discount = 0.2, _
                .ExtendedPrice = 1224, _
                .Freigth = 487.57, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Eugene", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 30, _
                .Discount = 0.15, _
                .ExtendedPrice = 1402.5, _
                .Freigth = 18.53, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Eugene", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 15, _
                .Discount = 0, _
                .ExtendedPrice = 510, _
                .Freigth = 14.01, _
                .UnitPrice = 34 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Lander", _
                .ProductName = "Camembert Pierrot", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 20, _
                .Discount = 0.2, _
                .ExtendedPrice = 435.2, _
                .Freigth = 30.96, _
                .UnitPrice = 27.2 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Portland", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 1, _
                .Discount = 0, _
                .ExtendedPrice = 55, _
                .Freigth = 26.31, _
                .UnitPrice = 55 _
            })
            data.Add(New Invoices With { _
                .Country = "USA", _
                .City = "Seattle", _
                .ProductName = "Raclette Courdavault", _
                .OrderDate = GenerateOrderDate(), _
                .Quantity = 30, _
                .Discount = 0, _
                .ExtendedPrice = 1650, _
                .Freigth = 606.19, _
                .UnitPrice = 55 _
            })
            Return data
        End Function

        Private Shared Function GenerateOrderDate() As Date
            Dim startYear As Integer = Date.Today.Year - 3
            Dim endYear As Integer = Date.Today.Year
            Return New Date(rnd.Next(startYear, endYear), rnd.Next(1, 13), rnd.Next(1, 29))
        End Function
    End Class
End Namespace