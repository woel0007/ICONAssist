Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Web.Script.Serialization
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data


Public Class ContributionBatchReport

    Public Function showData() As Dictionary(Of String, ContributionBatch) Handles Me.Load

        Dim countAllRecords As Integer = 1  'Default to larger than zero to ensure loop runs at least once.
        Dim startRecordNumber As Integer = 0
        Dim recordsReturned As Integer = 0
        Dim contributionDict As New Dictionary(Of String, ContributionBatch)

        While startRecordNumber < countAllRecords

            Dim batchDict As Dictionary(Of String, Object) = getRawContributionData(startRecordNumber)
            recordsReturned = batchDict("posted").Count
            countAllRecords = batchDict("statistics")("records")

            For i As Integer = 0 To batchDict("posted").Count - 1
                Dim dateGiven As String = batchDict("posted")(i)("date_given")
                Dim amountGiven As Double = CDbl(batchDict("posted")(i)("amount"))
                Dim fundID As String = batchDict("posted")(i)("fund_id")
                Dim fundName As String = batchDict("posted")(i)("fund_name")

                'If we've already read a record for this batch
                If contributionDict.ContainsKey(dateGiven) Then
                    contributionDict(dateGiven).addAmountGiven(amountGiven)
                    contributionDict(dateGiven).addAmountToFund(fundID, fundName, amountGiven)
                Else
                    Dim cb As New ContributionBatch(dateGiven)
                    cb.addAmountGiven(amountGiven)
                    cb.addAmountToFund(fundID, fundName, amountGiven)
                    contributionDict.Add(dateGiven, cb)
                End If
            Next
            startRecordNumber = startRecordNumber + recordsReturned
        End While


        For Each batchDate As String In contributionDict.Keys
            File.AppendAllText("C:\temp\churchbatches.txt", String.Format("Posted Date: {0}   Total Amount Given: ${1} " + vbNewLine, batchDate, contributionDict(batchDate).getAmountGiven().ToString))
            For Each fund In contributionDict(batchDate).fundList
                File.AppendAllText("C:\temp\churchbatches.txt", String.Format("     Fund Name: {0}    ${1}" + vbNewLine, fund.getName, fund.getAmountGiven().ToString))
            Next
            File.AppendAllText("C:\temp\churchbatches.txt", vbNewLine)
        Next

        Return contributionDict

    End Function


    Public Function getRawContributionData(startAt As Integer) As Dictionary(Of String, Object)

        Dim jsonString = "{""Auth"": { ""Session"" : """ + iconCMOAssist.AuthForm.Globals.authSession + """},""Request"": { ""Module"": ""contributions"", ""Section"": ""posted"", ""Filters"": {""begin_date"": ""January 1, 2015"", ""end_date"": ""December 31, 2015"", ""startAt"": " + startAt.ToString + ", ""limit"": ""1000"" }}}"
        Dim batchDict As Dictionary(Of String, Object) = iconCMOAssist.AuthForm.iCMO_Request(jsonString)

        Return batchDict

    End Function



End Class