<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConnexion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnconnexion = New System.Windows.Forms.Button()
        Me.txtconnexion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmotdepasse = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acceder a votre compte"
        '
        'Btnconnexion
        '
        Me.Btnconnexion.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btnconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnconnexion.ForeColor = System.Drawing.Color.Black
        Me.Btnconnexion.Location = New System.Drawing.Point(139, 260)
        Me.Btnconnexion.Name = "Btnconnexion"
        Me.Btnconnexion.Size = New System.Drawing.Size(136, 41)
        Me.Btnconnexion.TabIndex = 1
        Me.Btnconnexion.Text = "Se Connecter"
        Me.Btnconnexion.UseVisualStyleBackColor = False
        '
        'txtconnexion
        '
        Me.txtconnexion.BackColor = System.Drawing.Color.Navy
        Me.txtconnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtconnexion.ForeColor = System.Drawing.Color.Transparent
        Me.txtconnexion.Location = New System.Drawing.Point(16, 113)
        Me.txtconnexion.Name = "txtconnexion"
        Me.txtconnexion.Size = New System.Drawing.Size(360, 25)
        Me.txtconnexion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(112, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "nom d'utilisateur/identifiant"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(160, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "mot de passe "
        '
        'txtmotdepasse
        '
        Me.txtmotdepasse.AllowDrop = True
        Me.txtmotdepasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtmotdepasse.BackColor = System.Drawing.Color.Navy
        Me.txtmotdepasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmotdepasse.ForeColor = System.Drawing.Color.Transparent
        Me.txtmotdepasse.Location = New System.Drawing.Point(16, 205)
        Me.txtmotdepasse.Name = "txtmotdepasse"
        Me.txtmotdepasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmotdepasse.Size = New System.Drawing.Size(360, 25)
        Me.txtmotdepasse.TabIndex = 5
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(140, 341)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(143, 17)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "mot de passe oublié ?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.txtconnexion)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btnconnexion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtmotdepasse)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(462, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 434)
        Me.Panel1.TabIndex = 10
        '
        'FormConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1291, 520)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormConnexion"
        Me.Text = "connexion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btnconnexion As System.Windows.Forms.Button
    Friend WithEvents txtconnexion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmotdepasse As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
