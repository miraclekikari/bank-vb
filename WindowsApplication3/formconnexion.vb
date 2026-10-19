Imports System.Data.OleDb

Public Class FormConnexion

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles Btnconnexion.Click

        If txtconnexion.Text = "" Or txtmotdepasse.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim requete As String = "SELECT * FROM Client WHERE (Emai=l? OR Telephone=?) AND MotDePasse=?"
            Dim cmd As New OleDbCommand(requete, conn)
            cmd.Parameters.AddWithValue("@login1", txtconnexion.Text)
            cmd.Parameters.AddWithValue("@login2", txtconnexion.Text)
            cmd.Parameters.AddWithValue("@pass", txtmotdepasse.Text)

            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim principal As New formaccueil()
                principal.Show()
                Me.Hide()
            Else
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Erreur de connexion : " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub lnkCreerCompte_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCreerCompte.LinkClicked
        Dim admin As New formadministraction()
        admin.Show()
        Me.Hide()
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub
End Class
Private Sub txtmotdepasse_TextChanged(sender As Object, e As EventArgs) Handles txtmotdepasse.TextChanged

End Sub
End Class
