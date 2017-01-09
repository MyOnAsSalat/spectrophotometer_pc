Public Class Form1
    Dim graphi As Integer = 0
    Dim combuffer As Double
    Dim ival As Integer
    Dim ignore As Integer = 1
    '  Dim wtime As Long = 0
    '  Dim stime As Long
    Dim startTime As Date
    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Dim now As Date = Date.Now
        ival = interval.Text
        SP.PortName = TB1.Text
        SP.Open()
        SP.ReadLine()
        startTime = now
        T1.Start()
    End Sub
    Private Sub st_Click(sender As Object, e As EventArgs) Handles st.Click
        T1.Stop()
        SP.Close()
    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        SP.Write("1")
        Try
            If ignore = ival Then
                combuffer = Integer.Parse(SP.ReadLine()) * 2.56 / 1024
                Dim runLength As TimeSpan = Now.Subtract(startTime)
                Dim millisecs As Integer = runLength.Milliseconds()
                Dim sec As Integer = runLength.TotalSeconds
                TB2.AppendText(graphi & "  " & sec & "," & millisecs & "  " & combuffer & vbCrLf)
                c.Series("graph").Points.AddXY(graphi, combuffer)
                ignore = 0
            End If
            ignore = ignore + 1
            graphi = graphi + 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        SFD1.InitialDirectory = "C:"
        SFD1.Title = "Сохранить таблицу"
        SFD1.Filter = "Текстовые файлы (*.txt)|*.txt"
        SFD1.FilterIndex = 2
        If SFD1.ShowDialog = DialogResult.OK Then System.IO.File.WriteAllText(SFD1.FileName, TB2.Text)
    End Sub
End Class
