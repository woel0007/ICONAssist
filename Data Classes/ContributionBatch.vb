Imports System.Collections.Generic

Public Class ContributionBatch

    'Property batchID As String
    Property postedDate As String
    Private Property _totalAmountGiven As Double

    Property fundList As New List(Of ContributionFund)

    Public Sub New(ByVal postDate As String)
        postedDate = postDate

    End Sub

    Public Sub addAmountGiven(amtGiven As Double)

        _totalAmountGiven = _totalAmountGiven + amtGiven

    End Sub

    Public Function getAmountGiven() As Double

        Return _totalAmountGiven

    End Function

    Public Sub addAmountToFund(fundID As String, fundName As String, amtGiven As Double)

        Dim fundAlreadyExists As Boolean = False
        'Dim f As New ContributionFund(fundID)

        'Check if fund exists in list already, if so add amount.
        For Each fund As ContributionFund In Me.fundList
            If fund.getName() = fundName Then
                fund.addAmountGiven(amtGiven)
                fundAlreadyExists = True
            End If
        Next

        If Not fundAlreadyExists Then
            Dim newFund As New ContributionFund(fundID, fundName, amtGiven)
            'newFund.addAmountGiven(amtGiven)
            fundList.Add(newFund)
        End If



    End Sub

End Class
