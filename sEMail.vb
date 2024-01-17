Imports System.Net.Mail
Imports System.Text.RegularExpressions.Regex
Imports System.Reflection

'<Assembly: AssemblyDelaySign(False)>
'<Assembly: AssemblyKeyFile("sEMail.snk")>
Public Class s_EMail

    ''' <summary>
    ''' Prüft eine E-Mail Adresse auf Gültigkeit
    ''' </summary>
    ''' <param name="eMail">E-Mail adresse, die geprüft werden soll</param>
    Public Function CheckSyntax(ByVal eMail As String) As Boolean
        'Dim oRegEx As Regex

        ' Vergleichsmuster
        Dim sPattern As String = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"

        ' Syntax der EMail-Adresse prüfen
        If Not IsMatch(eMail, sPattern) Then
            ' Syntax entspricht nicht dem Muster!
            Return False
        ElseIf IsMatch(eMail, sPattern) Then
            Return True
        End If
    End Function

    ''' <summary>
    ''' Senden einer E-Mail
    ''' </summary>
    ''' <param name="Server">Name des E-Mail-Servers</param>
    ''' <param name="Absender">E-Mail-Adresse des Absenders</param>
    ''' <param name="Empfänger">E-Mail-Adresse des Empfängers</param>
    ''' <param name="Betreff">Betreffzeile</param>
    ''' <param name="Text">Text der Nachricht, HTML wird nicht unterstützt</param>
    ''' <param name="CC">optional, E-Mail-Adresse</param>
    ''' <param name="BCC">optional, E-Mail-Adresse</param>
    ''' <param name="Attachment">optional Pfad und Dateinname der Anlage</param>
    ''' <param name="AuthName">optional Authrisierung am E-Mail-Server</param>
    ''' <param name="AuthPass">optional Authrisierung am E-Mail-Server</param>
    Public Function SendMail(ByVal Server As String, ByVal Absender As String, ByVal Empfänger As String, ByVal Betreff As String, ByVal Text As String, Optional ByVal CC As String = "", Optional ByVal BCC As String = "", Optional ByVal Attachment As String = "", Optional ByVal AuthName As String = "", Optional ByVal AuthPass As String = "") As Boolean
        ' Neues MailMessage-Objekt mit Absender und 
        ' Empfänger-Adresse erstellen
        Dim oMail As New MailMessage(Absender, Empfänger)

        ' SMTP-Server
        Dim oSMTP As New SmtpClient
        With oSMTP
            ' Mailserver
            .Host = Server
            .Port = 25

            ' Erweiterte Mail-Einstellungen
            .UseDefaultCredentials = False
            .DeliveryMethod = SmtpDeliveryMethod.Network

            If Not AuthName = "" Then
                ' SMTP-AUTH mit UserName und Kennwort
                .Credentials = New System.Net.NetworkCredential(AuthName, AuthPass)
            End If
        End With

        With oMail
            ' Betreff
            .Subject = Betreff

            ' Nachricht (kein HTML)
            .IsBodyHtml = False
            .Body = Text

            If Not CC = "" Then
                'ggf. Kopie-Empfänger hinzufügen
                .CC.Add(New MailAddress(CC))
            End If

            If Not BCC = "" Then
                ' ggf. BCC-Empfänger hinzufügen
                .Bcc.Add(New MailAddress(BCC))
            End If

            If Not Attachment = "" Then
                ' Anlagen hinzufügen
                .Attachments.Clear()
                .Attachments.Add(New Attachment((Attachment)))
            End If

            ' Priorität einstellen
            .Priority = MailPriority.Normal
        End With

        Try
            ' Nachricht senden
            oSMTP.Send(oMail)
            Return True

        Catch oEx As Exception
            Return False
        End Try
        oSMTP = Nothing
        oMail = Nothing
        GC.Collect()
    End Function
End Class
