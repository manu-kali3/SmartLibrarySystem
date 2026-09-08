Imports SmartLibrarySystem.Models

' Task 5: Application Logic
' A shared helper module for date/fine calculations shared across the app.
Public Module LibraryLogic

    Public Const BorrowPeriodDays As Integer = 7
    Public Const FinePerDay As Decimal = 10D ' Ksh. 10 per day overdue

    ' Function: calculate the number of days a book has been borrowed.
    Public Function CalculateDaysBorrowed(borrowDate As Date) As Integer
        Return (Date.Today.Date - borrowDate.Date).Days
    End Function

    ' Function: calculate the expected return date (borrow date + 7 days).
    Public Function GetExpectedReturnDate(borrowDate As Date) As Date
        Return borrowDate.Date.AddDays(BorrowPeriodDays)
    End Function

    ' Function: calculate the number of days overdue (0 if not overdue).
    Public Function CalculateDaysOverdue(returnDate As Date, Optional actualReturnDate As Date? = Nothing) As Integer
        If actualReturnDate.HasValue Then
            Dim overdue As Integer = (actualReturnDate.Value.Date - returnDate.Date).Days
            Return If(overdue < 0, 0, overdue)
        End If
        Dim daysPast As Integer = (Date.Today.Date - returnDate.Date).Days
        Return If(daysPast < 0, 0, daysPast)
    End Function

    ' Function: calculate the fine based on days overdue (Ksh. 10 per day).
    Public Function CalculateFine(daysOverdue As Integer) As Decimal
        Return daysOverdue * FinePerDay
    End Function

    ' Function: return a status message ("On Time" / "Overdue").
    Public Function GetBorrowStatus(returnDate As Date, Optional actualReturnDate As Date? = Nothing) As String
        If CalculateDaysOverdue(returnDate, actualReturnDate) > 0 Then
            Return "Overdue"
        End If
        Return "On Time"
    End Function

    ' Loop through borrowed books to calculate total fines.
    Public Function CalculateTotalFines(books As IEnumerable(Of BorrowedBook)) As Decimal
        Dim total As Decimal = 0D
        For Each bb As BorrowedBook In books
            total += bb.Fine
        Next
        Return total
    End Function

    ' Average borrowing time in days per student.
    Public Function CalculateAverageBorrowingTimePerStudent(borrows As IEnumerable(Of BorrowedBook)) As Double
        Dim list As List(Of BorrowedBook) = borrows.ToList()
        If list.Count = 0 Then
            Return 0.0
        End If
        Dim totalDays As Double = 0.0
        For Each bb In list
            totalDays += If(bb.ActualReturnDate.HasValue,
                            (bb.ActualReturnDate.Value.Date - bb.BorrowDate.Date).TotalDays,
                            (Date.Today.Date - bb.BorrowDate.Date).TotalDays)
        Next
        Return Math.Round(totalDays / list.Count, 2)
    End Function

End Module