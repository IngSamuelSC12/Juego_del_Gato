Public Class Gato2J
    Dim v1, v2, v3, v4, v5, v6, v7, v8, v9 As String

    Sub SonidoBotones()
        My.Computer.Audio.Play(My.Resources.Windows_Critical_Stop, AudioPlayMode.Background)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        SonidoBotones()
        B1.Visible = False
        If turno = 1 Then
            v1 = "X"
            X1.Visible = True
        Else
            v1 = "O"
            c1.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        SonidoBotones()
        B2.Visible = False
        If turno = 1 Then
            v2 = "X"
            X2.Visible = True
        Else
            v2 = "O"
            c2.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        SonidoBotones()
        B3.Visible = False
        If turno = 1 Then
            v3 = "X"
            X3.Visible = True
        Else
            v3 = "O"
            c3.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        SonidoBotones()
        B4.Visible = False
        If turno = 1 Then
            v4 = "X"
            X4.Visible = True
        Else
            v4 = "O"
            c4.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        SonidoBotones()
        B5.Visible = False
        If turno = 1 Then
            v5 = "X"
            X5.Visible = True
        Else
            v5 = "O"
            c5.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        SonidoBotones()
        B6.Visible = False
        If turno = 1 Then
            v6 = "X"
            X6.Visible = True
        Else
            v6 = "O"
            c6.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        SonidoBotones()
        B7.Visible = False
        If turno = 1 Then
            v7 = "X"
            X7.Visible = True
        Else
            v7 = "O"
            c7.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        SonidoBotones()
        B8.Visible = False
        If turno = 1 Then
            v8 = "X"
            X8.Visible = True
        Else
            v8 = "O"
            c8.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        SonidoBotones()
        B9.Visible = False
        If turno = 1 Then
            v9 = "X"
            X9.Visible = True
        Else
            v9 = "O"
            c9.Visible = True
        End If
        Checar_ganador()
        Cambiar_turno()
    End Sub


    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        ' AUTOR
        MsgBox("       Autor: Samuel Sanchez     " & Chr(13) & Chr(13) &
               "   Software: Visual Studio 2015 " & Chr(13) & Chr(13) &
               "       TecNM Campus Acuña " & Chr(13) & Chr(13) _
               , 64, "Programa de Gato")
    End Sub

    'MUSICA
    Private Sub MusicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicaToolStripMenuItem.Click
        If MusicaToolStripMenuItem.Checked = False Then
            MusicaToolStripMenuItem.Checked = True
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            'My.Computer.Audio.Play(My.Resources.neonon_109616, AudioPlayMode.BackgroundLoop)
        Else
            MusicaToolStripMenuItem.Checked = False
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            ' My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub VsPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VsPCToolStripMenuItem.Click
        Me.Hide()
        GatoPC.Show()
    End Sub

    Private Sub Gato2J_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.Ctlcontrols.stop()

    End Sub

    Sub ganar_diagonal()
        If (v1 = "X" And v5 = "X" And v9 = "X") Then
            LI7.BringToFront()
            c1.SendToBack()
            X1.SendToBack()
            B1.SendToBack()
            c5.SendToBack()
            X5.SendToBack()
            B5.SendToBack()
            c9.SendToBack()
            X9.SendToBack()
            B9.SendToBack()
            LI7.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            deshabilitar_botones()
            Exit Sub
        End If
        If (v3 = "X" And v5 = "X" And v7 = "X") Then
            LI8.BringToFront()
            c3.SendToBack()
            X3.SendToBack()
            B3.SendToBack()
            c5.SendToBack()
            X5.SendToBack()
            B5.SendToBack()
            c7.SendToBack()
            X7.SendToBack()
            B7.SendToBack()
            LI8.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            deshabilitar_botones()
            Exit Sub
        End If

        If (v1 = "O" And v5 = "O" And v9 = "O") Then
            LI7.BringToFront()
            c1.SendToBack()
            X1.SendToBack()
            B1.SendToBack()
            c5.SendToBack()
            X5.SendToBack()
            B5.SendToBack()
            c9.SendToBack()
            X9.SendToBack()
            B9.SendToBack()
            LI7.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            deshabilitar_botones()
            Exit Sub
        End If
        If (v3 = "O" And v5 = "O" And v7 = "O") Then
            LI8.BringToFront()
            c3.SendToBack()
            X3.SendToBack()
            B3.SendToBack()
            c5.SendToBack()
            X5.SendToBack()
            B5.SendToBack()
            c7.SendToBack()
            X7.SendToBack()
            B7.SendToBack()
            LI8.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            deshabilitar_botones()
            Exit Sub
        End If

    End Sub
    'CHECAR GANADOR
    Sub Checar_ganador()
        'validaciones para jugador de las X (j1)
        If v1 = "X" And v2 = "X" And v3 = "X" Then
            ga = j1
            deshabilitar_botones()
            LI1.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            Exit Sub
        End If

        If v4 = "X" And v5 = "X" And v6 = "X" Then
            ga = j1
            deshabilitar_botones()
            LI2.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            Exit Sub
        End If

        If v7 = "X" And v8 = "X" And v9 = "X" Then
            ga = j1
            deshabilitar_botones()
            LI3.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            Exit Sub
        End If

        If v1 = "X" And v4 = "X" And v7 = "X" Then
            ga = j1
            deshabilitar_botones()
            LI4.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            Exit Sub
        End If

        If v2 = "X" And v5 = "X" And v8 = "X" Then
            ga = j1
            deshabilitar_botones()
            LI5.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            Exit Sub
        End If

        If v3 = "X" And v6 = "X" And v9 = "X" Then
            ga = j1
            deshabilitar_botones()
            LI6.Visible = True
            MsgBox("Gano " & j1, 64, "You Win!!!")
            Exit Sub
        End If

        '---------------------------------------------------------------------
        'ganar jugador 2
        If v1 = "O" And v2 = "O" And v3 = "O" Then
            ga = j2
            deshabilitar_botones()
            LI1.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            Exit Sub
        End If

        If v4 = "O" And v5 = "O" And v6 = "O" Then
            ga = j2
            deshabilitar_botones()
            LI2.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            Exit Sub
        End If

        If v7 = "O" And v8 = "O" And v9 = "O" Then
            ga = j2
            deshabilitar_botones()
            LI3.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            Exit Sub
        End If

        If v1 = "O" And v4 = "O" And v7 = "O" Then
            ga = j2
            deshabilitar_botones()
            LI4.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            Exit Sub
        End If

        If v2 = "O" And v5 = "O" And v8 = "O" Then
            ga = j2
            deshabilitar_botones()
            LI5.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            Exit Sub
        End If

        If v3 = "O" And v6 = "O" And v9 = "O" Then
            ga = j2
            deshabilitar_botones()
            LI6.Visible = True
            MsgBox("Gano " & j2, 64, "You Win!!!")
            Exit Sub
        End If

        '----------------------------------------------------------------------
        'GANAR GATO O EMPATAR
        If ga = "" And v1 <> "" And v2 <> "" And v3 <> "" And v4 <> "" And v5 <> "" And v6 <> "" And v7 <> "" And v8 <> "" And v9 <> "" Then
            ga = "Gato"
            MsgBox("Juego Empatado", 64, "GANO GATO")
        End If

        ganar_diagonal()
    End Sub


    'CAMBIAR DE TURNO
    Sub Cambiar_turno()
        If ga = "" Then

        End If
        If turno = 1 Then
            turno = 2
            L1.Text = j2
        Else
            turno = 1
            L1.Text = j1
        End If
    End Sub

    Dim turno, na As Integer
    Dim j1, j2, ga As String


    Private Sub JugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugadoresToolStripMenuItem.Click

        LI1.Visible = False
        LI2.Visible = False
        LI3.Visible = False
        LI4.Visible = False
        LI5.Visible = False
        LI6.Visible = False
        LI7.Visible = False
        LI8.Visible = False


        c1.Visible = False
        c2.Visible = False
        c3.Visible = False
        c4.Visible = False
        c5.Visible = False
        c6.Visible = False
        c7.Visible = False
        c8.Visible = False
        c9.Visible = False

        X1.Visible = False
        X2.Visible = False
        X3.Visible = False
        X4.Visible = False
        X5.Visible = False
        X6.Visible = False
        X7.Visible = False
        X8.Visible = False
        X9.Visible = False

        B1.Visible = True
        B2.Visible = True
        B3.Visible = True
        B4.Visible = True
        B5.Visible = True
        B6.Visible = True
        B7.Visible = True
        B8.Visible = True
        B9.Visible = True

        B1.Enabled = True
        B2.Enabled = True
        B3.Enabled = True
        B4.Enabled = True
        B5.Enabled = True
        B6.Enabled = True
        B7.Enabled = True
        B8.Enabled = True
        B9.Enabled = True

        'validar que el nombre sea minimo de 3 letras
        Do
            j1 = InputBox("Ingrese el nombre del jugador 1", "Jugador 1")
            If Len(j1) >= 3 Then
                Exit Do
            Else
                MsgBox("El nombre debe ser minimo de 3 letras", 48, "Invalid Input")
            End If
        Loop While True 'ciclo infinito 

        Do
            j2 = InputBox("Ingrese el nombre del jugador 2", "Jugador 2")
        Loop Until Len(j1) >= 3

        'ganador
        ga = ""

        'turno
        turno = 1

        v1 = ""
        v2 = ""
        v3 = ""
        v4 = ""
        v5 = ""
        v6 = ""
        v7 = ""
        v8 = ""
        v9 = ""

        L1.Text = j1

    End Sub

    Sub deshabilitar_botones()
        B1.Enabled = False
        B2.Enabled = False
        B3.Enabled = False
        B4.Enabled = False
        B5.Enabled = False
        B6.Enabled = False
        B7.Enabled = False
        B8.Enabled = False
        B9.Enabled = False
    End Sub

End Class
