Public Class ContributionBatch

    'Property batchID As String
    Property postedDate As String
    Property amountGiven As Double

    Public Sub New(ByVal postDate As String, ByVal amntGiven As Double)
        postedDate = postDate
        amountGiven = amntGiven
    End Sub

End Class
