Imports System.IO
Imports System.Net.Sockets

Public Class Form1

    Dim stream As NetworkStream
    Dim streamw As StreamWriter
    Dim myclient As New TcpClient
    Dim Port As Integer = 55443
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Beep()
        Me.TopMost = My.Settings.topmost

        If Not My.Settings.indirizzoip = "" Then
            Label1.Text = My.Settings.indirizzoip
            Try
                myclient.Connect(My.Settings.indirizzoip, Port)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        If Me.TopMost = True Then
            Me.TopMost = False
            My.Settings.topmost = "False"
        Else
            Me.TopMost = True
            My.Settings.topmost = "True"
        End If
        My.Settings.Save()
        Console.Beep()
    End Sub

    Private Sub Btn_onoff_Click(sender As Object, e As EventArgs) Handles btn_onoff.Click
        Try
            stream = myclient.GetStream
            streamw = New StreamWriter(stream)
            streamw.WriteLine("{""id"":1,""method"":""toggle"",""params"":[]}")
            streamw.Flush()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_day_Click(sender As Object, e As EventArgs) Handles btn_day.Click
        Try
            stream = myclient.GetStream
            streamw = New StreamWriter(stream)
            streamw.WriteLine("{""id"":1,""method"":""set_power"",""params"":[""on"",""smooth"",500,1]}")
            streamw.Flush()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_night_Click(sender As Object, e As EventArgs) Handles btn_night.Click
        Try
            stream = myclient.GetStream
            streamw = New StreamWriter(stream)
            streamw.WriteLine("{""id"":1,""method"":""set_power"",""params"":[""on"",""smooth"",500,5]}")
            streamw.Flush()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        Dim Percentuale As String
        Percentuale = (TrackBar1.Value.ToString)

        Try
            stream = myclient.GetStream
            streamw = New StreamWriter(stream)
            streamw.WriteLine("{""id"": 1,""method"":""set_bright"",""params"":[" + Percentuale + "]}")
            streamw.Flush()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Dim indirizzo As String

        Try

            indirizzo = InputBox("Inserisci un IP")
        Catch

        End Try

        Try
            My.Settings.indirizzoip = (indirizzo)
            My.Settings.Save()
            Label1.Text = My.Settings.indirizzoip
            System.Windows.Forms.Application.Restart()
        Catch

        End Try
    End Sub

    Private Sub TrackBar2_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar2.MouseUp
        Dim kelvin As String
        kelvin = (TrackBar2.Value.ToString)
        Dim Percentuale2 As String
        Percentuale2 = (TrackBar1.Value.ToString)

        Try
            stream = myclient.GetStream
            streamw = New StreamWriter(stream)
            streamw.WriteLine("{""id"":1,""method"":""set_scene"", ""params"":[""ct""," + kelvin + "," + Percentuale2 + "]}")
            streamw.Flush()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
