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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        ImageList1 = New ImageList(components)
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.CausesValidation = False
        TextBox1.Font = New Font("Times New Roman", 14F)
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(75, 300)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(346, 34)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Times New Roman", 14F)
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(75, 350)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(346, 34)
        TextBox2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 47)
        Label3.TabIndex = 4
        Label3.Text = "Login"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Times New Roman", 14F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(248, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 37)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Times New Roman", 14F)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(135, 390)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 37)
        Button3.TabIndex = 8
        Button3.Text = "Register"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(35, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 34)
        Label1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(35, 350)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 34)
        Label2.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(147, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 168)
        Label4.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(462, 473)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Log-In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label

End Class
