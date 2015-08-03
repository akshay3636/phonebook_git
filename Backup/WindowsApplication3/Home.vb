Public Class Home

    Private Sub s_byname_txt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byname_txt.Click
        s_byname_txt.Text = ""
    End Sub

    Private Sub s_byname_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byname_txt.LostFocus
        s_byname_txt.Text = "Enter a name to search"
    End Sub

    Private Sub s_byname_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s_byname_txt.TextChanged

    End Sub

    Private Sub s_byno_txt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byno_txt.Click
        s_byno_txt.Text = ""
    End Sub

    Private Sub s_byno_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byno_txt.LostFocus
        s_byno_txt.Text = "Enter a number to search"
    End Sub

    Private Sub s_byno_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s_byno_txt.TextChanged

    End Sub

    Private Sub v_phnbook_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_phnbook_btn.Click
        Me.Close()
        Phonebook.Show()
    End Sub
End Class
