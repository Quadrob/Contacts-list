'Author: Robert Zeelie
'Version: 1.0.00
'
'Description: A contacts application that stores the names, emails and countries of up to 10 different people and allows the user to lookup an address based on its index number. This is the menu form where the user can choose the task to perform. This is the edit contact form
Public Class EditForm
    'declare variables
    Public EditedContactList(,) As String = Form1.EditedContactInfo
    Dim IndexNumber As Integer
    Dim isContact As Boolean


    Function DisplayText(Index) As Integer
        'display current contact
        FNameTextBox.Text = EditedContactList(Index, 0)
        LNameTextBox.Text = EditedContactList(Index, 1)
        EmailTextBox.Text = EditedContactList(Index, 2)
        CountryTextBox.Text = EditedContactList(Index, 3)
        Return 0
    End Function

    Function UppercaseFirstLetter(text) As String

        ' Convert to character array.
        Dim ChrArray() As Char = text.ToCharArray

        ' Uppercase first character.
        ChrArray(0) = Char.ToUpper(ChrArray(0))

        ' Return new string.
        Return New String(ChrArray)
    End Function

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        'Show form1 and Set form state
        Form1.FormState = "EditForm"
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        'get value from select up down box to set index
        Try
            IndexNumber = (NumericUpDown1.Value - 1)
            If (EditedContactList(IndexNumber, 0).Length > 0 Or EditedContactList(IndexNumber, 1).Length > 0) Then
                'if index contains attributes display and allow it to be edited by turning enabled to true
                DisplayText(IndexNumber)
                FNameTextBox.Enabled = True
                LNameTextBox.Enabled = True
                EmailTextBox.Enabled = True
                CountryTextBox.Enabled = True
                isContact = True
            Else
                'else user cant edit and display empty in text box
                FNameTextBox.Enabled = False
                LNameTextBox.Enabled = False
                EmailTextBox.Enabled = False
                CountryTextBox.Enabled = False
                FNameTextBox.Text = "Empty..."
                LNameTextBox.Text = "Empty..."
                EmailTextBox.Text = "Empty..."
                CountryTextBox.Text = "Empty..."
                isContact = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If (isContact) Then
            'check if edits are made if data has been changed
            If (EditedContactList(IndexNumber, 0).Equals(UppercaseFirstLetter(FNameTextBox.Text)) AndAlso EditedContactList(IndexNumber, 1).Equals(UppercaseFirstLetter(LNameTextBox.Text)) AndAlso EditedContactList(IndexNumber, 2).Equals(EmailTextBox.Text) AndAlso EditedContactList(IndexNumber, 3).Equals(UppercaseFirstLetter(CountryTextBox.Text))) Then
                MessageBox.Show("No changes were made!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'ask user if the are sure about editing
                Dim ResultFromBox As DialogResult = MessageBox.Show(("Are you sure you want to change contact: " & NumericUpDown1.Value & vbNewLine & "To = " & FNameTextBox.Text & " " & LNameTextBox.Text & " " & EmailTextBox.Text & " " & CountryTextBox.Text), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                'if yes make the edits and display to user
                If (ResultFromBox = DialogResult.Yes) Then
                    EditedContactList(IndexNumber, 0) = UppercaseFirstLetter(FNameTextBox.Text)
                    EditedContactList(IndexNumber, 1) = UppercaseFirstLetter(LNameTextBox.Text)
                    EditedContactList(IndexNumber, 2) = EmailTextBox.Text
                    EditedContactList(IndexNumber, 3) = UppercaseFirstLetter(CountryTextBox.Text)
                    DisplayText(IndexNumber)
                ElseIf (ResultFromBox = DialogResult.No) Then
                    'else tell user nothing done
                    MessageBox.Show("Changes will not be saved!", "Aborting", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("No contact avalible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class