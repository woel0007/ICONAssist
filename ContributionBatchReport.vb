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

        Dim batchDict As Dictionary(Of String, Object) = getRawContributionData(10000)

        Dim contributionDict As New Dictionary(Of String, ContributionBatch)
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

        'Dim dt As New DataTable
        ''Dim dr As New DataRow

        'Dim dateColumn As New DataColumn("Date Given", Type.GetType("System.String"))
        'Dim amountColumn As New DataColumn("Amount", Type.GetType("System.Double"))

        'dt.Columns.Add(dateColumn)
        'dt.Columns.Add(amountColumn)

        For Each batchDate As String In contributionDict.Keys
            File.AppendAllText("C:\temp\churchbatches.txt", String.Format("Posted Date: {0}   Total Amount Given: ${1} " + vbNewLine, batchDate, contributionDict(batchDate).getAmountGiven().ToString))
            For Each fund In contributionDict(batchDate).fundList
                File.AppendAllText("C:\temp\churchbatches.txt", String.Format("     Fund Name: {0}    ${1}" + vbNewLine, fund.getName, fund.getAmountGiven().ToString))
            Next
            File.AppendAllText("C:\temp\churchbatches.txt", vbNewLine)
        Next

        Return contributionDict

    End Function


    Public Function getRawContributionData(maxRecordsReturned As Integer) As Dictionary(Of String, Object)

        Dim jsonString = "{""Auth"": { ""Session"" : """ + iconCMOAssist.AuthForm.Globals.authSession + """},""Request"": { ""Module"": ""contributions"", ""Section"": ""posted"", ""Filters"": {""begin_date"": ""January 1, 2015"", ""end_date"": ""December 31, 2015"", ""limit"": " + maxRecordsReturned.ToString + " }}}"
        Dim batchDict As Dictionary(Of String, Object) = iconCMOAssist.AuthForm.iCMO_Request(jsonString)

        Return batchDict

    End Function



End Class