﻿Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Web.Script.Serialization
Imports System.Collections.Generic
Imports System.Windows.Forms



Public Class AuthForm

    Public Shared Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String

        Dim req As WebRequest = WebRequest.Create(uri)
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length

        Dim stream = req.GetRequestStream()
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Close()

        Dim response = req.GetResponse().GetResponseStream()

        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()

        Return res
    End Function


    Public Shared Function iCMO_Request(jsonStr As String) As Object

        Dim jsonEncoded = Encoding.UTF8.GetBytes(jsonStr)
        Dim result_post = SendRequest(Globals.iconCMOUri, jsonEncoded, "application/json", "POST")

        Dim jss As New JavaScriptSerializer()
        Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(result_post)

        Return jsonDict

    End Function

    Public Function Connect_Button(sender As Object, e As EventArgs) Handles btnServerConnect.Click

        Globals.authSession = iCMO_Authenticate()
        Return 0

    End Function

    Public Function iCMO_Authenticate() As String

        Dim frmMember As New formMembership

        txtConnectStatus.Text = "Connecting..."



        'Retreive Member List
        Dim jsonString = "{ ""Auth"": {""Phone"": """ + txtAuthPhone.Text + """,""Username"": """ + txtAuthUser.Text + """,""Password"": """ + txtAuthPass.Text + """ }, ""Request"": { ""Module"": ""membership"", ""Section"": ""members"", ""Filters"": {""startAt"": 0,""limit"": 10 },""Sort"": {""last_name"": ""ascending"",""first_name"": ""ascending""}}} "

        'Retreive Account List
        'Dim jsonString = "{""Auth"": {""Phone"": """ + myAuth.Phone + """,""Username"": """ + myAuth.Username + """,""Password"": """ + myAuth.Password + """},""Request"": {""Module"": ""GL"",""Section"": ""Accounts""}}"

        Dim jsonEncoded = Encoding.UTF8.GetBytes(jsonString)
        Dim result_post = SendRequest(Globals.iconCMOUri, jsonEncoded, "application/json", "POST")

        Dim jss As New JavaScriptSerializer()
        Dim jsonDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(result_post)

        If jsonDict.ContainsKey("session") Then
            txtConnectStatus.Text = "Connected"
            txtConnectStatus.BackColor = Drawing.Color.Green
            frmMember.Show()
        End If


        Return jsonDict("session")

    End Function

    Public Class Globals

        Public Shared iconCMOUri As New Uri("https://secure3.iconcmo.com/api/")
        Public Shared authSession As String

    End Class

End Class

