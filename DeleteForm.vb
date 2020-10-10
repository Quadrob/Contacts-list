'Author: Robert Zeelie
'Version: 1.0.00
'
'Description: A contacts application that stores the names, emails and countries of up to 10 different people and allows the user to lookup an address based on its index number. This is the menu form where the user can choose the task to perform. This is the delete contact form

Public Class DeleteForm
    'declare variables
    Public EditedContactList(,) As String = Form1.EditedContactInfo
    Dim IndexNumber As Integer
    Dim ThereIsContact As Boolean

    Function DisplayText(Index) As Integer
        'clear results box
        SearchResultListBox.Items.Clear()
        'display current contact
        SearchResultListBox.Items.Add(NumericUpDown1.Value & ": " & EditedContactList(Index, 0) & " " & EditedContactList(Index, 1) & ": " & EditedContactList(Index, 2) & "  |  Country: " & EditedContactList(Index, 3))
        Return 0
    End Function

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        'Show form1 and Set form state
        Form1.FormState = "DeleteForm"
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        'get value from select up down box to set index
        Try
            IndexNumber = (NumericUpDown1.Value - 1)
            If (EditedContactList(IndexNumber, 0).Length > 0 Or EditedContactList(IndexNumber, 1).Length > 0) Then
                'if index contains attributes display them 
                DisplayText(IndexNumber)
                ThereIsContact = True
            Else
                'display empty
                SearchResultListBox.Items.Clear()
                SearchResultListBox.Items.Add("Contact Index: " & NumericUpDown1.Value & " is empty...")
                ThereIsContact = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        'if there is something in 
        If (EditedContactList(IndexNumber, 0).Length > 0 Or EditedContactList(IndexNumber, 1).Length > 0) Then
            'ask user if they are sure
            Dim ResultFromBox As DialogResult = MessageBox.Show(("Are you sure you want to delete contact: " & NumericUpDown1.Value & vbNewLine & EditedContactList(IndexNumber, 0) & " " & EditedContactList(IndexNumber, 1) & " " & EditedContactList(IndexNumber, 2) & " " & EditedContactList(IndexNumber, 3)), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            'if yes proceed
            If (ResultFromBox = DialogResult.Yes) Then
                'empty that contact at selected index and notify user
                EditedContactList(IndexNumber, 0) = ""
                EditedContactList(IndexNumber, 1) = ""
                EditedContactList(IndexNumber, 2) = ""
                EditedContactList(IndexNumber, 3) = ""
                SearchResultListBox.Items.Clear()
                SearchResultListBox.Items.Add("Contact Index: " & NumericUpDown1.Value & " has been deleted!")
            ElseIf (ResultFromBox = DialogResult.No) Then
                'else if no dont delete contact
                MessageBox.Show("Contact will not be deleted!", "Aborting", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'else tell user there is no contact to delete
        Else
            MessageBox.Show("There is no contact to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class