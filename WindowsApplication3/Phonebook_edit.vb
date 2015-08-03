Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class pbook_edit                 'declare public variables for connecting with database
    Dim con As MySqlConnection
    Dim from As String                  'used to identify the previous form in the event the save button is clicked so as to identify weather to add a new record or update an existing one
    Dim sql As String
    Dim sql_command As MySqlCommand
    Dim sql_reader As MySqlDataReader
    Private Sub can_btn_Click(sender As Object, e As EventArgs) Handles can_btn.Click  'code to go to the previous form
        If from = "addnew" Then
            Home.Show()
            Me.Close()
        ElseIf from = "pbook" Then
            Phonebook.Show()
            Me.Close()
        Else
            Search_result.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pbook_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load   'code to fill the text boxes automatically on form load

        If frm_pbook = True Then      'global variable used to identify the previous form
            from = "pbook"            'used to identify the previous form in the event the save button is clicked so as to identify weather to add a new record or update an existing one
            con = New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;password=akshay;database=plankpro"

            Try
                Dim cm As New MySqlCommand
                cm.CommandText = "select * from plank where phonenumber = @p1"   'sql query to select the record to be shown
                cm.Parameters.AddWithValue("@p1", search_no)    'search parameter
                cm.Connection = con
                con.Open()
                Dim dr As MySqlDataReader
                dr = cm.ExecuteReader
                dr.Read()                                'transfer data from database to data reader "dr"
                si_txt.Text = dr.Item("si_no")           'display data in the respective text boxes
                name_txtbox.Text = dr.Item("name")
                no_txtbox.Text = dr.Item("phonenumber")
                cmpny_txtbox.Text = dr.Item("company")
                mail_txtbox.Text = dr.Item("email")
                adrs_txtbox.Text = dr.Item("address")
                con.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
            frm_pbook = False
        ElseIf frm_search = True Then

            from = "search"                    'used to identify the previous form in the event the save button is clicked so as to decide weather to add a new record or update an existing
            con = New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;password=akshay;database=plankpro"

            Try
                Dim cm As New MySqlCommand
                cm.CommandText = "select * from plank where phonenumber = @p1"      'sql query to select the record to be shown
                cm.Parameters.AddWithValue("@p1", search_no)            'search parameter to be used
                cm.Connection = con
                con.Open()
                Dim dr As MySqlDataReader
                dr = cm.ExecuteReader
                dr.Read()                                      'transfer data from database to data reader "dr"
                si_txt.Text = dr.Item("si_no")                 'display data in the respective text boxes
                name_txtbox.Text = dr.Item("name")
                no_txtbox.Text = dr.Item("phonenumber")
                cmpny_txtbox.Text = dr.Item("company")
                mail_txtbox.Text = dr.Item("email")
                adrs_txtbox.Text = dr.Item("address")
                con.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
            frm_search = False
        Else
            from = "addnew"
            si_txt.Hide()               'hide the serial number text box when a new record is to be added as serial number will automatically populated in the database
            iupload_btn.Hide()          'hide the upload photo button
            delete_btn.Hide()           'hide the delete button
            frm_addnew = False

        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If from = "addnew" Then     'variable used to identify the previous form

            con = New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;password=akshay;database=plankpro"

            Try
                Dim mstream As New System.IO.MemoryStream()                              'code to change the image as byte array and save in the database as blob datatype
                PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg) 'save the image present in the picturebox to the memory stream "mstream"
                Dim arrImage() As Byte = mstream.GetBuffer()                             'save the data in the input output memory stream to the array "arrImage"
                mstream.Close()

                Dim cm As New MySqlCommand
                cm.CommandText = "INSERT INTO plank (name, phonenumber, company, email, address, image) VALUES ('" + name_txtbox.Text + "','" + no_txtbox.Text + "','" + cmpny_txtbox.Text + "','" + mail_txtbox.Text + "','" + adrs_txtbox.Text + "', @image_data)"    'sql command to add new record
                cm.Parameters.AddWithValue("@image_data", arrImage)     'transfer the value in the array "arrImage" to the sql query parameter
                cm.Connection = con
                con.Open()
                cm.ExecuteNonQuery()
                MsgBox("New contact has been added to database")
                Home.Show()
                Me.Close()
                con.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        Else
            con = New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;password=akshay;database=plankpro"

            Try
                Dim cm As New MySqlCommand
                cm.CommandText = "UPDATE plank SET name='" + name_txtbox.Text + "', phonenumber = '" + no_txtbox.Text + "', company = '" + cmpny_txtbox.Text + "', email = '" + mail_txtbox.Text + "', address = '" + adrs_txtbox.Text + "' where si_no = '" + si_txt.Text + "'" 'sql command to add new record
                cm.Connection = con
                con.Open()
                cm.ExecuteNonQuery()
                MsgBox("Contact has been updated successfuly")
                Phonebook.Show()
                Me.Close()
                con.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;password=akshay;database=plankpro"

        Try
            Dim cm As New MySqlCommand
            cm.CommandText = "DELETE FROM plank where si_no = '" + si_txt.Text + "'"    'sql query to delete a record
            cm.Connection = con
            cm.ExecuteNonQuery()
            MsgBox("Contact has been deleted")
            Phonebook.Show()
            Me.Close()
            con.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub iupload_btn_Click(sender As Object, e As EventArgs) Handles iupload_btn.Click    'code to save the image in the database as blob datatype
        Dim FileSize As UInt32

        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)     'save the image present in the picturebox to the memory stream "mstream"
        Dim arrImage() As Byte = mstream.GetBuffer()                                 'save the data in the input output memory stream to the array "arrImage"
        FileSize = mstream.Length
        mstream.Close()

        Try
            sql = "UPDATE plank SET image= @image_data where si_no = '" + si_txt.Text + "'"   'sql query to add image to the database
            sql_command = New MySqlCommand(sql, con)
            sql_command.Parameters.AddWithValue("@image_data", arrImage)             'transfer the value in the array "arrImage" to the sql query parameter
            con.Open()
            sql_command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        MsgBox("Image has been saved.")

    End Sub

    Private Sub ibrowse_btn_Click_1(sender As Object, e As EventArgs) Handles ibrowse_btn.Click
        If OFGSelectImage.ShowDialog = Windows.Forms.DialogResult.OK Then   '"OFGSelectImage" is the open file dialog box used to upload picture to the picturebox
            PictureBox1.Image = Image.FromFile(OFGSelectImage.FileName)     'display the image in the picture box
        End If
    End Sub

End Class