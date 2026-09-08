Namespace Models

    Public Class BorrowedBook

        Public Property BorrowID As Integer
        Public Property AdmissionNo As String
        Public Property BookID As Integer
        Public Property Issuer As String
        Public Property BorrowDate As Date
        Public Property ReturnDate As Date
        Public Property TimeBorrowed As String
        Public Property Returned As Boolean
        Public Property ActualReturnDate As Date?

        ' Joined fields for display (from Books and Members)
        Public Property BookTitle As String
        Public Property StudentName As String

        ' Derived / computed values
        Public ReadOnly Property DaysBorrowed As Integer
            Get
                Return (Date.Today - BorrowDate).Days
            End Get
        End Property

        Public ReadOnly Property DaysOverdue As Integer
            Get
                Dim overdue As Integer = (Date.Today - ReturnDate).Days
                If overdue < 0 Then
                    Return 0
                End If
                If Returned AndAlso ActualReturnDate.HasValue Then
                    overdue = (ActualReturnDate.Value.Date - ReturnDate).Days
                End If
                Return If(overdue < 0, 0, overdue)
            End Get
        End Property

        Public ReadOnly Property Fine As Decimal
            Get
                ' Ksh. 10 per day overdue
                Return DaysOverdue * 10D
            End Get
        End Property

        Public ReadOnly Property Status As String
            Get
                If Returned Then
                    Dim overdue As Integer = DaysOverdue
                    Return If(overdue > 0, "Overdue (Returned)", "On Time (Returned)")
                End If
                Return If(DaysOverdue > 0, "Overdue", "On Time")
            End Get
        End Property

    End Class

End Namespace
