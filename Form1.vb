Public Class Form1
    Public ValueA As Double = 0
    Public ValueB As Double = 0
    Public Mode As Integer = 0
    Public IsInputDecimalpoint As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ロード時にフォーカスを設定する
        Me.ActiveControl = ButtonExec
        'フォームが先にキーを受け取る設定
        KeyPreview = True
        InputA.Text = 0
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Me.ButtonExec.Enabled = True Then
                    Me.ButtonExec.Focus()
                    Me.ButtonExec.PerformClick()
                End If
                e.Handled = True
            Case Keys.Oemplus
                If Me.KeyModePlus.Enabled = True Then
                    Me.KeyModePlus.Focus()
                    Me.KeyModePlus.PerformClick()
                End If
                e.Handled = True
            Case Keys.OemMinus
                If Me.KeyModeMinus.Enabled = True Then
                    Me.KeyModeMinus.Focus()
                    Me.KeyModeMinus.PerformClick()
                End If
                e.Handled = True
            Case Keys.Multiply
                If Me.KeyModeTimes.Enabled = True Then
                    Me.KeyModeTimes.Focus()
                    Me.KeyModeTimes.PerformClick()
                End If
                e.Handled = True
            Case Keys.Divide
                If Me.KeyModeDivide.Enabled = True Then
                    Me.KeyModeDivide.Focus()
                    Me.KeyModeDivide.PerformClick()
                End If
                e.Handled = True
            Case Keys.OemBackslash
                If Me.KeyModeDivideWithRemainder.Enabled = True Then
                    Me.KeyModeDivideWithRemainder.Focus()
                    Me.KeyModeDivideWithRemainder.PerformClick()
                End If
                e.Handled = True
            Case Keys.Back
                If Me.KeyC.Enabled = True Then
                    Me.KeyC.Focus()
                    Me.KeyC.PerformClick()
                End If
                e.Handled = True

            Case Keys.Decimal
                If Me.Key1.Enabled = True Then
                    Me.KeyDecimalpoint.Focus()
                    Me.KeyDecimalpoint.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad0, Keys.D0
                If Me.Key1.Enabled = True Then
                    Me.Key1.Focus()
                    Me.Key1.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad1, Keys.D1
                If Me.Key1.Enabled = True Then
                    Me.Key1.Focus()
                    Me.Key1.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad2, Keys.D2
                If Me.Key2.Enabled = True Then
                    Me.Key2.Focus()
                    Me.Key2.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad3, Keys.D3
                If Me.Key3.Enabled = True Then
                    Me.Key3.Focus()
                    Me.Key3.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad4, Keys.D4
                If Me.Key4.Enabled = True Then
                    Me.Key4.Focus()
                    Me.Key4.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad5, Keys.D5
                If Me.Key5.Enabled = True Then
                    Me.Key5.Focus()
                    Me.Key5.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad6, Keys.D6
                If Me.Key6.Enabled = True Then
                    Me.Key6.Focus()
                    Me.Key6.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad7, Keys.D7
                If Me.Key7.Enabled = True Then
                    Me.Key7.Focus()
                    Me.Key7.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad8, Keys.D8
                If Me.Key8.Enabled = True Then
                    Me.Key8.Focus()
                    Me.Key8.PerformClick()
                End If
                e.Handled = True
            Case Keys.NumPad9, Keys.D9
                If Me.Key9.Enabled = True Then
                    Me.Key9.Focus()
                    Me.Key9.PerformClick()
                End If
                e.Handled = True
        End Select
    End Sub
    Private Sub ButtonExec_Click(sender As Object, e As EventArgs) Handles ButtonExec.Click

        If Mode = 1 Then
            ValueB = InputA.Text
            InputA.Text = ValueA + ValueB
        End If

        If Mode = 2 Then
            ValueB = InputA.Text
            InputA.Text = ValueA - ValueB
        End If

        If Mode = 3 Then
            ValueB = InputA.Text
            InputA.Text = ValueA * ValueB
        End If

        If Mode = 4 Then
            ValueB = InputA.Text
            InputA.Text = ValueA / ValueB
        End If

        If Mode = 5 Then
            ValueB = InputA.Text
            Dim divide As String = ValueA \ ValueB
            Dim reminder As String = ValueA Mod ValueB
            InputA.Text = divide & " 余り " & reminder
        End If

    End Sub

    Private Sub Key0_Click(sender As Object, e As EventArgs) Handles Key0.Click
        If InputA.Text = 0 Then
            InputA.Text = 0
        Else
            InputA.Text += "0"
        End If
    End Sub

    Private Sub Key1_Click(sender As Object, e As EventArgs) Handles Key1.Click
        If InputA.Text = 0 Then
            InputA.Text = 1
        Else
            InputA.Text += "1"
        End If
    End Sub

    Private Sub Key2_Click(sender As Object, e As EventArgs) Handles Key2.Click
        If InputA.Text = 0 Then
            InputA.Text = 2
        Else
            InputA.Text += "2"
        End If
    End Sub

    Private Sub Key3_Click(sender As Object, e As EventArgs) Handles Key3.Click
        If InputA.Text = 0 Then
            InputA.Text = 3
        Else
            InputA.Text += "3"
        End If
    End Sub

    Private Sub Key4_Click(sender As Object, e As EventArgs) Handles Key4.Click
        If InputA.Text = 0 Then
            InputA.Text = 4
        Else
            InputA.Text += "4"
        End If
    End Sub

    Private Sub Key5_Click(sender As Object, e As EventArgs) Handles Key5.Click
        If InputA.Text = 0 Then
            InputA.Text = 5
        Else
            InputA.Text += "5"
        End If
    End Sub

    Private Sub Key6_Click(sender As Object, e As EventArgs) Handles Key6.Click
        If InputA.Text = 0 Then
            InputA.Text = 6
        Else
            InputA.Text += "6"
        End If
    End Sub

    Private Sub Key7_Click(sender As Object, e As EventArgs) Handles Key7.Click
        If InputA.Text = 0 Then
            InputA.Text = 7
        Else
            InputA.Text += "7"
        End If
    End Sub

    Private Sub Key8_Click(sender As Object, e As EventArgs) Handles Key8.Click
        If InputA.Text = 0 Then
            InputA.Text = 8
        Else
            InputA.Text += "8"
        End If
    End Sub

    Private Sub Key9_Click(sender As Object, e As EventArgs) Handles Key9.Click
        If InputA.Text = 0 Then
            InputA.Text = 9
        Else
            InputA.Text += "9"
        End If
    End Sub

    Private Sub KeyDecimalpoint_Click(sender As Object, e As EventArgs) Handles KeyDecimalpoint.Click
        If IsInputDecimalpoint = 1 Then
        End If
        If IsInputDecimalpoint = 0 Then
            InputA.Text += "."
            IsInputDecimalpoint = 1
        End If
    End Sub

    Private Sub KeyC_Click(sender As Object, e As EventArgs) Handles KeyC.Click
        InputA.Text = 0
        ValueA = 0
        ValueB = 0
        Mode = 0
        IsInputDecimalpoint = 0
        ModeLabel.Text = ""
    End Sub

    Private Sub KeyModePlus_Click(sender As Object, e As EventArgs) Handles KeyModePlus.Click
        If Mode = 1 Then
            '何もしない
        Else
            Mode = 1
            ModeLabel.Text = "＋"
            ValueA = InputA.Text
            InputA.Text = 0
        End If
    End Sub

    Private Sub KeyModeMinus_Click(sender As Object, e As EventArgs) Handles KeyModeMinus.Click
        If Mode = 2 Then
            '何もしない
        Else
            Mode = 2
            ModeLabel.Text = "－"
            ValueA = InputA.Text
            InputA.Text = 0
        End If
    End Sub

    Private Sub KeyModeTimes_Click(sender As Object, e As EventArgs) Handles KeyModeTimes.Click
        If Mode = 3 Then
            '何もしない
        Else
            Mode = 3
            ModeLabel.Text = "×"
            ValueA = InputA.Text
            InputA.Text = 0
        End If
    End Sub

    Private Sub KeyModeDivide_Click(sender As Object, e As EventArgs) Handles KeyModeDivide.Click
        If Mode = 4 Then
            '何もしない
        Else
            Mode = 4
            ModeLabel.Text = "÷"
            ValueA = InputA.Text
            InputA.Text = 0
        End If
    End Sub

    Private Sub KeyModeDivideWithRemainder_Click(sender As Object, e As EventArgs) Handles KeyModeDivideWithRemainder.Click
        If Mode = 5 Then
            '何もしない
        Else
            Mode = 5
            ModeLabel.Text = "\"
            ValueA = InputA.Text
            InputA.Text = 0
        End If
    End Sub
End Class

