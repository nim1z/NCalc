Public Class Form1
    Public ValueA As Double = 0
    Public ValueB As Double = 0
    Public Mode As Integer = 0
    Public IsInputDecimalpoint As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ロード時にフォーカスを設定する
        ActiveControl = ButtonExec
        'フォームが先にキーを受け取る設定
        KeyPreview = True
        InputA.Text = 0
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Oemplus
                If KeyModePlus.Enabled = True Then
                    KeyModePlus.Focus()
                    KeyModePlus.PerformClick()
                End If
            Case Keys.OemMinus
                If KeyModeMinus.Enabled = True Then
                    KeyModeMinus.Focus()
                    KeyModeMinus.PerformClick()
                End If
            Case Keys.Multiply
                If KeyModeTimes.Enabled = True Then
                    KeyModeTimes.Focus()
                    KeyModeTimes.PerformClick()
                End If
            Case Keys.Divide
                If KeyModeDivide.Enabled = True Then
                    KeyModeDivide.Focus()
                    KeyModeDivide.PerformClick()
                End If
            Case Keys.OemBackslash
                If KeyModeDivideWithRemainder.Enabled = True Then
                    KeyModeDivideWithRemainder.Focus()
                    KeyModeDivideWithRemainder.PerformClick()
                End If
            Case Keys.Back
                If KeyC.Enabled = True Then
                    KeyC.Focus()
                    KeyC.PerformClick()
                End If

            Case Keys.Decimal
                If Key1.Enabled = True Then
                    KeyDecimalpoint.Focus()
                    KeyDecimalpoint.PerformClick()
                End If
            Case Keys.NumPad0, Keys.D0
                If Key1.Enabled = True Then
                    Key1.Focus()
                    Key1.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad1, Keys.D1
                If Key1.Enabled = True Then
                    Key1.Focus()
                    Key1.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad2, Keys.D2
                If Key2.Enabled = True Then
                    Key2.Focus()
                    Key2.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad3, Keys.D3
                If Key3.Enabled = True Then
                    Key3.Focus()
                    Key3.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad4, Keys.D4
                If Key4.Enabled = True Then
                    Key4.Focus()
                    Key4.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad5, Keys.D5
                If Key5.Enabled = True Then
                    Key5.Focus()
                    Key5.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad6, Keys.D6
                If Key6.Enabled = True Then
                    Key6.Focus()
                    Key6.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad7, Keys.D7
                If Key7.Enabled = True Then
                    Key7.Focus()
                    Key7.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad8, Keys.D8
                If Key8.Enabled = True Then
                    Key8.Focus()
                    Key8.PerformClick()
                    ActiveControl = ButtonExec
                End If
            Case Keys.NumPad9, Keys.D9
                If Key9.Enabled = True Then
                    Key9.Focus()
                    Key9.PerformClick()
                    ActiveControl = ButtonExec
                End If
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

