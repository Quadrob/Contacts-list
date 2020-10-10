'Author: Robert Zeelie
'Version: 1.0.00
'
'Description: A contacts application that stores the names, emails and countries of up to 10 different people and allows the user to lookup an address based on its index number. This is the menu form where the user can choose the task to perform. Also the original contact list is created here with the required info

Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    'Declare variables
    Public EditedContactInfo(,) As String
    Public FormState As String


    Function WriteToFile(Array(,)) As String
        'A simple function used to save changes made to a text file
        'file must exist before it can do this so you can simply create a new empty text file and then edit this path below (FILE_NAME) to a new desired file to save the changes
        Dim FILE_NAME As String = "C:\Users\rober\Documents\EditedContactsFile.txt"

        If (System.IO.File.Exists(FILE_NAME) = True) Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            For index0 = 0 To Array.GetUpperBound(0)
                'Íf statement to make sure the name isnt empty
                If (Array(index0, 0).Length > 0 Or Array(index0, 1).Length > 0) Then
                    'Write to file
                    objWriter.Write((index0 + 1) & " " & Array(index0, 0) & " " & Array(index0, 1) & " " & Array(index0, 2) & " " & Array(index0, 3))
                    objWriter.WriteLine()
                End If
            Next
            objWriter.Close()
            MessageBox.Show("Text written to file: " & FILE_NAME)
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("File: " & FILE_NAME & " Does Not Exist")
        End If
        Return 0
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'a switch case to recieve the changed array from the other forms
        Select Case FormState

            Case "SplashScreen"

                'If statement to check if EditedContact list is empty else populate it with original
                If (EditedContactInfo IsNot Nothing AndAlso EditedContactInfo.Length > 0) Then
                    'Do nothing as it has be inisialized already
                Else
                    EditedContactInfo = SplashScreen1.OriginalContactInfo
                End If

            Case "SearchForm"
                EditedContactInfo = SearchForm.SearchResults

            Case "AddForm"
                EditedContactInfo = AddForm.EditedContactList

            Case "EditForm"
                EditedContactInfo = EditForm.EditedContactList

            Case "DeleteForm"
                EditedContactInfo = DeleteForm.EditedContactList
        End Select

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        'Exit button that displays a goodbye message and exits application
        MessageBox.Show("Thank you for using my contact list application!" & vbNewLine & vbNewLine & vbTab & "**** All added or edited contacts will be lost ****" & vbNewLine & vbNewLine & "In future versions I plan to read and right to a text file to keep changes saved or connect to a database eg: MySQL to prevent data lose! But for now i just have the changes saved to an edit file of the users prefrence." & vbNewLine & vbNewLine & "Thanks, Robert Zeelie", "Goodbye")
        'Save the end result of your editing and addition to the contact list to a file
        WriteToFile(EditedContactInfo)
        Me.Close()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim IsNotEmptyArray As Boolean
        'For look to check if there are any contacts to search
        For index0 = 0 To EditedContactInfo.GetUpperBound(0)
            'Íf statement to make sure the name is empty
            If (EditedContactInfo(index0, 0).Length > 0 Or EditedContactInfo(index0, 1).Length > 0) Then
                IsNotEmptyArray = True
                Exit For
            Else
                IsNotEmptyArray = False
            End If
        Next

        If (IsNotEmptyArray) Then
            'Search button that displays the search form
            SearchForm.Show()
            Me.Close()
        Else
            MessageBox.Show("You do not have any contacts to search, please add contacts?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AddConBtn_Click(sender As Object, e As EventArgs) Handles AddConBtn.Click
        Dim IsEmptyArray As Boolean
        'For look to check if theres space to add a contact
        For index0 = 0 To EditedContactInfo.GetUpperBound(0)
            'Íf statement to make sure the name is empty
            If (EditedContactInfo(index0, 0).Length > 0 Or EditedContactInfo(index0, 1).Length > 0) Then
                IsEmptyArray = True
            Else
                IsEmptyArray = False
                Exit For
            End If
        Next

        If (IsEmptyArray) Then
            MessageBox.Show(("Sorry you can not add another contact because your contact list has 10 contacts already." & vbNewLine & vbNewLine & "To free up space you can go delete a contact"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'displays the add contact form
            AddForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub EditConBtn_Click(sender As Object, e As EventArgs) Handles EditConBtn.Click
        Dim IsNotEmptyArray As Boolean
        'For look to check if there are any contacts to edit
        For index0 = 0 To EditedContactInfo.GetUpperBound(0)
            'Íf statement to make sure the name is empty
            If (EditedContactInfo(index0, 0).Length > 0 Or EditedContactInfo(index0, 1).Length > 0) Then
                IsNotEmptyArray = True
                Exit For
            Else
                IsNotEmptyArray = False
            End If
        Next

        If (IsNotEmptyArray) Then
            'edit contact button that displays the edit contact form
            EditForm.Show()
            Me.Close()
        Else
            MessageBox.Show("You do not have any contacts to Edit, please add contacts?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteConBtn_Click(sender As Object, e As EventArgs) Handles DeleteConBtn.Click
        Dim IsNotEmptyArray As Boolean
        'For look to check if there are any contacts to delete
        For index0 = 0 To EditedContactInfo.GetUpperBound(0)
            'Íf statement to make sure the name is empty
            If (EditedContactInfo(index0, 0).Length > 0 Or EditedContactInfo(index0, 1).Length > 0) Then
                IsNotEmptyArray = True
                Exit For
            Else
                IsNotEmptyArray = False
            End If
        Next
        If (IsNotEmptyArray) Then
            'delete contact button that displays the delete contact form
            DeleteForm.Show()
            Me.Close()
        Else
            MessageBox.Show("You do not have any contacts to delete, please add contacts?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
