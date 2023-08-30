Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common

Public Class Form1
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim i As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=CHETANPC1998\SQLEXPRESS;Initial Catalog=ADONET;Integrated Security=True")
        cn.Open()
        MsgBox("DataBase Connected successfully....")
        cn.Close()

        fillList()


    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        cmd = New SqlCommand("INSERT INTO StudentR (prn,Student, Contact, City)
   VALUES(" & Textprn.Text & ",' " & TextStudent.Text & " ' ," & TextContact.Text & ",'" & TextCity.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Recorded Inserted/Save successfullly....")
        fillList()


    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        cmd = New SqlCommand(" UPDATE StudentR SET prn=4 WHERE prn = " & Textprn.Text & " ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Recorded Upadated successfullly....")
        fillList()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        cmd = New SqlCommand("  DELETE FROM StudentR WHERE Contact=" & TextContact.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Recorded Deleted successfullly....")
        fillList()
    End Sub

    Private Sub Buttonretrive_Click(sender As Object, e As EventArgs) Handles Buttonretrive.Click
        cmd = New SqlCommand("  SELECt * FROM StudentR WHERE PRN =" & Textprn.Text & "", cn)
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then

            TextStudent.Text = dr(1)
            TextContact.Text = dr(2)
            TextCity.Text = dr(3)
        Else
            MsgBox("No Record found....")

        End If


        cn.Close()
    End Sub
    Sub fillList()
        ListBox1.Items.Clear()
        cmd = New SqlCommand("  SELECt Student FROM StudentR ", cn)
        cn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            ListBox1.Items.Add(dr(0))
        End While


        cn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonDT.Click
        dt = New DataTable
        da = New SqlDataAdapter

        cmd = New SqlCommand("SELECT * from StudentR", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        cn.Close()


        'Textprn.Text = dt.Rows(0).Item(0)
        'TextStudent.Text = dt.Rows(0).Item(1)
        'TextContact.Text = dt.Rows(0).Item(2)
        'TextCity.Text = dt.Rows(0).Item(3)
        display()

    End Sub

    Sub display()
        Textprn.Text = dt.Rows(i).Item(0)
        TextStudent.Text = dt.Rows(i).Item(1)
        TextContact.Text = dt.Rows(i).Item(2)
        TextCity.Text = dt.Rows(i).Item(3)
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        i = i + 1
        display()

    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        i = i - 1
        display()
    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        i = 0
        display()
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        i = dt.Rows.Count - 1
        display()

    End Sub
End Class
