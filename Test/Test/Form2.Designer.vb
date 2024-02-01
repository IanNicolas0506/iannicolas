<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Button3 = New Button()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ImageList1 = New ImageList(components)
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Times New Roman", 14F)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(121, 390)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 37)
        Button3.TabIndex = 17
        Button3.Text = "Return"
        Button3.UseVisualStyleBackColor = False
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
        Label3.Size = New Size(165, 47)
        Label3.TabIndex = 14
        Label3.Text = "Register"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Times New Roman", 14F)
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(74, 292)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(346, 34)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.CausesValidation = False
        TextBox1.Font = New Font("Times New Roman", 14F)
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(74, 241)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(346, 34)
        TextBox1.TabIndex = 12
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(34, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 34)
        Label2.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(34, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 34)
        Label1.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Black
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Times New Roman", 14F)
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(74, 186)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(346, 34)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Black
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.CausesValidation = False
        TextBox4.Font = New Font("Times New Roman", 14F)
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(77, 136)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(346, 34)
        TextBox4.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Image = CType(resources.GetObject("Label5.Image"), Image)
        Label5.Location = New Point(37, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 34)
        Label5.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Image = CType(resources.GetObject("Label6.Image"), Image)
        Label6.Location = New Point(37, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 34)
        Label6.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Times New Roman", 14F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(234, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 37)
        Button1.TabIndex = 25
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(462, 473)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
