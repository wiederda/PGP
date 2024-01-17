Imports System.Reflection
Imports Microsoft.Win32

'<Assembly: AssemblyDelaySign(False)>
'<Assembly: AssemblyKeyFile("sRegistry.snk")>
Public Class s_Registry
    Public Enum Reg
        HKEY_CLASSES_ROOT = &H80000000
        HKEY_CURRENT_CONFIG = &H80000005
        HKEY_CURRENT_USER = &H80000001
        HKEY_LOCAL_MACHINE = &H80000002
        HKEY_USERS = &H80000003
    End Enum

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="HKEY">...</param>
    ''' <param name="sKey">....</param>
    ''' <param name="sSektion">....</param>
    ''' <returns></returns>
    Public Function GetValue(ByVal HKEY As Reg, ByVal sKey As String, ByVal sSektion As String) As String
        Dim sHKEY As String = ""

        Select Case HKEY
            Case Reg.HKEY_CURRENT_USER
                sHKEY = "HKEY_CURRENT_USER\"
            Case Reg.HKEY_CLASSES_ROOT
                sHKEY = "HKEY_CLASSES_ROOT\"
            Case Reg.HKEY_CURRENT_CONFIG
                sHKEY = "HKEY_CURRENT_CONFIG\"
            Case Reg.HKEY_LOCAL_MACHINE
                sHKEY = "HKEY_LOCAL_MACHINE\"
            Case Reg.HKEY_USERS
                sHKEY = "HKEY_USERS\"
        End Select

        Try
            Return My.Computer.Registry.GetValue(sHKEY & sKey, sSektion, Nothing).ToString
        Catch
            Return "Fehler"
        End Try
    End Function

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="HKEY">...</param>
    ''' <param name="sKey">....</param>
    ''' <param name="sSektion">....</param>
    ''' <param name="sWert"></param>
    ''' <param name="ValueKind"></param>
    ''' <returns></returns>
    Public Function SetValue(ByVal HKEY As Reg, ByVal sKey As String, ByVal sSektion As String, ByVal sWert As String, ByVal ValueKind As Microsoft.Win32.RegistryValueKind) As Boolean
        Dim sHKEY As String = ""

        Select Case HKEY
            Case Reg.HKEY_CURRENT_USER
                sHKEY = "HKEY_CURRENT_USER\"
            Case Reg.HKEY_CLASSES_ROOT
                sHKEY = "HKEY_CLASSES_ROOT\"
            Case Reg.HKEY_CURRENT_CONFIG
                sHKEY = "HKEY_CURRENT_CONFIG\"
            Case Reg.HKEY_LOCAL_MACHINE
                sHKEY = "HKEY_LOCAL_MACHINE\"
            Case Reg.HKEY_USERS
                sHKEY = "HKEY_USERS\"
        End Select

        Try
            My.Computer.Registry.SetValue(sHKEY & sKey, sSektion, sWert, ValueKind)
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' ....
    ''' </summary>
    ''' <param name="HKEY">...</param>
    ''' <param name="sKey">....</param>
    ''' <param name="sSektion">....</param>
    ''' <returns></returns>
    Public Function DelValue(ByVal HKEY As Reg, ByVal sKey As String, ByVal sSektion As String) As Boolean

        Try
            Select Case HKEY
                Case Reg.HKEY_CURRENT_USER
                    My.Computer.Registry.CurrentUser.OpenSubKey(sKey, True).DeleteValue(sSektion)
                Case Reg.HKEY_CLASSES_ROOT
                    My.Computer.Registry.ClassesRoot.OpenSubKey(sKey, True).DeleteValue(sSektion)
                Case Reg.HKEY_CURRENT_CONFIG
                    My.Computer.Registry.CurrentConfig.OpenSubKey(sKey, True).DeleteValue(sSektion)
                Case Reg.HKEY_LOCAL_MACHINE
                    My.Computer.Registry.LocalMachine.OpenSubKey(sKey, True).DeleteValue(sSektion)
                Case Reg.HKEY_USERS
                    My.Computer.Registry.Users.OpenSubKey(sKey, True).DeleteValue(sSektion)
            End Select
            Return (True)

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RegKeyNameExists(ByVal hive As RegistryHive,
                                      ByVal path As String,
                                      ByVal keyName As String) As Boolean
        Dim regKey As RegistryKey
        Select Case hive
            Case RegistryHive.CurrentUser
                regKey = Registry.CurrentUser.OpenSubKey(path)  ' CurrentUser
            Case RegistryHive.LocalMachine
                regKey = Registry.LocalMachine.OpenSubKey(path) ' LocalMachine
            Case Else
                ' Throw New ArgumentException("Nur HKLM und HKCU sind erlaubt")
                Return False
        End Select
        If regKey Is Nothing Then Return False ' Schlüssel nicht vorhanden
        For Each regKeyName As String In regKey.GetValueNames()
            If regKeyName.Trim.ToUpper = keyName.Trim.ToUpper Then Return True ' Gefunden
        Next
        Return False ' Nicht gefunden
    End Function
End Class
