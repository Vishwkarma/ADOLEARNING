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
        Labelprn = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ButtonSave = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        TextStudent = New TextBox()
        TextContact = New TextBox()
        TextCity = New TextBox()
        Textprn = New TextBox()
        Label1 = New Label()
        Buttonretrive = New Button()
        ListBox1 = New ListBox()
        ButtonDT = New Button()
        ButtonFirst = New Button()
        ButtonPrevious = New Button()
        ButtonNext = New Button()
        ButtonLast = New Button()
        SuspendLayout()
        ' 
        ' Labelprn
        ' 
        Labelprn.AutoSize = True
        Labelprn.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Labelprn.Location = New Point(152, 99)
        Labelprn.Name = "Labelprn"
        Labelprn.Size = New Size(38, 17)
        Labelprn.TabIndex = 0
        Labelprn.Text = "PRN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(141, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 17)
        Label2.TabIndex = 0
        Label2.Text = "Student Name "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(152, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 17)
        Label3.TabIndex = 0
        Label3.Text = "Contact "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(152, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 17)
        Label4.TabIndex = 0
        Label4.Text = "City"
        ' 
        ' ButtonSave
        ' 
        ButtonSave.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSave.Location = New Point(70, 335)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(94, 29)
        ButtonSave.TabIndex = 1
        ButtonSave.Text = "SAVE"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonUpdate.Location = New Point(201, 335)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(94, 29)
        ButtonUpdate.TabIndex = 1
        ButtonUpdate.Text = "UPDATE"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonDelete.Location = New Point(348, 335)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(94, 29)
        ButtonDelete.TabIndex = 1
        ButtonDelete.Text = "DELETE"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' TextStudent
        ' 
        TextStudent.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextStudent.Location = New Point(326, 148)
        TextStudent.Name = "TextStudent"
        TextStudent.Size = New Size(188, 25)
        TextStudent.TabIndex = 2
        ' 
        ' TextContact
        ' 
        TextContact.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextContact.Location = New Point(326, 210)
        TextContact.Name = "TextContact"
        TextContact.Size = New Size(188, 25)
        TextContact.TabIndex = 2
        ' 
        ' TextCity
        ' 
        TextCity.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextCity.Location = New Point(326, 265)
        TextCity.Name = "TextCity"
        TextCity.Size = New Size(188, 25)
        TextCity.TabIndex = 2
        ' 
        ' Textprn
        ' 
        Textprn.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Textprn.Location = New Point(326, 96)
        Textprn.Name = "Textprn"
        Textprn.Size = New Size(188, 25)
        Textprn.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 20)
        Label1.TabIndex = 3
        Label1.Text = "student register "
        ' 
        ' Buttonretrive
        ' 
        Buttonretrive.Location = New Point(519, 338)
        Buttonretrive.Name = "Buttonretrive"
        Buttonretrive.Size = New Size(94, 29)
        Buttonretrive.TabIndex = 4
        Buttonretrive.Text = "Retrive"
        Buttonretrive.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(567, 61)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(183, 224)
        ListBox1.TabIndex = 5
        ' 
        ' ButtonDT
        ' 
        ButtonDT.Location = New Point(28, 392)
        ButtonDT.Name = "ButtonDT"
        ButtonDT.Size = New Size(162, 29)
        ButtonDT.TabIndex = 6
        ButtonDT.Text = "DATA TABLE"
        ButtonDT.UseVisualStyleBackColor = True
        ' 
        ' ButtonFirst
        ' 
        ButtonFirst.Location = New Point(234, 409)
        ButtonFirst.Name = "ButtonFirst"
        ButtonFirst.Size = New Size(94, 29)
        ButtonFirst.TabIndex = 7
        ButtonFirst.Text = "<<"
        ButtonFirst.UseVisualStyleBackColor = True
        ' 
        ' ButtonPrevious
        ' 
        ButtonPrevious.Location = New Point(348, 409)
        ButtonPrevious.Name = "ButtonPrevious"
        ButtonPrevious.Size = New Size(94, 29)
        ButtonPrevious.TabIndex = 7
        ButtonPrevious.Text = "<"
        ButtonPrevious.UseVisualStyleBackColor = True
        ' 
        ' ButtonNext
        ' 
        ButtonNext.Location = New Point(474, 409)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(94, 29)
        ButtonNext.TabIndex = 7
        ButtonNext.Text = ">"
        ButtonNext.UseVisualStyleBackColor = True
        ' 
        ' ButtonLast
        ' 
        ButtonLast.Location = New Point(599, 409)
        ButtonLast.Name = "ButtonLast"
        ButtonLast.Size = New Size(94, 29)
        ButtonLast.TabIndex = 7
        ButtonLast.Text = ">>"
        ButtonLast.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonLast)
        Controls.Add(ButtonNext)
        Controls.Add(ButtonPrevious)
        Controls.Add(ButtonFirst)
        Controls.Add(ButtonDT)
        Controls.Add(ListBox1)
        Controls.Add(Buttonretrive)
        Controls.Add(Label1)
        Controls.Add(TextCity)
        Controls.Add(TextContact)
        Controls.Add(Textprn)
        Controls.Add(TextStudent)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonUpdate)
        Controls.Add(ButtonSave)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Labelprn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Labelprn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextStudent As TextBox
    Friend WithEvents TextContact As TextBox
    Friend WithEvents TextCity As TextBox
    Friend WithEvents Textprn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonretrive As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonDT As Button
    Friend WithEvents ButtonFirst As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonLast As Button
End Class
