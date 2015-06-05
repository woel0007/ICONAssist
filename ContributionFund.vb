Imports System.Collections.Generic

Public Class ContributionFund

    Private Property _fundID As String
    Private Property _fundName As String

    Private Property _amountGiven As Double

    Public Sub New(fundID, fundName)

        _fundID = fundID
        _fundName = fundName

    End Sub

    Public Sub New(fundID, fundName, amountGiven)

        _fundID = fundID
        _fundName = fundName
        _amountGiven = amountGiven

    End Sub

    Public Sub addAmountGiven(amtGiven As Double)

        _amountGiven = _amountGiven + amtGiven

    End Sub

    Public Function getAmountGiven() As Double

        Return _amountGiven

    End Function

    Public Function getName() As String

        Return _fundName

    End Function



End Class
