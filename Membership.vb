Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Web.Script.Serialization
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class formMembership

    Private Sub btnGetMembers_Click(sender As Object, e As EventArgs) Handles btnGetMembers.Click

        Dim jsonString = "{""Auth"": { ""Session"" : """ + iconCMOAssist.AuthForm.Globals.authSession + """},""Request"": { ""Module"": ""membership"", ""Section"": ""members"", ""Filters"": {""startAt"": 0,""limit"": 100 },""Sort"": {""last_name"": ""ascending"", ""first_name"": ""ascending""}}}"
        Dim memberDict As Dictionary(Of String, Object)

        memberDict = iconCMOAssist.AuthForm.iCMO_Request(jsonString)

        'MsgBox(("members")[1]("firstname"))



    End Sub
End Class