<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputA = New System.Windows.Forms.TextBox()
        Me.ButtonExec = New System.Windows.Forms.Button()
        Me.KeyModePlus = New System.Windows.Forms.Button()
        Me.ModeLabel = New System.Windows.Forms.Label()
        Me.Key0 = New System.Windows.Forms.Button()
        Me.Key1 = New System.Windows.Forms.Button()
        Me.Key2 = New System.Windows.Forms.Button()
        Me.Key3 = New System.Windows.Forms.Button()
        Me.Key4 = New System.Windows.Forms.Button()
        Me.Key5 = New System.Windows.Forms.Button()
        Me.Key6 = New System.Windows.Forms.Button()
        Me.Key7 = New System.Windows.Forms.Button()
        Me.Key8 = New System.Windows.Forms.Button()
        Me.Key9 = New System.Windows.Forms.Button()
        Me.KeyDecimalpoint = New System.Windows.Forms.Button()
        Me.KeyC = New System.Windows.Forms.Button()
        Me.KeyModeMinus = New System.Windows.Forms.Button()
        Me.KeyModeTimes = New System.Windows.Forms.Button()
        Me.KeyModeDivide = New System.Windows.Forms.Button()
        Me.KeyModeDivideWithRemainder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputA
        '
        Me.InputA.BackColor = System.Drawing.SystemColors.Window
        Me.InputA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputA.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.InputA.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.InputA.Location = New System.Drawing.Point(12, 12)
        Me.InputA.MaxLength = 65536
        Me.InputA.Name = "InputA"
        Me.InputA.ReadOnly = True
        Me.InputA.Size = New System.Drawing.Size(200, 34)
        Me.InputA.TabIndex = 0
        Me.InputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.InputA.WordWrap = False
        '
        'ButtonExec
        '
        Me.ButtonExec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonExec.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonExec.Location = New System.Drawing.Point(177, 193)
        Me.ButtonExec.Name = "ButtonExec"
        Me.ButtonExec.Size = New System.Drawing.Size(35, 36)
        Me.ButtonExec.TabIndex = 1
        Me.ButtonExec.Text = "="
        Me.ButtonExec.UseVisualStyleBackColor = True
        '
        'KeyModePlus
        '
        Me.KeyModePlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyModePlus.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyModePlus.Location = New System.Drawing.Point(135, 67)
        Me.KeyModePlus.Name = "KeyModePlus"
        Me.KeyModePlus.Size = New System.Drawing.Size(35, 36)
        Me.KeyModePlus.TabIndex = 2
        Me.KeyModePlus.Text = "+"
        Me.KeyModePlus.UseVisualStyleBackColor = True
        '
        'ModeLabel
        '
        Me.ModeLabel.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ModeLabel.Location = New System.Drawing.Point(177, 109)
        Me.ModeLabel.Name = "ModeLabel"
        Me.ModeLabel.Size = New System.Drawing.Size(35, 36)
        Me.ModeLabel.TabIndex = 3
        Me.ModeLabel.Text = " "
        '
        'Key0
        '
        Me.Key0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key0.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key0.Location = New System.Drawing.Point(12, 193)
        Me.Key0.Name = "Key0"
        Me.Key0.Size = New System.Drawing.Size(35, 36)
        Me.Key0.TabIndex = 4
        Me.Key0.Text = "0"
        Me.Key0.UseVisualStyleBackColor = True
        '
        'Key1
        '
        Me.Key1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key1.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key1.Location = New System.Drawing.Point(12, 151)
        Me.Key1.Name = "Key1"
        Me.Key1.Size = New System.Drawing.Size(35, 36)
        Me.Key1.TabIndex = 5
        Me.Key1.Text = "1"
        Me.Key1.UseVisualStyleBackColor = True
        '
        'Key2
        '
        Me.Key2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key2.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key2.Location = New System.Drawing.Point(53, 151)
        Me.Key2.Name = "Key2"
        Me.Key2.Size = New System.Drawing.Size(35, 36)
        Me.Key2.TabIndex = 6
        Me.Key2.Text = "2"
        Me.Key2.UseVisualStyleBackColor = True
        '
        'Key3
        '
        Me.Key3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key3.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key3.Location = New System.Drawing.Point(94, 151)
        Me.Key3.Name = "Key3"
        Me.Key3.Size = New System.Drawing.Size(35, 36)
        Me.Key3.TabIndex = 7
        Me.Key3.Text = "3"
        Me.Key3.UseVisualStyleBackColor = True
        '
        'Key4
        '
        Me.Key4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key4.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key4.Location = New System.Drawing.Point(12, 109)
        Me.Key4.Name = "Key4"
        Me.Key4.Size = New System.Drawing.Size(35, 36)
        Me.Key4.TabIndex = 8
        Me.Key4.Text = "4"
        Me.Key4.UseVisualStyleBackColor = True
        '
        'Key5
        '
        Me.Key5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key5.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key5.Location = New System.Drawing.Point(53, 109)
        Me.Key5.Name = "Key5"
        Me.Key5.Size = New System.Drawing.Size(35, 36)
        Me.Key5.TabIndex = 9
        Me.Key5.Text = "5"
        Me.Key5.UseVisualStyleBackColor = True
        '
        'Key6
        '
        Me.Key6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key6.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key6.Location = New System.Drawing.Point(94, 109)
        Me.Key6.Name = "Key6"
        Me.Key6.Size = New System.Drawing.Size(35, 36)
        Me.Key6.TabIndex = 10
        Me.Key6.Text = "6"
        Me.Key6.UseVisualStyleBackColor = True
        '
        'Key7
        '
        Me.Key7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key7.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key7.Location = New System.Drawing.Point(12, 67)
        Me.Key7.Name = "Key7"
        Me.Key7.Size = New System.Drawing.Size(35, 36)
        Me.Key7.TabIndex = 11
        Me.Key7.Text = "7"
        Me.Key7.UseVisualStyleBackColor = True
        '
        'Key8
        '
        Me.Key8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key8.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key8.Location = New System.Drawing.Point(53, 67)
        Me.Key8.Name = "Key8"
        Me.Key8.Size = New System.Drawing.Size(35, 36)
        Me.Key8.TabIndex = 12
        Me.Key8.Text = "8"
        Me.Key8.UseVisualStyleBackColor = True
        '
        'Key9
        '
        Me.Key9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Key9.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Key9.Location = New System.Drawing.Point(94, 67)
        Me.Key9.Name = "Key9"
        Me.Key9.Size = New System.Drawing.Size(35, 36)
        Me.Key9.TabIndex = 13
        Me.Key9.Text = "9"
        Me.Key9.UseVisualStyleBackColor = True
        '
        'KeyDecimalpoint
        '
        Me.KeyDecimalpoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyDecimalpoint.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyDecimalpoint.Location = New System.Drawing.Point(53, 193)
        Me.KeyDecimalpoint.Name = "KeyDecimalpoint"
        Me.KeyDecimalpoint.Size = New System.Drawing.Size(35, 36)
        Me.KeyDecimalpoint.TabIndex = 14
        Me.KeyDecimalpoint.Text = "."
        Me.KeyDecimalpoint.UseVisualStyleBackColor = True
        '
        'KeyC
        '
        Me.KeyC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyC.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyC.Location = New System.Drawing.Point(177, 151)
        Me.KeyC.Name = "KeyC"
        Me.KeyC.Size = New System.Drawing.Size(35, 36)
        Me.KeyC.TabIndex = 15
        Me.KeyC.Text = "C"
        Me.KeyC.UseVisualStyleBackColor = True
        '
        'KeyModeMinus
        '
        Me.KeyModeMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyModeMinus.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyModeMinus.Location = New System.Drawing.Point(135, 109)
        Me.KeyModeMinus.Name = "KeyModeMinus"
        Me.KeyModeMinus.Size = New System.Drawing.Size(35, 36)
        Me.KeyModeMinus.TabIndex = 16
        Me.KeyModeMinus.Text = "-"
        Me.KeyModeMinus.UseVisualStyleBackColor = True
        '
        'KeyModeTimes
        '
        Me.KeyModeTimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyModeTimes.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyModeTimes.Location = New System.Drawing.Point(135, 151)
        Me.KeyModeTimes.Name = "KeyModeTimes"
        Me.KeyModeTimes.Size = New System.Drawing.Size(35, 36)
        Me.KeyModeTimes.TabIndex = 17
        Me.KeyModeTimes.Text = "×"
        Me.KeyModeTimes.UseVisualStyleBackColor = True
        '
        'KeyModeDivide
        '
        Me.KeyModeDivide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyModeDivide.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyModeDivide.Location = New System.Drawing.Point(135, 193)
        Me.KeyModeDivide.Name = "KeyModeDivide"
        Me.KeyModeDivide.Size = New System.Drawing.Size(35, 36)
        Me.KeyModeDivide.TabIndex = 18
        Me.KeyModeDivide.Text = "÷"
        Me.KeyModeDivide.UseVisualStyleBackColor = True
        '
        'KeyModeDivideWithRemainder
        '
        Me.KeyModeDivideWithRemainder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.KeyModeDivideWithRemainder.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyModeDivideWithRemainder.Location = New System.Drawing.Point(94, 193)
        Me.KeyModeDivideWithRemainder.Name = "KeyModeDivideWithRemainder"
        Me.KeyModeDivideWithRemainder.Size = New System.Drawing.Size(35, 36)
        Me.KeyModeDivideWithRemainder.TabIndex = 19
        Me.KeyModeDivideWithRemainder.Text = "\"
        Me.KeyModeDivideWithRemainder.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(224, 241)
        Me.Controls.Add(Me.KeyModeDivideWithRemainder)
        Me.Controls.Add(Me.KeyModeDivide)
        Me.Controls.Add(Me.KeyModeTimes)
        Me.Controls.Add(Me.KeyModeMinus)
        Me.Controls.Add(Me.KeyC)
        Me.Controls.Add(Me.KeyDecimalpoint)
        Me.Controls.Add(Me.Key9)
        Me.Controls.Add(Me.Key8)
        Me.Controls.Add(Me.Key7)
        Me.Controls.Add(Me.Key6)
        Me.Controls.Add(Me.Key5)
        Me.Controls.Add(Me.Key4)
        Me.Controls.Add(Me.Key3)
        Me.Controls.Add(Me.Key2)
        Me.Controls.Add(Me.Key1)
        Me.Controls.Add(Me.Key0)
        Me.Controls.Add(Me.ModeLabel)
        Me.Controls.Add(Me.KeyModePlus)
        Me.Controls.Add(Me.ButtonExec)
        Me.Controls.Add(Me.InputA)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputA As TextBox
    Friend WithEvents ButtonExec As Button
    Friend WithEvents KeyModePlus As Button
    Friend WithEvents ModeLabel As Label
    Friend WithEvents Key0 As Button
    Friend WithEvents Key1 As Button
    Friend WithEvents Key2 As Button
    Friend WithEvents Key3 As Button
    Friend WithEvents Key4 As Button
    Friend WithEvents Key5 As Button
    Friend WithEvents Key6 As Button
    Friend WithEvents Key7 As Button
    Friend WithEvents Key8 As Button
    Friend WithEvents Key9 As Button
    Friend WithEvents KeyDecimalpoint As Button
    Friend WithEvents KeyC As Button
    Friend WithEvents KeyModeMinus As Button
    Friend WithEvents KeyModeTimes As Button
    Friend WithEvents KeyModeDivide As Button
    Friend WithEvents KeyModeDivideWithRemainder As Button
End Class
