<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        txt_math = New TextBox()
        txt_english = New TextBox()
        txt_pe = New TextBox()
        txt_science = New TextBox()
        math = New Label()
        english = New Label()
        science = New Label()
        Label4 = New Label()
        btn_Evaluate = New Button()
        SuspendLayout()
        ' 
        ' txt_math
        ' 
        txt_math.Font = New Font("Times New Roman", 18F)
        txt_math.Location = New Point(12, 39)
        txt_math.Name = "txt_math"
        txt_math.Size = New Size(216, 35)
        txt_math.TabIndex = 0
        ' 
        ' txt_english
        ' 
        txt_english.Font = New Font("Times New Roman", 18F)
        txt_english.Location = New Point(12, 121)
        txt_english.Name = "txt_english"
        txt_english.Size = New Size(216, 35)
        txt_english.TabIndex = 1
        ' 
        ' txt_pe
        ' 
        txt_pe.Font = New Font("Times New Roman", 18F)
        txt_pe.Location = New Point(12, 285)
        txt_pe.Name = "txt_pe"
        txt_pe.Size = New Size(216, 35)
        txt_pe.TabIndex = 2
        ' 
        ' txt_science
        ' 
        txt_science.Font = New Font("Times New Roman", 18F)
        txt_science.Location = New Point(12, 203)
        txt_science.Name = "txt_science"
        txt_science.Size = New Size(216, 35)
        txt_science.TabIndex = 3
        ' 
        ' math
        ' 
        math.AutoSize = True
        math.Font = New Font("Times New Roman", 18F)
        math.Location = New Point(12, 9)
        math.Name = "math"
        math.Size = New Size(63, 27)
        math.TabIndex = 4
        math.Text = "Math"
        ' 
        ' english
        ' 
        english.AutoSize = True
        english.Font = New Font("Times New Roman", 18F)
        english.Location = New Point(12, 91)
        english.Name = "english"
        english.Size = New Size(83, 27)
        english.TabIndex = 5
        english.Text = "English"
        ' 
        ' science
        ' 
        science.AutoSize = True
        science.Font = New Font("Times New Roman", 18F)
        science.Location = New Point(12, 173)
        science.Name = "science"
        science.Size = New Size(86, 27)
        science.TabIndex = 6
        science.Text = "Science"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 18F)
        Label4.Location = New Point(12, 255)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 27)
        Label4.TabIndex = 7
        Label4.Text = "PE"
        ' 
        ' btn_Evaluate
        ' 
        btn_Evaluate.Font = New Font("Times New Roman", 18F)
        btn_Evaluate.Location = New Point(12, 326)
        btn_Evaluate.Name = "btn_Evaluate"
        btn_Evaluate.Size = New Size(216, 45)
        btn_Evaluate.TabIndex = 9
        btn_Evaluate.Text = "Evaluate"
        btn_Evaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(244, 391)
        Controls.Add(btn_Evaluate)
        Controls.Add(Label4)
        Controls.Add(science)
        Controls.Add(english)
        Controls.Add(math)
        Controls.Add(txt_science)
        Controls.Add(txt_pe)
        Controls.Add(txt_english)
        Controls.Add(txt_math)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Grade Evaluation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_math As TextBox
    Friend WithEvents txt_english As TextBox
    Friend WithEvents txt_pe As TextBox
    Friend WithEvents txt_science As TextBox
    Friend WithEvents math As Label
    Friend WithEvents english As Label
    Friend WithEvents science As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Evaluate As Button

End Class
