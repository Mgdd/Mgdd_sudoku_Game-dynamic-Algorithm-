Public Class FrmGameList

    Sub configration_sudoku()
start:
        If FrmGame.b1.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b1.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b1.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b1.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b1.Text) = 0 Then
                        GoTo start
                    End If
                Else
                    GoTo a
                End If
            Next
        End If

a:
        If FrmGame.b2.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b2.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b2.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b2.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b2.Text) = 0 Then
                        GoTo a
                    End If
                Else
                    GoTo b
                End If
            Next
        End If

b:
        If FrmGame.b3.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b3.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b3.Text) = Val(FrmGame.b21.Text) Then
                    FrmGame.b3.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b3.Text) = 0 Then
                        GoTo b
                    End If
                Else
                    GoTo c
                End If
            Next
        End If

c:
        If FrmGame.b10.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b10.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b10.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b10.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b10.Text) = 0 Then
                        GoTo c
                    End If
                Else
                    GoTo a
                End If
            Next
        End If

j:
        If FrmGame.b11.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b11.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b11.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b11.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b11.Text) = 0 Then
                        GoTo j
                    End If
                Else
                    GoTo k
                End If
            Next
        End If

k:
        If FrmGame.b12.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b12.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b12.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b12.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b12.Text) = 0 Then
                        GoTo k
                    End If
                Else
                    GoTo l
                End If
            Next
        End If

l:
        If FrmGame.b19.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b19.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b19.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b19.Text) = 0 Then
                        GoTo l
                    End If
                Else
                    GoTo s
                End If
            Next
        End If

s:
        If FrmGame.b20.Text = 0 Then
            For i = 1 To 21
                If Val(FrmGame.b20.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b19.Text) Or Val(FrmGame.b20.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b20.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b20.Text) = 0 Then
                        GoTo s
                    End If
                Else
                    GoTo t
                End If
            Next
        End If

t:
        If FrmGame.b21.Text = 0 Then
            FrmGame.b21.Text = 1
            For i = 1 To 21
                If Val(FrmGame.b21.Text) = Val(FrmGame.b1.Text) Or Val(FrmGame.b21.Text) = Val(FrmGame.b2.Text) Or Val(FrmGame.b21.Text) = Val(FrmGame.b3.Text) Or Val(FrmGame.b21.Text) = Val(FrmGame.b10.Text) Or Val(FrmGame.b21.Text) = Val(FrmGame.b11.Text) Or Val(FrmGame.b21.Text) = Val(FrmGame.b12.Text) Or Val(FrmGame.b21.Text) = Val(FrmGame.b20.Text) Or Val(FrmGame.b19.Text) = Val(FrmGame.b21.Text) Then

                    FrmGame.b21.Text = Int(Rnd() * 10)

                    If Val(FrmGame.b21.Text) = 0 Then
                        GoTo t
                    End If
                Else
                    GoTo u
                End If
            Next
        End If

u:


        FrmGame.b4.Text = FrmGame.b10.Text
        FrmGame.b5.Text = FrmGame.b11.Text
        FrmGame.b6.Text = FrmGame.b21.Text

        FrmGame.b7.Text = FrmGame.b20.Text
        FrmGame.b8.Text = FrmGame.b19.Text
        FrmGame.b9.Text = FrmGame.b12.Text

        FrmGame.b13.Text = FrmGame.b19.Text
        FrmGame.b14.Text = FrmGame.b20.Text
        FrmGame.b15.Text = FrmGame.b1.Text

        FrmGame.b16.Text = FrmGame.b2.Text
        FrmGame.b17.Text = FrmGame.b3.Text
        FrmGame.b18.Text = FrmGame.b21.Text

        FrmGame.b22.Text = FrmGame.b2.Text
        FrmGame.b23.Text = FrmGame.b3.Text
        FrmGame.b24.Text = FrmGame.b12.Text

        FrmGame.b25.Text = FrmGame.b1.Text
        FrmGame.b26.Text = FrmGame.b10.Text
        FrmGame.b27.Text = FrmGame.b11.Text

        FrmGame.b28.Text = FrmGame.b21.Text
        FrmGame.b29.Text = FrmGame.b1.Text
        FrmGame.b30.Text = FrmGame.b20.Text

        FrmGame.b31.Text = FrmGame.b11.Text
        FrmGame.b32.Text = FrmGame.b10.Text
        FrmGame.b33.Text = FrmGame.b19.Text

        FrmGame.b34.Text = FrmGame.b3.Text
        FrmGame.b35.Text = FrmGame.b12.Text
        FrmGame.b36.Text = FrmGame.b2.Text

        FrmGame.b37.Text = FrmGame.b3.Text
        FrmGame.b38.Text = FrmGame.b12.Text
        FrmGame.b39.Text = FrmGame.b10.Text

        FrmGame.b40.Text = FrmGame.b21.Text
        FrmGame.b41.Text = FrmGame.b1.Text
        FrmGame.b42.Text = FrmGame.b2.Text

        FrmGame.b43.Text = FrmGame.b11.Text
        FrmGame.b44.Text = FrmGame.b20.Text
        FrmGame.b45.Text = FrmGame.b19.Text

        FrmGame.b46.Text = FrmGame.b11.Text
        FrmGame.b47.Text = FrmGame.b19.Text
        FrmGame.b48.Text = FrmGame.b2.Text

        FrmGame.b49.Text = FrmGame.b20.Text
        FrmGame.b50.Text = FrmGame.b12.Text
        FrmGame.b51.Text = FrmGame.b3.Text

        FrmGame.b52.Text = FrmGame.b21.Text
        FrmGame.b53.Text = FrmGame.b1.Text
        FrmGame.b54.Text = FrmGame.b10.Text

        FrmGame.b55.Text = FrmGame.b20.Text
        FrmGame.b56.Text = FrmGame.b10.Text
        FrmGame.b57.Text = FrmGame.b19.Text

        FrmGame.b58.Text = FrmGame.b1.Text
        FrmGame.b59.Text = FrmGame.b2.Text
        FrmGame.b60.Text = FrmGame.b11.Text

        FrmGame.b61.Text = FrmGame.b12.Text
        FrmGame.b62.Text = FrmGame.b21.Text
        FrmGame.b63.Text = FrmGame.b3.Text

        FrmGame.b64.Text = FrmGame.b12.Text
        FrmGame.b65.Text = FrmGame.b21.Text
        FrmGame.b66.Text = FrmGame.b11.Text

        FrmGame.b67.Text = FrmGame.b3.Text
        FrmGame.b68.Text = FrmGame.b19.Text
        FrmGame.b69.Text = FrmGame.b20.Text

        FrmGame.b70.Text = FrmGame.b10.Text
        FrmGame.b71.Text = FrmGame.b2.Text
        FrmGame.b72.Text = FrmGame.b1.Text

        FrmGame.b73.Text = FrmGame.b2.Text
        FrmGame.b74.Text = FrmGame.b3.Text
        FrmGame.b75.Text = FrmGame.b1.Text

        FrmGame.b76.Text = FrmGame.b12.Text
        FrmGame.b77.Text = FrmGame.b21.Text
        FrmGame.b78.Text = FrmGame.b10.Text

        FrmGame.b79.Text = FrmGame.b19.Text
        FrmGame.b80.Text = FrmGame.b11.Text
        FrmGame.b81.Text = FrmGame.b20.Text
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmGame.Show()
        Me.Hide()
        FrmGame.Text = "Beginner"



        FrmGame.s1 = Int(Rnd() * 10)
        FrmGame.s2 = Int(Rnd() * 10)
        FrmGame.s3 = Int(Rnd() * 10)
        FrmGame.s4 = Int(Rnd() * 10)
        FrmGame.s5 = Int(Rnd() * 10)
        FrmGame.s6 = Int(Rnd() * 10)
        FrmGame.s7 = Int(Rnd() * 10)
        FrmGame.s8 = Int(Rnd() * 10)
        FrmGame.s9 = Int(Rnd() * 10)
        FrmGame.s10 = Int(Rnd() * 10)
        FrmGame.s11 = Int(Rnd() * 10)
        FrmGame.s12 = Int(Rnd() * 10)
        FrmGame.s13 = Int(Rnd() * 10)
        FrmGame.s14 = Int(Rnd() * 10)
        FrmGame.s15 = Int(Rnd() * 10)
        FrmGame.s16 = Int(Rnd() * 10)
        FrmGame.s17 = Int(Rnd() * 10)
        FrmGame.s18 = Int(Rnd() * 10)
        FrmGame.s19 = Int(Rnd() * 10)
        FrmGame.s20 = Int(Rnd() * 10)
        FrmGame.s21 = Int(Rnd() * 10)
        FrmGame.s22 = Int(Rnd() * 10)
        FrmGame.s23 = Int(Rnd() * 10)
        FrmGame.s24 = Int(Rnd() * 10)
        FrmGame.s25 = Int(Rnd() * 10)
        FrmGame.s26 = Int(Rnd() * 10)
        FrmGame.s27 = Int(Rnd() * 10)
        FrmGame.s28 = Int(Rnd() * 10)
        FrmGame.s29 = Int(Rnd() * 10)
        FrmGame.s30 = Int(Rnd() * 10)
        FrmGame.s31 = Int(Rnd() * 10)
        FrmGame.s32 = Int(Rnd() * 10)
        FrmGame.s33 = Int(Rnd() * 10)
        FrmGame.s34 = Int(Rnd() * 10)
        FrmGame.s35 = Int(Rnd() * 10)
        FrmGame.s36 = Int(Rnd() * 10)
        FrmGame.s37 = Int(Rnd() * 10)
        FrmGame.s38 = Int(Rnd() * 10)
        FrmGame.s39 = Int(Rnd() * 10)
        FrmGame.s40 = Int(Rnd() * 10)
        FrmGame.s41 = Int(Rnd() * 10)
        FrmGame.s42 = Int(Rnd() * 10)
        FrmGame.s43 = Int(Rnd() * 10)
        FrmGame.s44 = Int(Rnd() * 10)
        FrmGame.s45 = Int(Rnd() * 10)
        FrmGame.s46 = Int(Rnd() * 10)
        FrmGame.s47 = Int(Rnd() * 10)
        FrmGame.s48 = Int(Rnd() * 10)
        FrmGame.s49 = Int(Rnd() * 10)
        FrmGame.s50 = Int(Rnd() * 10)
        FrmGame.s51 = Int(Rnd() * 10)
        FrmGame.s52 = Int(Rnd() * 10)
        FrmGame.s53 = Int(Rnd() * 10)
        FrmGame.s54 = Int(Rnd() * 10)
        FrmGame.s55 = Int(Rnd() * 10)
        FrmGame.s56 = Int(Rnd() * 10)
        FrmGame.s57 = Int(Rnd() * 10)
        FrmGame.s58 = Int(Rnd() * 10)
        FrmGame.s59 = Int(Rnd() * 10)
        FrmGame.s60 = Int(Rnd() * 10)
        FrmGame.s61 = Int(Rnd() * 10)
        FrmGame.s62 = Int(Rnd() * 10)
        FrmGame.s63 = Int(Rnd() * 10)
        FrmGame.s64 = Int(Rnd() * 10)
        FrmGame.s65 = Int(Rnd() * 10)
        FrmGame.s66 = Int(Rnd() * 10)
        FrmGame.s67 = Int(Rnd() * 10)
        FrmGame.s68 = Int(Rnd() * 10)
        FrmGame.s69 = Int(Rnd() * 10)
        FrmGame.s70 = Int(Rnd() * 10)
        FrmGame.s71 = Int(Rnd() * 10)
        FrmGame.s72 = Int(Rnd() * 10)
        FrmGame.s73 = Int(Rnd() * 10)
        FrmGame.s74 = Int(Rnd() * 10)
        FrmGame.s75 = Int(Rnd() * 10)
        FrmGame.s76 = Int(Rnd() * 10)
        FrmGame.s77 = Int(Rnd() * 10)
        FrmGame.s78 = Int(Rnd() * 10)
        FrmGame.s79 = Int(Rnd() * 10)
        FrmGame.s80 = Int(Rnd() * 10)
        FrmGame.s81 = Int(Rnd() * 10)


        FrmGame.b1.Text = 0
        FrmGame.b2.Text = 0
        FrmGame.b3.Text = 0

        FrmGame.b10.Text = 0
        FrmGame.b11.Text = 0
        FrmGame.b12.Text = 0

        FrmGame.b19.Text = 0
        FrmGame.b20.Text = 0
        FrmGame.b21.Text = 0

        'all_zero_to_empty()

        'all_to_zero()

        configration_sudoku()

        FrmGame.get_ready()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FrmGame.Show()
        Me.Hide()

        FrmGame.Text = "Easy"

        FrmGame.s1 = Int(Rnd() * Rnd() * 10)
        FrmGame.s2 = Int(Rnd() * Rnd() * 10)
        FrmGame.s3 = Int(Rnd() * Rnd() * 10)
        FrmGame.s4 = Int(Rnd() * Rnd() * 10)
        FrmGame.s5 = Int(Rnd() * Rnd() * 10)
        FrmGame.s6 = Int(Rnd() * Rnd() * 10)
        FrmGame.s7 = Int(Rnd() * Rnd() * 10)
        FrmGame.s8 = Int(Rnd() * Rnd() * 10)
        FrmGame.s9 = Int(Rnd() * Rnd() * 10)
        FrmGame.s10 = Int(Rnd() * Rnd() * 10)
        FrmGame.s11 = Int(Rnd() * Rnd() * 10)
        FrmGame.s12 = Int(Rnd() * Rnd() * 10)
        FrmGame.s13 = Int(Rnd() * Rnd() * 10)
        FrmGame.s14 = Int(Rnd() * Rnd() * 10)
        FrmGame.s15 = Int(Rnd() * Rnd() * 10)
        FrmGame.s16 = Int(Rnd() * Rnd() * 10)
        FrmGame.s17 = Int(Rnd() * Rnd() * 10)
        FrmGame.s18 = Int(Rnd() * Rnd() * 10)
        FrmGame.s19 = Int(Rnd() * Rnd() * 10)
        FrmGame.s20 = Int(Rnd() * Rnd() * 10)
        FrmGame.s21 = Int(Rnd() * Rnd() * 10)
        FrmGame.s22 = Int(Rnd() * Rnd() * 10)
        FrmGame.s23 = Int(Rnd() * Rnd() * 10)
        FrmGame.s24 = Int(Rnd() * Rnd() * 10)
        FrmGame.s25 = Int(Rnd() * Rnd() * 10)
        FrmGame.s26 = Int(Rnd() * Rnd() * 10)
        FrmGame.s27 = Int(Rnd() * Rnd() * 10)
        FrmGame.s28 = Int(Rnd() * Rnd() * 10)
        FrmGame.s29 = Int(Rnd() * Rnd() * 10)
        FrmGame.s30 = Int(Rnd() * Rnd() * 10)
        FrmGame.s31 = Int(Rnd() * Rnd() * 10)
        FrmGame.s32 = Int(Rnd() * Rnd() * 10)
        FrmGame.s33 = Int(Rnd() * Rnd() * 10)
        FrmGame.s34 = Int(Rnd() * Rnd() * 10)
        FrmGame.s35 = Int(Rnd() * Rnd() * 10)
        FrmGame.s36 = Int(Rnd() * Rnd() * 10)
        FrmGame.s37 = Int(Rnd() * Rnd() * 10)
        FrmGame.s38 = Int(Rnd() * Rnd() * 10)
        FrmGame.s39 = Int(Rnd() * Rnd() * 10)
        FrmGame.s40 = Int(Rnd() * Rnd() * 10)
        FrmGame.s41 = Int(Rnd() * Rnd() * 10)
        FrmGame.s42 = Int(Rnd() * Rnd() * 10)
        FrmGame.s43 = Int(Rnd() * Rnd() * 10)
        FrmGame.s44 = Int(Rnd() * Rnd() * 10)
        FrmGame.s45 = Int(Rnd() * Rnd() * 10)
        FrmGame.s46 = Int(Rnd() * Rnd() * 10)
        FrmGame.s47 = Int(Rnd() * Rnd() * 10)
        FrmGame.s48 = Int(Rnd() * Rnd() * 10)
        FrmGame.s49 = Int(Rnd() * Rnd() * 10)
        FrmGame.s50 = Int(Rnd() * Rnd() * 10)
        FrmGame.s51 = Int(Rnd() * Rnd() * 10)
        FrmGame.s52 = Int(Rnd() * Rnd() * 10)
        FrmGame.s53 = Int(Rnd() * Rnd() * 10)
        FrmGame.s54 = Int(Rnd() * Rnd() * 10)
        FrmGame.s55 = Int(Rnd() * Rnd() * 10)
        FrmGame.s56 = Int(Rnd() * Rnd() * 10)
        FrmGame.s57 = Int(Rnd() * Rnd() * 10)
        FrmGame.s58 = Int(Rnd() * Rnd() * 10)
        FrmGame.s59 = Int(Rnd() * Rnd() * 10)
        FrmGame.s60 = Int(Rnd() * Rnd() * 10)
        FrmGame.s61 = Int(Rnd() * Rnd() * 10)
        FrmGame.s62 = Int(Rnd() * Rnd() * 10)
        FrmGame.s63 = Int(Rnd() * Rnd() * 10)
        FrmGame.s64 = Int(Rnd() * Rnd() * 10)
        FrmGame.s65 = Int(Rnd() * Rnd() * 10)
        FrmGame.s66 = Int(Rnd() * Rnd() * 10)
        FrmGame.s67 = Int(Rnd() * Rnd() * 10)
        FrmGame.s68 = Int(Rnd() * Rnd() * 10)
        FrmGame.s69 = Int(Rnd() * Rnd() * 10)
        FrmGame.s70 = Int(Rnd() * Rnd() * 10)
        FrmGame.s71 = Int(Rnd() * Rnd() * 10)
        FrmGame.s72 = Int(Rnd() * Rnd() * 10)
        FrmGame.s73 = Int(Rnd() * Rnd() * 10)
        FrmGame.s74 = Int(Rnd() * Rnd() * 10)
        FrmGame.s75 = Int(Rnd() * Rnd() * 10)
        FrmGame.s76 = Int(Rnd() * Rnd() * 10)
        FrmGame.s77 = Int(Rnd() * Rnd() * 10)
        FrmGame.s78 = Int(Rnd() * Rnd() * 10)
        FrmGame.s79 = Int(Rnd() * Rnd() * 10)
        FrmGame.s80 = Int(Rnd() * Rnd() * 10)
        FrmGame.s81 = Int(Rnd() * Rnd() * 10)


        FrmGame.b1.Text = 0
        FrmGame.b2.Text = 0
        FrmGame.b3.Text = 0

        FrmGame.b10.Text = 0
        FrmGame.b11.Text = 0
        FrmGame.b12.Text = 0

        FrmGame.b19.Text = 0
        FrmGame.b20.Text = 0
        FrmGame.b21.Text = 0

        'all_zero_to_empty()

        'all_to_zero()

        configration_sudoku()

        FrmGame.get_ready()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FrmGame.Show()
        Me.Hide()

        FrmGame.Text = "Medium"

        FrmGame.s1 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s2 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s3 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s4 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s5 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s6 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s7 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s8 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s9 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s10 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s11 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s12 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s13 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s14 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s15 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s16 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s17 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s18 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s19 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s20 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s21 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s22 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s23 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s24 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s25 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s26 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s27 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s28 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s29 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s30 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s31 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s32 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s33 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s34 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s35 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s36 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s37 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s38 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s39 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s40 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s41 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s42 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s43 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s44 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s45 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s46 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s47 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s48 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s49 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s50 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s51 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s52 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s53 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s54 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s55 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s56 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s57 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s58 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s59 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s60 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s61 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s62 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s63 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s64 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s65 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s66 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s67 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s68 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s69 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s70 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s71 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s72 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s73 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s74 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s75 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s76 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s77 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s78 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s79 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s80 = Int(Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s81 = Int(Rnd() * Rnd() * Rnd() * 10)


        FrmGame.b1.Text = 0
        FrmGame.b2.Text = 0
        FrmGame.b3.Text = 0

        FrmGame.b10.Text = 0
        FrmGame.b11.Text = 0
        FrmGame.b12.Text = 0

        FrmGame.b19.Text = 0
        FrmGame.b20.Text = 0
        FrmGame.b21.Text = 0

        'all_zero_to_empty()

        'all_to_zero()

        configration_sudoku()

        FrmGame.get_ready()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FrmGame.Show()
        Me.Hide()

        FrmGame.Text = "Hard"

        FrmGame.s1 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s2 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s3 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s4 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s5 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s6 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s7 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s8 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s9 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s10 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s11 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s12 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s13 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s14 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s15 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s16 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s17 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s18 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s19 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s20 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s21 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s22 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s23 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s24 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s25 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s26 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s27 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s28 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s29 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s30 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s31 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s32 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s33 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s34 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s35 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s36 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s37 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s38 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s39 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s40 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s41 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s42 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s43 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s44 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s45 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s46 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s47 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s48 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s49 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s50 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s51 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s52 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s53 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s54 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s55 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s56 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s57 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s58 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s59 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s60 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s61 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s62 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s63 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s64 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s65 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s66 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s67 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s68 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s69 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s70 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s71 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s72 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s73 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s74 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s75 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s76 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s77 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s78 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s79 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s80 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)
        FrmGame.s81 = Int(Rnd() * Rnd() * Rnd() * Rnd() * 10)


        FrmGame.b1.Text = 0
        FrmGame.b2.Text = 0
        FrmGame.b3.Text = 0

        FrmGame.b10.Text = 0
        FrmGame.b11.Text = 0
        FrmGame.b12.Text = 0

        FrmGame.b19.Text = 0
        FrmGame.b20.Text = 0
        FrmGame.b21.Text = 0

        'all_zero_to_empty()

        'all_to_zero()

        configration_sudoku()

        FrmGame.get_ready()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmMainSudoku.Show()
        Me.Hide()
    End Sub
End Class