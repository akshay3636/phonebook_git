Imports MySql.Data.MySqlClient
Public Class Phonebook
    Dim con As MySqlConnection = New MySqlConnection("datasource=localhost;database=plankpro;user id=root;password=akshay") 'declare data connection, data set, data view and currency manager
    Dim ds As DataSet = New DataSet
    Dim dataadapter As New MySqlDataAdapter("select * from plank", con)

    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As MySqlDataReader

    Public Sub filldatasetandview()   'fill the data set, data view and currency manager with the data from our  table plank
        ds = New DataSet
        dataadapter.Fill(ds, "plank")
        dv = New DataView(ds.Tables("plank"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
    End Sub
    Public Sub bindfields()    'clear and then bind the labels with the data from database using the dataview creater earlier
        nam_lbl.DataBindings.Clear()
        no_lbl.DataBindings.Clear()
        c_lbl.DataBindings.Clear()
        mail_lbl.DataBindings.Clear()
        a_lbl.DataBindings.Clear()
        si_lbl.DataBindings.Clear()
        nam_lbl.DataBindings.Add("text", dv, "name")
        no_lbl.DataBindings.Add("text", dv, "phonenumber")
        c_lbl.DataBindings.Add("text", dv, "company")
        mail_lbl.DataBindings.Add("text", dv, "email")
        a_lbl.DataBindings.Add("text", dv, "address")
        si_lbl.DataBindings.Add("text", dv, "si_no")
    End Sub
    Private Sub phonebook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load  'execute the three functions to fill the dataview, bind labels to dataview and load the image of the contact

        filldatasetandview()
        bindfields()
        img_load()


    End Sub

    Private Sub Previous_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Previous_btn.Click
        cm.Position = cm.Position - 1 'change the currency manager value to go to the previous record
        img_load()
    End Sub

    Private Sub next_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_btn.Click
        cm.Position = cm.Position + 1   'change the currency manager value to go to the next record
        img_load()


    End Sub

    Private Sub lcntct_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lcntct_btn.Click
        cm.Position = cm.Count - 1   'change the currency manager value to go to the last record
        img_load()
    End Sub

    Private Sub fcntct_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fcntct_btn.Click
        cm.Position = 0    'change the currency manager value to go to the first record
        img_load()
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click   'go back to the "home" form
        Home.Show()
        Me.Close()
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click   'go to "phonebook_edit" form
        search_no = no_lbl.Text    'global variable used to populate data in the text boxes on the form "phonebook_edit"
        frm_pbook = True           'global variable used to identify in the "phonebook_edit" that the form load request is from this form so that the relevant data can be loaded in the form load event in form "phonebook_edit"
        pbook_edit.Show()
        Me.Close()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        End
    End Sub
    Private Sub img_load()                                          'code to load the image
        Dim cmd As New MySqlCommand
        Dim identify As String
        identify = nam_lbl.Text                                     'load the value in text box "nam_lbl.text" in the variable "identify"
        cmd.CommandText = "select * from plank where name = @p1"    'sql query to identify the record from whare the image is to be fetched
        cmd.Parameters.AddWithValue("@p1", identify)
        cmd.Connection = con
        con.Open()
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Dim arrImage() As Byte                                      'declare the variable "arrimage" as byte to load the binary data of the image from the database 

        arrImage = dr.Item("image")                                 'load the image as binary data in the variable "arrimage"
        Dim mstream As New System.IO.MemoryStream(arrImage)
        cntct_picbox.Image = Image.FromStream(mstream)              'load the image in the picture box "cntct_picbox"
        con.Close()
    End Sub
End Class