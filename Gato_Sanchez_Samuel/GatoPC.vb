Public Class GatoPC
    Dim j1, j2, v1, v2, v3, v4, v5, v6, v7, v8, v9, ganador As String
    Dim turno, na As Integer

    'Sub SonidoBotones()
    '    My.Computer.Audio.Play(My.Resources.Windows_Critical_Stop, AudioPlayMode.Background)
    'End Sub
    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        'SonidoBotones()
        BTN1.Visible = False
        If turno = 1 Then
            v1 = "X"
            BX1.Visible = True
        Else
            v1 = "O"
            O1.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        'SonidoBotones()
        BTN2.Visible = False
        If turno = 1 Then
            v2 = "X"
            BX2.Visible = True
        Else
            v2 = "O"
            O2.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        'SonidoBotones()
        BTN3.Visible = False
        If turno = 1 Then
            v3 = "X"
            BX3.Visible = True
        Else
            v3 = "O"
            O3.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN4_Click(sender As Object, e As EventArgs) Handles BTN4.Click
        'SonidoBotones()
        BTN4.Visible = False
        If turno = 1 Then
            v4 = "X"
            BX4.Visible = True
        Else
            v4 = "O"
            O4.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN5_Click(sender As Object, e As EventArgs) Handles BTN5.Click
        'SonidoBotones()
        BTN5.Visible = False
        If turno = 1 Then
            v5 = "X"
            BX5.Visible = True
        Else
            v5 = "O"
            O5.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN6_Click(sender As Object, e As EventArgs) Handles BTN6.Click
        'SonidoBotones()
        BTN6.Visible = False
        If turno = 1 Then
            v6 = "X"
            BX6.Visible = True
        Else
            v6 = "O"
            O6.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN7_Click(sender As Object, e As EventArgs) Handles BTN7.Click
        'SonidoBotones()
        BTN7.Visible = False
        If turno = 1 Then
            v7 = "X"
            BX7.Visible = True
        Else
            v7 = "O"
            O7.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN8_Click(sender As Object, e As EventArgs) Handles BTN8.Click
        'SonidoBotones()
        BTN8.Visible = False
        If turno = 1 Then
            v8 = "X"
            BX8.Visible = True
        Else
            v8 = "O"
            O8.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub BTN9_Click(sender As Object, e As EventArgs) Handles BTN9.Click
        'SonidoBotones()
        BTN9.Visible = False
        If turno = 1 Then
            v9 = "X"
            BX9.Visible = True
        Else
            v9 = "O"
            O9.Visible = True
        End If
        checar_ganador()
        cambiar_turno()
    End Sub

    Private Sub JugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugadoresToolStripMenuItem.Click
        Me.Hide()
        Gato2J.Show()
    End Sub

    Private Sub GatoPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        ln7.Visible = False
        ln8.Visible = False
        turno = 1
    End Sub


    Private Sub VsPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VsPCToolStripMenuItem.Click
        limpiar()
        BTN1.Enabled = True
        BTN2.Enabled = True
        BTN3.Enabled = True
        BTN4.Enabled = True
        BTN5.Enabled = True
        BTN6.Enabled = True
        BTN7.Enabled = True
        BTN8.Enabled = True
        BTN9.Enabled = True
    End Sub

    Sub limpiar()
        ln1.Visible = False
        ln2.Visible = False
        ln3.Visible = False
        ln4.Visible = False
        ln5.Visible = False
        ln6.Visible = False
        ln7.Visible = False
        ln8.Visible = False

        O1.Visible = False
        O2.Visible = False
        O3.Visible = False
        O4.Visible = False
        O5.Visible = False
        O6.Visible = False
        O7.Visible = False
        O8.Visible = False
        O9.Visible = False

        BX1.Visible = False
        BX2.Visible = False
        BX3.Visible = False
        BX4.Visible = False
        BX5.Visible = False
        BX6.Visible = False
        BX7.Visible = False
        BX8.Visible = False
        BX9.Visible = False

        BTN1.Visible = True
        BTN2.Visible = True
        BTN3.Visible = True
        BTN4.Visible = True
        BTN5.Visible = True
        BTN6.Visible = True
        BTN7.Visible = True
        BTN8.Visible = True
        BTN9.Visible = True

        'validar que el nombre sea minimo de 3 letras
        Do
            j1 = InputBox("Ingrese el nombre del jugador 1", "Jugador 1")
            If Len(j1) >= 3 Then
                Exit Do
            Else
                MsgBox("El nombre debe ser minimo de 3 letras", 48, "Invalid Input")
            End If
        Loop While True 'ciclo infinito 

        MsgBox("Jugador 2 es PC", 64)
        j2 = "PC"

        'ganador
        ganador = ""

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

        lbl1.Text = j1
    End Sub

    '----CAMBIAR DE TURNO ---------------------
    Sub cambiar_turno()
        If turno = 1 Then
            turno = 2
            lbl1.Text = j2

            Me.Refresh()
            System.Threading.Thread.Sleep(800)
            jugar_computadora()
        Else
            turno = 1
            lbl1.Text = j1
        End If
    End Sub


    'AQUI ES DONDE PUEDE GANAR LA COMPUTADORA
    Sub jugar_computadora()
        If v1 = "0" And v2 = "0" And v3 = "" Then
            v3 = 0
            BTN3.Visible = False
            O3.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v1 = "0" And v2 = "" And v3 = "0" Then
            v2 = 0
            BTN2.Visible = False
            O2.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "" And v2 = "0" And v3 = "0" Then
            v1 = 0
            BTN1.Visible = False
            O1.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v4 = "0" And v5 = "0" And v6 = "" Then
            v6 = 0
            BTN6.Visible = False
            O6.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v4 = "0" And v5 = "" And v6 = "0" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v4 = "" And v5 = "0" And v6 = "0" Then
            v4 = 0
            BTN4.Visible = False
            O4.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v7 = "0" And v8 = "0" And v9 = "" Then
            v9 = 0
            BTN9.Visible = False
            O9.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v7 = "0" And v8 = "" And v9 = "0" Then
            v8 = 0
            BTN8.Visible = False
            O8.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v7 = "" And v8 = "0" And v9 = "0" Then
            v7 = 0
            BTN7.Visible = False
            O7.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v1 = "0" And v4 = "0" And v7 = "" Then
            v7 = 0
            BTN7.Visible = False
            O7.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v1 = "0" And v4 = "" And v7 = "0" Then
            v4 = 0
            BTN4.Visible = False
            O4.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "" And v4 = "0" And v7 = "0" Then
            v1 = 0
            BTN1.Visible = False
            O1.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v2 = "0" And v5 = "0" And v8 = "" Then
            v8 = 0
            BTN8.Visible = False
            O8.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v2 = "0" And v5 = "" And v8 = "0" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v2 = "" And v5 = "0" And v8 = "0" Then
            v2 = 0
            BTN2.Visible = False
            O2.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "0" And v6 = "0" And v9 = "" Then
            v9 = 0
            BTN9.Visible = False
            O9.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "0" And v6 = "" And v9 = "0" Then
            v6 = 0
            BTN6.Visible = False
            O6.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v3 = "" And v6 = "0" And v9 = "0" Then
            v3 = 0
            BTN3.Visible = False
            O3.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "0" And v5 = "0" And v9 = "" Then
            v9 = 0
            BTN9.Visible = False
            O9.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v1 = "0" And v5 = "" And v9 = "0" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "" And v5 = "0" And v9 = "0" Then
            v1 = 0
            BTN1.Visible = False
            O1.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "0" And v5 = "0" And v7 = "" Then
            v7 = 0
            BTN7.Visible = False
            O7.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "0" And v5 = "" And v7 = "0" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v3 = "" And v5 = "0" And v7 = "0" Then
            v3 = 0
            BTN3.Visible = False
            O3.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        '---------------------------------------------------------------------------------------------
        'AQUI CHECA DONDE EL JUGADOR 1 PUEDE GANAR PARA BLOQUEARLO
        If v1 = "X" And v2 = "X" And v3 = "" Then
            v3 = 0
            BTN3.Visible = False
            O3.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v1 = "X" And v2 = "" And v3 = "X" Then
            v2 = 0
            BTN2.Visible = False
            O2.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "" And v2 = "X" And v3 = "X" Then
            v1 = 0
            BTN1.Visible = False
            O1.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v4 = "X" And v5 = "X" And v6 = "" Then
            v6 = 0
            BTN6.Visible = False
            O6.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v4 = "X" And v5 = "" And v6 = "X" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v4 = "" And v5 = "X" And v6 = "X" Then
            v4 = 0
            BTN4.Visible = False
            O4.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v7 = "X" And v8 = "X" And v9 = "" Then
            v9 = 0
            BTN9.Visible = False
            O9.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v7 = "X" And v8 = "" And v9 = "X" Then
            v8 = 0
            BTN8.Visible = False
            O8.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v7 = "" And v8 = "X" And v9 = "X" Then
            v7 = 0
            BTN7.Visible = False
            O7.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v1 = "X" And v4 = "X" And v7 = "" Then
            v7 = 0
            BTN7.Visible = False
            O7.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v1 = "X" And v4 = "" And v7 = "X" Then
            v4 = 0
            BTN4.Visible = False
            O4.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "" And v4 = "X" And v7 = "X" Then
            v1 = 0
            BTN1.Visible = False
            O1.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        If v2 = "X" And v5 = "X" And v8 = "" Then
            v8 = 0
            BTN8.Visible = False
            O8.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v2 = "X" And v5 = "" And v8 = "X" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v2 = "" And v5 = "X" And v8 = "X" Then
            v2 = 0
            BTN2.Visible = False
            O2.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "X" And v6 = "X" And v9 = "" Then
            v9 = 0
            BTN9.Visible = False
            O9.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "X" And v6 = "" And v9 = "X" Then
            v6 = 0
            BTN6.Visible = False
            O6.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v3 = "" And v6 = "X" And v9 = "X" Then
            v3 = 0
            BTN3.Visible = False
            O3.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "X" And v5 = "X" And v9 = "" Then
            v9 = 0
            BTN9.Visible = False
            O9.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v1 = "X" And v5 = "" And v9 = "X" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v1 = "" And v5 = "X" And v9 = "X" Then
            v1 = 0
            BTN1.Visible = False
            O1.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "X" And v5 = "X" And v7 = "" Then
            v7 = 0
            BTN7.Visible = False
            O7.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If


        If v3 = "X" And v5 = "" And v7 = "X" Then
            v5 = 0
            BTN5.Visible = False
            O5.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If



        If v3 = "" And v5 = "X" And v7 = "X" Then
            v3 = 0
            BTN3.Visible = False
            O3.Visible = True
            checar_ganador()
            If ganador = "" Then
                cambiar_turno()
            End If
            Exit Sub
        End If

        '---------------------------------------
        'SI NO PUEDE GANAR Y NO HAY PARA TAPAR, HACE UN TURNO NORMAL
        Dim exito As Boolean
        exito = True
        Dim espaciosDisponibles As Integer
        espaciosDisponibles = 0

        Do
            na = Math.Round(Rnd() * 8) + 1
            If na = 1 And v1 = "" Then
                v1 = 0
                BTN1.Visible = False
                O1.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 2 And v2 = "" Then
                v2 = 0
                BTN2.Visible = False
                O2.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 3 And v3 = "" Then
                v3 = 0
                BTN3.Visible = False
                O3.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 4 And v4 = "" Then
                v4 = 0
                BTN4.Visible = False
                O4.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 5 And v5 = "" Then
                v5 = 0
                BTN5.Visible = False
                O5.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 6 And v6 = "" Then
                v6 = 0
                BTN6.Visible = False
                O6.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 7 And v7 = "" Then
                v7 = 0
                BTN7.Visible = False
                O7.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 8 And v8 = "" Then
                v8 = 0
                BTN8.Visible = False
                O8.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If
            If na = 9 And v9 = "" Then
                v9 = 0
                BTN9.Visible = False
                O9.Visible = True
                checar_ganador()
                If ganador = "" Then
                    cambiar_turno()
                End If
                Exit Sub
            End If

            'EN CASO DE EMPATAR
            If v1 <> "" And v2 <> "" And v3 <> "" And v4 <> "" And v5 <> "" And v6 <> "" And v7 <> "" And v8 <> "" And v9 <> "" Then
                checar_ganador()
                deshabilitar_botones()
                Exit Sub
            End If

        Loop Until (exito = False)

    End Sub


    Sub checar_ganador()
        If v1 = "X" And v2 = "X" And v3 = "X" Then
            ganador = j1
            ln1.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v4 = "X" And v5 = "X" And v6 = "X" Then
            ganador = j1
            ln2.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v7 = "X" And v8 = "X" And v9 = "X" Then
            ganador = j1
            ln3.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v1 = "X" And v4 = "X" And v7 = "X" Then
            ganador = j1
            ln4.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v2 = "X" And v5 = "X" And v8 = "X" Then
            ganador = j1
            ln5.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v3 = "X" And v6 = "X" And v9 = "X" Then
            ganador = j1
            ln6.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If

        If v1 = "X" And v5 = "X" And v9 = "X" Then
            ganador = j1
            ln7.BringToFront()
            O1.SendToBack()
            BX1.SendToBack()
            BTN1.SendToBack()
            O5.SendToBack()
            BX5.SendToBack()
            BTN5.SendToBack()
            O9.SendToBack()
            BX9.SendToBack()
            BTN9.SendToBack()
            ln7.Visible = True
            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v3 = "X" And v5 = "X" And v7 = "X" Then
            ganador = j1
            ln8.BringToFront()
            O3.SendToBack()
            BX3.SendToBack()
            BTN3.SendToBack()
            O5.SendToBack()
            BX5.SendToBack()
            BTN5.SendToBack()
            O7.SendToBack()
            BX7.SendToBack()
            BTN7.SendToBack()
            ln8.Visible = True

            MsgBox("Gano " & j1, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If

        '--------------------------------------------------------------------
        'Validar 2do jugador 
        If v1 = "0" And v2 = "0" And v3 = "0" Then
            ganador = j2
            lbl1.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v4 = "0" And v5 = "0" And v6 = "0" Then
            ganador = j2
            ln2.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v7 = "0" And v8 = "0" And v9 = "0" Then
            ganador = j2
            ln3.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v1 = "0" And v4 = "0" And v7 = "0" Then
            ganador = j2
            ln4.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v2 = "0" And v5 = "0" And v8 = "0" Then
            ganador = j2
            ln5.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v3 = "0" And v6 = "0" And v9 = "0" Then
            ganador = j2
            ln6.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If

        If v1 = "0" And v5 = "0" And v9 = "0" Then
            ganador = j2
            ln7.BringToFront()
            O1.SendToBack()
            BX1.SendToBack()
            BTN1.SendToBack()
            O5.SendToBack()
            BX5.SendToBack()
            BTN5.SendToBack()
            O9.SendToBack()
            BX9.SendToBack()
            BTN9.SendToBack()
            ln7.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub

        End If
        If v3 = "0" And v5 = "0" And v7 = "0" Then
            ganador = j2
            ln8.BringToFront()
            O3.SendToBack()
            BX3.SendToBack()
            BTN3.SendToBack()
            O5.SendToBack()
            BX5.SendToBack()
            BTN5.SendToBack()
            O7.SendToBack()
            BX7.SendToBack()
            BTN7.SendToBack()
            ln8.Visible = True
            MsgBox("Gano " & j2, 64, "Ganador")
            deshabilitar_botones()
            lbl1.Text = "GAME OVER"
            Exit Sub


        End If
        'checa empate
        If ganador = "" And v1 <> "" And v2 <> "" And v3 <> "" And v4 <> "" And v5 <> "" And v6 <> "" And v7 <> "" And v8 <> "" And v9 <> "" Then
            ganador = "GATO"
            MsgBox("Juego Empatado", 48, "Gano GATO")
            Exit Sub
        End If

    End Sub

    Sub deshabilitar_botones()
        BTN1.Enabled = False
        BTN2.Enabled = False
        BTN3.Enabled = False
        BTN4.Enabled = False
        BTN5.Enabled = False
        BTN6.Enabled = False
        BTN7.Enabled = False
        BTN8.Enabled = False
        BTN9.Enabled = False
    End Sub
End Class