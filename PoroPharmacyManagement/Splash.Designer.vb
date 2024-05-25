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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Timer1 = New Timer(components)
        Myprogressbar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(275, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 39)
        Label1.TabIndex = 0
        Label1.Text = "PoroPharmaCenter"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 277)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(748, 44)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(316, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 15)
        Label2.TabIndex = 0
        Label2.Text = "DesignedByChechoEl"
        ' 
        ' Timer1
        ' 
        ' 
        ' Myprogressbar
        ' 
        Myprogressbar.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        Myprogressbar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Myprogressbar.ForeColor = Color.White
        Myprogressbar.Location = New Point(316, 105)
        Myprogressbar.Minimum = 0
        Myprogressbar.Name = "Myprogressbar"
        Myprogressbar.ProgressColor = Color.Navy
        Myprogressbar.ProgressColor2 = Color.DarkMagenta
        Myprogressbar.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Myprogressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Myprogressbar.Size = New Size(130, 130)
        Myprogressbar.TabIndex = 4
        Myprogressbar.Text = "Guna2CircleProgressBar1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrchid
        ClientSize = New Size(748, 321)
        Controls.Add(Myprogressbar)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Myprogressbar As Guna.UI2.WinForms.Guna2CircleProgressBar

End Class
