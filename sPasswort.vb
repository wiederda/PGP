Imports System.Reflection

'<Assembly: AssemblyDelaySign(False)>
'<Assembly: AssemblyKeyFile("sPasswort.snk")>
Public Class s_Passwort

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="length">...</param>
    ''' <param name="numbers">....</param>
    ''' <param name="lowerCases">....</param>
    ''' <param name="upperCases"></param>
    ''' <param name="specials"></param>
    ''' <param name="include"></param>
    ''' <param name="exclude"></param>
    ''' <returns></returns>
    Public Overloads Shared Function GeneratePassword(ByVal length As Byte, ByVal numbers As Boolean,
                                  ByVal lowerCases As Boolean, ByVal upperCases As Boolean,
                                  ByVal specials As Boolean, Optional ByVal include As String = "",
                                  Optional ByVal exclude As String = "") As String

        'password must contain at least one character from at least one subset
        If length = 0 OrElse (Not (numbers OrElse lowerCases OrElse upperCases OrElse specials) AndAlso include = "") Then Return ""

        'add selected characters
        Dim random As New Random, charset As String = "", password As String = ""
        If numbers Then charset &= "0123456789"
        If lowerCases Then charset &= "abcdefghijklmnopqrstuvwxyz"
        If upperCases Then charset &= "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        If specials Then charset &= "+-/*#,;.:-_^!()[]{}=?ß'äÄöÖüÜ<>@"

        'add/remove further ones
        If Not include = "" Then charset &= include

        If Not exclude = "" Then
            For Each c As Char In exclude
                charset = charset.Replace(c, "")
            Next
        End If

        'create random password
        For i As Byte = 1 To length
            password &= charset(random.Next(0, charset.Length))
        Next

        Return password
    End Function

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="password">...</param>
    ''' <returns></returns>
    Public Shared Function GetCombinations(ByVal password As String) As ULong
        Dim nums, lows, upps, specs As New Boolean, combos As ULong = 0

        For Each num As Char In "0123456789"
            If password.Contains(num) Then combos += 10 : Exit For
        Next

        For Each low As Char In "abcdefghijklmnopqrstuvwxyz"
            If password.Contains(low) Then combos += 26 : Exit For
        Next

        For Each upp As Char In "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            If password.Contains(upp) Then combos += 26 : Exit For
        Next

        For Each spec As Char In "+-/*#,;.:-_^!()[]{}=?ß'äÄöÖüÜ<>@"
            If password.Contains(spec) Then combos += 32 : Exit For
        Next

        Return combos ^ password.Length
    End Function

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="Len">...</param>
    ''' <returns></returns>
    Public Overloads Shared Function GeneratePassword(Optional ByVal Len As Integer = 8)

        If Len < 6 Then
            MsgBox("Minimum password length is 6 characters", MsgBoxStyle.OkOnly, "Minimum Length Reset")
            Len = 6
        End If

        Dim pass As String = String.Empty

        Dim nums As String() = "2 3 4 5 6 7 8 9".Split(" ") 'Omit 1 & 0
        Dim lettU As String() = "A B C D E F G H J K L M N P Q R S T U V W X Y Z".Split(" ") 'Omit i,I,o & O
        Dim lettL As String() = "A B C D E F G H J K M N P Q R S T U V W X Y Z".ToLower.Split(" ") 'Omit i,I,l, L,o & O
        Dim chars As String() = "(-) @ # $ % * {-} [-] - _ ^ < > + = ~ /\".Split(" ") 'omit ? / \ ( ) ' " . , ; : &

        Dim passRan() As Array = {nums, lettU, lettL, chars}

        Dim min As Integer = 0
        Dim max As Integer = passRan.Length 'this will include the length
        Dim rnd As Integer = 0

        Dim sb As New List(Of String)

        For l As Integer = 0 To Len - passRan.Length - 1
            'select the set to pick from ensuring you have a character from each set
            If l = 0 Then
                For p As Integer = 0 To passRan.Length - 1
                    'pick a random position in the selected set
                    max = passRan(p).Length
                    rnd = GeneratePasswordLen(min, max)
                    sb.Add(passRan(p)(rnd))
                Next
            End If

            'select the set to pick from by random
            max = passRan.Length
            rnd = GeneratePasswordLen(min, max)
            For p As Integer = 0 To passRan.Length - 1
                'pick a random position in the selected set
                If p = rnd Then
                    max = passRan(p).Length
                    rnd = GeneratePasswordLen(min, max)
                    sb.Add(passRan(p)(rnd))
                    Exit For
                End If
            Next
        Next

        'shuffle the result
        Dim R As New List(Of String)
        R = sb.ToList
        For Int As Integer = 0 To Len - 1
            Dim curr As Integer = GeneratePasswordLen(min, R.Count)
            pass &= R(curr)
            R.RemoveAt(curr)
        Next

        Return pass

    End Function

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="Min">...</param>
    ''' <param name="Max">...</param>
    ''' <returns></returns>
    Public Shared Function GeneratePasswordLen(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
End Class
