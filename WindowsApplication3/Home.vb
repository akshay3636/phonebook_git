﻿Public Class Home

    Private Sub s_byname_txt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byname_txt.Click
        If s_byname_txt.Text = "Enter the name to search" Then  'code to empty the text box "s_byname_txt" on click
            s_byname_txt.Text = ""
            s_byname_txt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub s_byname_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byname_txt.LostFocus
        If s_byname_txt.Text = "" Then  'code to set the dufault text and color
            s_byname_txt.Text = "Enter the name to search"
            s_byname_txt.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub s_byno_txt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles s_byno_txt.Click
        If s_byno_txt.Text = "Enter the number to search" Then  'code to empty the text box "s_byname_txt" on click
            s_byno_txt.Text = ""
            s_byno_txt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub v_phnbook_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_phnbook_btn.Click
        Phonebook.Show()    'open form "phonebook" when this button is clicked
        Me.Hide()
    End Sub

    Private Sub new_cntct_btn_Click(sender As Object, e As EventArgs) Handles new_cntct_btn.Click
        pbook_edit.Show()     'open form "phonebook_edit" when this button is clicked to add new contact
        Me.Hide()
        frm_addnew = True     'set this global varable to true. It will help us know in form "phonebook_edit" that it was opened from "home" form so that all the text boxes are made empty
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Dim fname, pno As String
        fname = (s_byname_txt.Text)  'store the string in textbox "s_byname_txt" in variable "fname"
        pno = (s_byno_txt.Text)      'store the string in textbox "s_byno_txt" in variable "pno"
        If (fname <> "" And fname <> "Enter the name to search") And (pno = "" Or pno = "Enter the number to search") Then  'condition for search by name
            search_name = fname      'transfer the value of variable "fname" to a global variable "search_name" to be used on "search result" form for search
            by_name = True           'set the value of global variable "by_name" as true. It will be used to decide weather to search by name or number in "search result" form 
            Search_result.Show()
            Me.Close()
        ElseIf (pno <> "" And pno <> "Enter the number to search") And (fname = "" Or fname = "Enter the name to search") Then  'condition for search by number
            search_no = pno          ''transfer the value of variable "pno" to a global variable "search_no" to be used on "search result" form for search
            Search_result.Show()
            Me.Close()
        Else
            MsgBox("Please enter a valid query in any one of the text boxes.") 'error message
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        s_byname_txt.Text = "Enter the name to search"  'set the default text and color in both the text boxes
        s_byname_txt.ForeColor = Color.DarkGray
        s_byno_txt.Text = "Enter the number to search"
        s_byno_txt.ForeColor = Color.DarkGray
    End Sub

    Private Sub s_byno_txt_LostFocus(sender As Object, e As EventArgs) Handles s_byno_txt.LostFocus
        If s_byno_txt.Text = "" Then  'code to set the dufault text and color
            s_byno_txt.Text = "Enter the number to search"
            s_byno_txt.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        End
    End Sub

End Class
