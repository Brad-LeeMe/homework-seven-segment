Public Class Form1
    Dim isCounting As Boolean = True
    Dim Count As Byte = 0
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval

            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub


    Private Sub Label26_Paint(sender As Object, e As PaintEventArgs) Handles Label26.Paint

        While isCounting = True
            If Count = 0 Then
                Label1.BackColor = Color.Black
                Label2.BackColor = Color.Black
                Label3.BackColor = Color.Black
                Label4.BackColor = Color.Black
                Label5.BackColor = Color.Black
                Label6.BackColor = Color.Black
                Label10.BackColor = Color.Black
                Label11.BackColor = Color.Black
                Label12.BackColor = Color.White
                Label13.BackColor = Color.White
                Label14.BackColor = Color.White
                Label15.BackColor = Color.Black
                Label16.BackColor = Color.Black
                Label20.BackColor = Color.Black
                Label21.BackColor = Color.Black
                Label22.BackColor = Color.Black
                Label23.BackColor = Color.Black
                Label24.BackColor = Color.Black
                Label25.BackColor = Color.Black
                Count = 1
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 1 Then
                Label1.BackColor = Color.White
                Label2.BackColor = Color.White
                Label3.BackColor = Color.White
                Label4.BackColor = Color.White
                Label6.BackColor = Color.White
                Label11.BackColor = Color.White
                Label16.BackColor = Color.White
                Label21.BackColor = Color.White
                Label22.BackColor = Color.White
                Label23.BackColor = Color.White
                Label24.BackColor = Color.White
                Count = 2
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 2 Then
                Label1.BackColor = Color.Black
                Label2.BackColor = Color.Black
                Label3.BackColor = Color.Black
                Label4.BackColor = Color.Black
                Label11.BackColor = Color.Black
                Label12.BackColor = Color.Black
                Label13.BackColor = Color.Black
                Label14.BackColor = Color.Black
                Label16.BackColor = Color.Black
                Label20.BackColor = Color.White
                Label21.BackColor = Color.Black
                Label22.BackColor = Color.Black
                Label23.BackColor = Color.Black
                Label24.BackColor = Color.Black
                Count = 3
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 3 Then
                Label16.BackColor = Color.White
                Label20.BackColor = Color.Black
                Count = 4
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 4 Then
                Label2.BackColor = Color.White
                Label3.BackColor = Color.White
                Label4.BackColor = Color.White
                Label6.BackColor = Color.Black
                Label21.BackColor = Color.White
                Label22.BackColor = Color.White
                Label23.BackColor = Color.White
                Label24.BackColor = Color.White
                Count = 5
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 5 Then
                Label2.BackColor = Color.Black
                Label3.BackColor = Color.Black
                Label4.BackColor = Color.Black
                Label10.BackColor = Color.White
                Label21.BackColor = Color.Black
                Label22.BackColor = Color.Black
                Label23.BackColor = Color.Black
                Label24.BackColor = Color.Black
                Count = 6
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 6 Then
                Label16.BackColor = Color.Black
                Count = 7
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 7 Then
                Label6.BackColor = Color.White
                Label10.BackColor = Color.Black
                Label11.BackColor = Color.White
                Label12.BackColor = Color.White
                Label13.BackColor = Color.White
                Label14.BackColor = Color.White
                Label16.BackColor = Color.White
                Label21.BackColor = Color.White
                Label22.BackColor = Color.White
                Label23.BackColor = Color.White
                Label24.BackColor = Color.White
                Count = 8
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 8 Then
                Label6.BackColor = Color.Black
                Label11.BackColor = Color.Black
                Label12.BackColor = Color.Black
                Label13.BackColor = Color.Black
                Label14.BackColor = Color.Black
                Label16.BackColor = Color.Black
                Label21.BackColor = Color.Black
                Label22.BackColor = Color.Black
                Label23.BackColor = Color.Black
                Label24.BackColor = Color.Black
                Count = 9
                wait(1000)
            End If

            If isCounting = False Then
                Exit While
            End If

            If Count = 9 Then
                Label16.BackColor = Color.White
                Count = 0
                wait(1000)
            End If

        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isCounting = True Then
            isCounting = False
            Label27.BackColor = Color.Red
        Else

            Label27.BackColor = Color.FromArgb(224, 224, 224)
            isCounting = True
            While isCounting = True
                If Count = 0 Then
                    Label1.BackColor = Color.Black
                    Label2.BackColor = Color.Black
                    Label3.BackColor = Color.Black
                    Label4.BackColor = Color.Black
                    Label5.BackColor = Color.Black
                    Label6.BackColor = Color.Black
                    Label10.BackColor = Color.Black
                    Label11.BackColor = Color.Black
                    Label12.BackColor = Color.White
                    Label13.BackColor = Color.White
                    Label14.BackColor = Color.White
                    Label15.BackColor = Color.Black
                    Label16.BackColor = Color.Black
                    Label20.BackColor = Color.Black
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Label25.BackColor = Color.Black
                    Count = 1
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 1 Then
                    Label1.BackColor = Color.White
                    Label2.BackColor = Color.White
                    Label3.BackColor = Color.White
                    Label4.BackColor = Color.White
                    Label6.BackColor = Color.White
                    Label11.BackColor = Color.White
                    Label16.BackColor = Color.White
                    Label21.BackColor = Color.White
                    Label22.BackColor = Color.White
                    Label23.BackColor = Color.White
                    Label24.BackColor = Color.White
                    Count = 2
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 2 Then
                    Label1.BackColor = Color.Black
                    Label2.BackColor = Color.Black
                    Label3.BackColor = Color.Black
                    Label4.BackColor = Color.Black
                    Label11.BackColor = Color.Black
                    Label12.BackColor = Color.Black
                    Label13.BackColor = Color.Black
                    Label14.BackColor = Color.Black
                    Label16.BackColor = Color.Black
                    Label20.BackColor = Color.White
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Count = 3
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 3 Then
                    Label16.BackColor = Color.White
                    Label20.BackColor = Color.Black
                    Count = 4
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 4 Then
                    Label2.BackColor = Color.White
                    Label3.BackColor = Color.White
                    Label4.BackColor = Color.White
                    Label6.BackColor = Color.Black
                    Label21.BackColor = Color.White
                    Label22.BackColor = Color.White
                    Label23.BackColor = Color.White
                    Label24.BackColor = Color.White
                    Count = 5
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 5 Then
                    Label2.BackColor = Color.Black
                    Label3.BackColor = Color.Black
                    Label4.BackColor = Color.Black
                    Label10.BackColor = Color.White
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Count = 6
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 6 Then
                    Label16.BackColor = Color.Black
                    Count = 7
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 7 Then
                    Label6.BackColor = Color.White
                    Label10.BackColor = Color.Black
                    Label11.BackColor = Color.White
                    Label12.BackColor = Color.White
                    Label13.BackColor = Color.White
                    Label14.BackColor = Color.White
                    Label16.BackColor = Color.White
                    Label21.BackColor = Color.White
                    Label22.BackColor = Color.White
                    Label23.BackColor = Color.White
                    Label24.BackColor = Color.White
                    Count = 8
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 8 Then
                    Label6.BackColor = Color.Black
                    Label11.BackColor = Color.Black
                    Label12.BackColor = Color.Black
                    Label13.BackColor = Color.Black
                    Label14.BackColor = Color.Black
                    Label16.BackColor = Color.Black
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Count = 9
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 9 Then
                    Label16.BackColor = Color.White
                    Count = 0
                    wait(1000)
                End If

            End While

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If isCounting = True Then
            Count = 0

        Else
            Count = 0
            Label1.BackColor = Color.Black
            Label2.BackColor = Color.Black
            Label3.BackColor = Color.Black
            Label4.BackColor = Color.Black
            Label5.BackColor = Color.Black
            Label6.BackColor = Color.Black
            Label7.BackColor = Color.White
            Label8.BackColor = Color.White
            Label9.BackColor = Color.White
            Label10.BackColor = Color.Black
            Label11.BackColor = Color.Black
            Label12.BackColor = Color.White
            Label13.BackColor = Color.White
            Label14.BackColor = Color.White
            Label15.BackColor = Color.Black
            Label16.BackColor = Color.Black
            Label17.BackColor = Color.White
            Label18.BackColor = Color.White
            Label19.BackColor = Color.White
            Label20.BackColor = Color.Black
            Label21.BackColor = Color.Black
            Label22.BackColor = Color.Black
            Label23.BackColor = Color.Black
            Label24.BackColor = Color.Black
            Label25.BackColor = Color.Black

            While isCounting = True
                If Count = 0 Then
                    Label1.BackColor = Color.Black
                    Label2.BackColor = Color.Black
                    Label3.BackColor = Color.Black
                    Label4.BackColor = Color.Black
                    Label5.BackColor = Color.Black
                    Label6.BackColor = Color.Black
                    Label10.BackColor = Color.Black
                    Label11.BackColor = Color.Black
                    Label12.BackColor = Color.White
                    Label13.BackColor = Color.White
                    Label14.BackColor = Color.White
                    Label15.BackColor = Color.Black
                    Label16.BackColor = Color.Black
                    Label20.BackColor = Color.Black
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Label25.BackColor = Color.Black
                    Count = 1
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 1 Then
                    Label1.BackColor = Color.White
                    Label2.BackColor = Color.White
                    Label3.BackColor = Color.White
                    Label4.BackColor = Color.White
                    Label6.BackColor = Color.White
                    Label11.BackColor = Color.White
                    Label16.BackColor = Color.White
                    Label21.BackColor = Color.White
                    Label22.BackColor = Color.White
                    Label23.BackColor = Color.White
                    Label24.BackColor = Color.White
                    Count = 2
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 2 Then
                    Label1.BackColor = Color.Black
                    Label2.BackColor = Color.Black
                    Label3.BackColor = Color.Black
                    Label4.BackColor = Color.Black
                    Label11.BackColor = Color.Black
                    Label12.BackColor = Color.Black
                    Label13.BackColor = Color.Black
                    Label14.BackColor = Color.Black
                    Label16.BackColor = Color.Black
                    Label20.BackColor = Color.White
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Count = 3
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 3 Then
                    Label16.BackColor = Color.White
                    Label20.BackColor = Color.Black
                    Count = 4
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 4 Then
                    Label2.BackColor = Color.White
                    Label3.BackColor = Color.White
                    Label4.BackColor = Color.White
                    Label6.BackColor = Color.Black
                    Label21.BackColor = Color.White
                    Label22.BackColor = Color.White
                    Label23.BackColor = Color.White
                    Label24.BackColor = Color.White
                    Count = 5
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 5 Then
                    Label2.BackColor = Color.Black
                    Label3.BackColor = Color.Black
                    Label4.BackColor = Color.Black
                    Label10.BackColor = Color.White
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Count = 6
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 6 Then
                    Label16.BackColor = Color.Black
                    Count = 7
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 7 Then
                    Label6.BackColor = Color.White
                    Label10.BackColor = Color.Black
                    Label11.BackColor = Color.White
                    Label12.BackColor = Color.White
                    Label13.BackColor = Color.White
                    Label14.BackColor = Color.White
                    Label16.BackColor = Color.White
                    Label21.BackColor = Color.White
                    Label22.BackColor = Color.White
                    Label23.BackColor = Color.White
                    Label24.BackColor = Color.White
                    Count = 8
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 8 Then
                    Label6.BackColor = Color.Black
                    Label11.BackColor = Color.Black
                    Label12.BackColor = Color.Black
                    Label13.BackColor = Color.Black
                    Label14.BackColor = Color.Black
                    Label16.BackColor = Color.Black
                    Label21.BackColor = Color.Black
                    Label22.BackColor = Color.Black
                    Label23.BackColor = Color.Black
                    Label24.BackColor = Color.Black
                    Count = 9
                    wait(1000)
                End If

                If isCounting = False Then
                    Exit While
                End If

                If Count = 9 Then
                    Label16.BackColor = Color.White
                    Count = 0
                    wait(1000)
                End If

            End While

        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub
End Class
