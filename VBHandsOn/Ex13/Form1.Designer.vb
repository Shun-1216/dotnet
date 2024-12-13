<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        amountLabel = New Label()
        unitPriceTextBox = New TextBox()
        volumeTextBox = New TextBox()
        calcButton = New Button()
        endButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 0
        Label1.Text = "金額を計算します。"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 1
        Label2.Text = "単価"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 2
        Label3.Text = "個数"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 3
        Label4.Text = "金額"
        ' 
        ' amountLabel
        ' 
        amountLabel.BorderStyle = BorderStyle.Fixed3D
        amountLabel.Location = New Point(119, 158)
        amountLabel.Name = "amountLabel"
        amountLabel.Size = New Size(100, 23)
        amountLabel.TabIndex = 4
        amountLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' unitPriceTextBox
        ' 
        unitPriceTextBox.Location = New Point(119, 69)
        unitPriceTextBox.Name = "unitPriceTextBox"
        unitPriceTextBox.Size = New Size(100, 23)
        unitPriceTextBox.TabIndex = 5
        unitPriceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' volumeTextBox
        ' 
        volumeTextBox.Location = New Point(119, 106)
        volumeTextBox.Name = "volumeTextBox"
        volumeTextBox.Size = New Size(100, 23)
        volumeTextBox.TabIndex = 6
        volumeTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' calcButton
        ' 
        calcButton.Location = New Point(37, 212)
        calcButton.Name = "calcButton"
        calcButton.Size = New Size(75, 23)
        calcButton.TabIndex = 7
        calcButton.Text = "計算"
        calcButton.UseVisualStyleBackColor = True
        ' 
        ' endButton
        ' 
        endButton.Location = New Point(144, 212)
        endButton.Name = "endButton"
        endButton.Size = New Size(75, 23)
        endButton.TabIndex = 8
        endButton.Text = "終了"
        endButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(277, 283)
        Controls.Add(endButton)
        Controls.Add(calcButton)
        Controls.Add(volumeTextBox)
        Controls.Add(unitPriceTextBox)
        Controls.Add(amountLabel)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "金額計算"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents amountLabel As Label
    Friend WithEvents unitPriceTextBox As TextBox
    Friend WithEvents volumeTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents endButton As Button

End Class
