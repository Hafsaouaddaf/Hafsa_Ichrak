Public Class Form2
    'Nourriture
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
        Form1.Close()
        Me.Close()
        Form4.close()
        form5.close()
        form6.close()
        form7.close()


        PNourr.Visible = True
        PAccess.Visible = False
        PPanier.Visible = False
        PAdop.Visible = False
        PCont.Visible = False
    End Sub
    'Accesoires
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        form4.show()
        Form1.Close()
        Me.Close()
        Form3.Close()
        form5.close()
        form6.close()
        Form7.Close()

        PNourr.Visible = False
        PAccess.Visible = True
        PPanier.Visible = False
        PAdop.Visible = False
        PCont.Visible = False
    End Sub
    'panier
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        form5.show()
        Form1.Close()
        Me.Close()
        Form4.close()
        Form3.Close()
        form6.close()
        form7.close()

        PNourr.Visible = False
        PAccess.Visible = False
        PPanier.Visible = True
        PAdop.Visible = False
        PCont.Visible = False
    End Sub
    'Adoption 
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        form6.show()
        Form1.Close()
        Me.Close()
        Form4.close()
        form5.close()
        Form3.Close()
        form7.close()

        PNourr.Visible = False
        PAccess.Visible = False
        PPanier.Visible = False
        PAdop.Visible = True
        PCont.Visible = False
    End Sub
    'contact
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        form7.show()
        Form1.Close()
        Me.Close()
        Form4.close()
        form5.close()
        form6.close()
        Form3.Close()

        PNourr.Visible = False
        PAccess.Visible = False
        PPanier.Visible = False
        PAdop.Visible = False
        PCont.Visible = True

    End Sub
End Class