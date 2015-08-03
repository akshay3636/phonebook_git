﻿Imports MySql.Data.MySqlClient
Public Class Search_result
    Dim con As MySqlConnection   'declare variables used for connecting to the database
    Dim sql As String
    Dim sql_command As MySqlCommand
    Dim sql_reader As MySqlDataReader
    Public i As Integer

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        End
    End Sub

    Private Sub Search_result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;password=akshay;database=plankpro"

        Try
            If by_name = True Then
                Dim cm As New MySqlCommand
                cm.CommandText = "select * from plank where name = @p1"     'sql query to search for the search term
                cm.Parameters.AddWithValue("@p1", search_name)              'assign the search term "search_name" to the sql query parameter
                cm.Connection = con
                con.Open()
                Dim dr As MySqlDataReader
                dr = cm.ExecuteReader
                dr.Read()
                si_lbl.Text = dr.Item("si_no")                               'populate the text boxes with data from the database 
                nam_lbl.Text = dr.Item("name")
                no_lbl.Text = dr.Item("phonenumber")
                c_lbl.Text = dr.Item("company")
                mail_lbl.Text = dr.Item("email")
                a_lbl.Text = dr.Item("address")


                Dim arrImage() As Byte                         'code to load the contact image in the picture box
                Try

                    arrImage = dr.Item("image")                'load the image from the database to the array "arrImage"
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    cntct_picbox.Image = Image.FromStream(mstream)   'load the picture in the picture box


                Catch ex As MySqlException

                End Try
                con.Close()
                by_name = False
            Else
                Dim cm As New MySqlCommand
                cm.CommandText = "select * from plank where phonenumber = @p1"    'sql query to search for the search term
                cm.Parameters.AddWithValue("@p1", search_no)                      'assign the search term "search_name" to the sql query parameter
                cm.Connection = con
                con.Open()
                Dim dr As MySqlDataReader
                dr = cm.ExecuteReader
                dr.Read()
                si_lbl.Text = dr.Item("si_no")                                     'populate the text boxes with data from the database
                nam_lbl.Text = dr.Item("name")
                no_lbl.Text = dr.Item("phonenumber")
                c_lbl.Text = dr.Item("company")
                mail_lbl.Text = dr.Item("email")
                a_lbl.Text = dr.Item("address")

                Dim arrImage() As Byte                                             'code to load the contact image in the picture box
                Try

                    arrImage = dr.Item("image")                                    'load the image from the database to the array "arrImage"
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    cntct_picbox.Image = Image.FromStream(mstream)                 'load the picture in the picture box


                Catch ex As MySqlException

                End Try
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("entry not found")
            Phonebook.Show()
            Me.Close()
        End Try

    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        search_no = no_lbl.Text
        frm_search = True        'global variable declared so that in the form "phonebook_edit" the calling form can be identified
        pbook_edit.Show()
        Me.Hide()
    End Sub
End Class