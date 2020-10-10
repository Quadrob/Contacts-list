'Author: Robert Zeelie
'Version: 1.0.00
'
'Description: A contacts application that stores the names, emails and countries of up to 10 different people and allows the user to lookup an address based on its index number. This is the menu form where the user can choose the task to perform. This is the search contacts form

Public Class SearchForm
    'declare variables
    Public SearchResults(,) As String
    Private SearchText As String

    Function CheckType(text) As Boolean
        'check if text is numeric
        Dim isNumber As Boolean = False

        If (IsNumeric(text)) Then
            isNumber = True
        End If

        Return isNumber
    End Function

    Function CheckIfEmpty(text) As Boolean
        'check if string is empty
        Dim isEmpty As Boolean = False

        If (String.IsNullOrEmpty(text)) Then
            isEmpty = True
        End If

        Return isEmpty
    End Function

    Function stringToInt(text) As Integer
        Dim number As Integer = 0
        'try to convert to integer and return
        Try
            number = Convert.ToInt32(text)
        Catch ex As ArgumentException
            SearchResultListBox.Items.Clear()
            SearchResultListBox.Items.Add(ex)
            SearchResultListBox.Items.Add(vbNewLine & vbNewLine & "Something went wrong please check your search variable!")
        End Try

        Return number
    End Function

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        'Show form1 and Set form state
        Form1.FormState = "SearchForm"
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'get contact information
        SearchResults = Form1.EditedContactInfo

        'clear list box AND DISPLAY THE WHOLE CONTACT LIST
        SearchResultListBox.Items.Clear()
        For index0 = 0 To SearchResults.GetUpperBound(0)
            'Íf statement to make sure the name isnt empty
            If (SearchResults(index0, 0).Length > 0 Or SearchResults(index0, 1).Length > 0) Then
                SearchResultListBox.Items.Add(vbNewLine)
                SearchResultListBox.Items.Add((index0 + 1) & ": " & SearchResults(index0, 0) & " " & SearchResults(index0, 1) & ": " & SearchResults(index0, 2) & "  |  Country: " & SearchResults(index0, 3))
            End If
        Next

    End Sub

    Private Sub SearchText_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged, SearchTextBox.TextChanged
        'store text that will be used to search
        SearchText = SearchTextBox.Text
    End Sub

    Private Sub ConfirmSearchBtn_Click(sender As Object, e As EventArgs) Handles ConfirmSearchBtn.Click
        Dim NoMatch As Boolean = True
        'Check if its a number or a string
        Dim isNumber = CheckType(SearchText)
        'Try to run search and catch error
        Try
            'if its a number search for index number else search for matching text
            If (isNumber) Then
                'convert string to integer
                Dim indexNum = stringToInt(SearchText)
                'clear list box and display matching results
                SearchResultListBox.Items.Clear()
                SearchResultListBox.Items.Add("Search Results for " & SearchText & " is: " & vbNewLine & vbNewLine)
                'for if loop to look for matching index
                For index0 = 0 To SearchResults.GetUpperBound(0)
                    If (index0 = indexNum - 1) Then
                        'check if theres information in array to display
                        If (SearchResults(index0, 0).Length > 0 Or SearchResults(index0, 1).Length > 0) Then
                            SearchResultListBox.Items.Add(vbNewLine)
                            SearchResultListBox.Items.Add(SearchResults(index0, 0) & " " & SearchResults(index0, 1) & ": " & SearchResults(index0, 2) & "  |  Country: " & SearchResults(index0, 3))
                        Else
                            'else display empty contact
                            SearchResultListBox.Items.Add(vbNewLine)
                            SearchResultListBox.Items.Add("Empty Contact...")
                        End If
                        NoMatch = False
                    End If

                Next
                'if no match was found inform user
                If (NoMatch) Then
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                    'display no matching contacts
                    SearchResultListBox.Items.Add(vbNewLine)
                    SearchResultListBox.Items.Add("No Contacts match your search!")
                End If
                SearchResultListBox.Items.Add(vbNewLine)
                SearchResultListBox.Items.Add("End of search results...")

            Else
                'search using a keyword and start by clearing listbox
                SearchResultListBox.Items.Clear()
                SearchResultListBox.Items.Add("Search Results for " & SearchText & " is: " & vbNewLine & vbNewLine)
                'nested for loops to itarate through the multidimensonal array
                For index0 = 0 To SearchResults.GetUpperBound(0)
                    For index1 = 0 To SearchResults.GetUpperBound(1)
                        'store string as lowercase
                        Dim lowerCaseWord = SearchResults(index0, index1).ToLower()
                        'check if string match then display
                        If (lowerCaseWord = SearchText.ToLower()) Then
                            'check if theres information in array to display
                            If (SearchResults(index0, 0).Length > 0 Or SearchResults(index0, 1).Length > 0) Then
                                SearchResultListBox.Items.Add(vbNewLine)
                                SearchResultListBox.Items.Add(SearchResults(index0, 0) & " " & SearchResults(index0, 1) & ": " & SearchResults(index0, 2) & "  |  Country: " & SearchResults(index0, 3))
                            Else
                                'else display empty contact
                                SearchResultListBox.Items.Add(vbNewLine)
                                SearchResultListBox.Items.Add("Empty Contact...")
                            End If
                            NoMatch = False
                        End If
                    Next
                Next
                'if no match was found inform user
                If (NoMatch) Then
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                    'display no matching contacts
                    SearchResultListBox.Items.Add(vbNewLine)
                    SearchResultListBox.Items.Add("No Contacts match your search!")
                End If
                SearchResultListBox.Items.Add(vbNewLine)
                SearchResultListBox.Items.Add("End of search results...")
            End If

        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            SearchResultListBox.Items.Clear()
            SearchResultListBox.Items.Add("Error while searching!")
            MessageBox.Show("Please enter a number or word in search box?")
        End Try

    End Sub
End Class