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
        username_txt = New TextBox()
        password_txt = New TextBox()
        Label3 = New Label()
        login_btn = New Button()
        register_btn = New Button()
        ImageList1 = New ImageList(components)
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' username_txt
        ' 
        username_txt.BackColor = Color.Black
        username_txt.BorderStyle = BorderStyle.FixedSingle
        username_txt.CausesValidation = False
        username_txt.Font = New Font("Times New Roman", 14F)
        username_txt.ForeColor = Color.White
        username_txt.Location = New Point(66, 225)
        username_txt.Margin = New Padding(3, 2, 3, 2)
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(303, 29)
        username_txt.TabIndex = 0
        ' 
        ' password_txt
        ' 
        password_txt.BackColor = Color.Black
        password_txt.BorderStyle = BorderStyle.FixedSingle
        password_txt.Font = New Font("Times New Roman", 14F)
        password_txt.ForeColor = Color.White
        password_txt.Location = New Point(66, 262)
        password_txt.Margin = New Padding(3, 2, 3, 2)
        password_txt.Name = "password_txt"
        password_txt.PasswordChar = "*"c
        password_txt.Size = New Size(303, 29)
        password_txt.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(10, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 38)
        Label3.TabIndex = 4
        Label3.Text = "Login"
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = Color.Black
        login_btn.Font = New Font("Times New Roman", 14F)
        login_btn.ForeColor = SystemColors.ButtonFace
        login_btn.Location = New Point(217, 292)
        login_btn.Margin = New Padding(3, 2, 3, 2)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(94, 28)
        login_btn.TabIndex = 6
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' register_btn
        ' 
        register_btn.BackColor = Color.Black
        register_btn.Font = New Font("Times New Roman", 14F)
        register_btn.ForeColor = SystemColors.ButtonFace
        register_btn.Location = New Point(118, 292)
        register_btn.Margin = New Padding(3, 2, 3, 2)
        register_btn.Name = "register_btn"
        register_btn.Size = New Size(94, 28)
        register_btn.TabIndex = 8
        register_btn.Text = "Register"
        register_btn.UseVisualStyleBackColor = False
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
        Label1.Location = New Point(31, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 26)
        Label1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(31, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 26)
        Label2.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(129, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 126)
        Label4.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(404, 355)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(register_btn)
        Controls.Add(login_btn)
        Controls.Add(Label3)
        Controls.Add(password_txt)
        Controls.Add(username_txt)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Log-In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents username_txt As TextBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents register_btn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label

End Class
