'Author: Robert Zeelie
'Version: 1.0.00
'
'Description: A contacts application that stores the names, emails and countries of up to 10 different people and allows the user to lookup an address based on its index number. This is the menu form where the user can choose the task to perform. This is the add contact form

Public Class AddForm
    'define variables
    Public EditedContactList(,) As String
    Dim FirstName As String
    Dim LastName As String
    Dim EmailAddress As String
    Dim CountryLocation As String

    Function CheckIfEmpty(text) As Boolean
        'check if string is empty
        Dim isEmpty As Boolean = False

        If (String.IsNullOrEmpty(text)) Then
            isEmpty = True
        End If

        Return isEmpty
    End Function

    Function CheckType(text) As Boolean
        'check if string is an integer
        Dim isNumber As Boolean = False

        If (IsNumeric(text)) Then
            isNumber = True
        End If

        Return isNumber
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
        Form1.FormState = "AddForm"
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load contact list for use
        EditedContactList = Form1.EditedContactInfo
    End Sub

    Private Sub ConfirmAddBtn_Click(sender As Object, e As EventArgs) Handles ConfirmAddBtn.Click
        Dim arrayFull As Boolean

        'check for missing words in text box else add contact
        If (CheckIfEmpty(FNameTextBox.Text)) Then
            MessageBox.Show("Please enter a first name before submiting contact?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (CheckIfEmpty(LNameTextBox.Text)) Then
            MessageBox.Show("Please enter a last name before submiting contact?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (CheckIfEmpty(EmailTextBox.Text)) Then
            MessageBox.Show("Please enter an email address before submiting contact?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (CheckIfEmpty(CountryTextBox.Text)) Then
            MessageBox.Show("Please enter a country before submiting contact?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'save entered info to variables
            FirstName = UppercaseFirstLetter(FNameTextBox.Text)
            LastName = UppercaseFirstLetter(LNameTextBox.Text)
            EmailAddress = EmailTextBox.Text
            CountryLocation = UppercaseFirstLetter(CountryTextBox.Text)

            'for loop to enter info into multidimenional array
            For index0 = 0 To EditedContactList.GetUpperBound(0)
                'if there is something entered then dont save at that index else
                If (EditedContactList(index0, 0).Length > 0 Or EditedContactList(index0, 1).Length > 0) Then
                    arrayFull = True
                Else
                    'save contact and display success
                    arrayFull = False
                    EditedContactList(index0, 0) = FirstName
                    EditedContactList(index0, 1) = LastName
                    EditedContactList(index0, 2) = EmailAddress
                    EditedContactList(index0, 3) = CountryLocation
                    MessageBox.Show(("The Contact: " & FirstName & " " & LastName & ": " & EmailAddress & "   |   Country: " & CountryLocation & " has been successfully added to your contact list!"), "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'clear text box feilds
                    FNameTextBox.Text = ""
                    LNameTextBox.Text = ""
                    EmailTextBox.Text = ""
                    CountryTextBox.Text = ""
                    Exit For
                End If
            Next
        End If

        'if array is full alert user
        If (arrayFull) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("There was a problem adding contact to list: The list has 10 contacts already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub FNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FNameTextBox.TextChanged
        Dim TempVal As String
        'check if an integer was entered
        If (FNameTextBox.Text.Length < 2) Then
            'if statment to save the last thing entered in textbox to temp
            TempVal = FNameTextBox.Text
        Else
            TempVal = FNameTextBox.Text.Substring(FNameTextBox.Text.Length - 1)
        End If

        If (CheckType(TempVal)) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            'if it is warn user and delete last input
            MessageBox.Show("Please only use Letters!")
            FNameTextBox.Text = FNameTextBox.Text.Substring(0, FNameTextBox.Text.Length - 1)
        End If



    End Sub

    Private Sub LNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LNameTextBox.TextChanged
        Dim TempVal As String
        'check if an integer was entered
        If (LNameTextBox.Text.Length < 2) Then
            'if statment to save the last thing entered in textbox to temp
            TempVal = LNameTextBox.Text
        Else
            TempVal = LNameTextBox.Text.Substring(LNameTextBox.Text.Length - 1)
        End If

        If (CheckType(TempVal)) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            'if it is warn user and delete last input
            MessageBox.Show("Please only use Letters!")
            LNameTextBox.Text = LNameTextBox.Text.Substring(0, LNameTextBox.Text.Length - 1)
        End If


    End Sub

    Private Sub CountryTextBox_TextChanged(sender As Object, e As EventArgs) Handles CountryTextBox.TextChanged
        Dim TempVal As String
        'check if an integer was entered
        If (CountryTextBox.Text.Length < 2) Then
            'if statment to save the last thing entered in textbox to temp
            TempVal = CountryTextBox.Text
        Else
            TempVal = CountryTextBox.Text.Substring(CountryTextBox.Text.Length - 1)
        End If

        If (CheckType(TempVal)) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            'if it is warn user and delete last input
            MessageBox.Show("Please only use Letters!")
            CountryTextBox.Text = CountryTextBox.Text.Substring(0, CountryTextBox.Text.Length - 1)
        End If



    End Sub


End Class