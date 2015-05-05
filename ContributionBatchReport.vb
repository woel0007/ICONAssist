Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Web.Script.Serialization
Imports System.Collections.Generic
Imports System.Windows.Forms


Public Class ContributionBatchReport

    Public Function showData() As String Handles Me.Load

        Dim batchDict As Dictionary(Of String, Object) = getRawContributionData(10000)

        Dim contributionDict As New Dictionary(Of String, ContributionBatch)
        For i As Integer = 0 To batchDict("posted").Count - 1
            Try
                Dim dateGiven As String = batchDict("posted")(i)("date_given")
                Dim amountGiven As Double = CDbl(batchDict("posted")(i)("amount"))
            Catch ex As Exception
                MsgBox(ex)
            End Try

            'If contributionDict.ContainsKey(dateGiven) Then
            '    Dim amount As Double = contributionDict(dateGiven).amountGiven
            '    contributionDict(dateGiven).amountGiven = contributionDict(dateGiven).amountGiven + amountGiven
            'Else
            '    Try
            '        Dim cb As New ContributionBatch(dateGiven, amountGiven)
            '        contributionDict.Add(dateGiven, cb)
            '    Catch ex As Exception
            '        MsgBox(ex)
            '    End Try

            'End If
        Next

        MsgBox(batchDict.Count.ToString)
        Return "Yep"

    End Function


    Public Function getRawContributionData(maxRecordsReturned As Integer) As Dictionary(Of String, Object)

        Dim jsonString = "{""Auth"": { ""Session"" : """ + iconCMOAssist.AuthForm.Globals.authSession + """},""Request"": { ""Module"": ""contributions"", ""Section"": ""posted"", ""Filters"": {""begin_date"": ""January 1, 2015"", ""end_date"": ""December 31, 2015"", ""limit"": " + maxRecordsReturned.ToString + " }}}"
        Dim batchDict As Dictionary(Of String, Object) = iconCMOAssist.AuthForm.iCMO_Request(jsonString)

        Return batchDict

    End Function



End Class