Public Class Login
    Public Shared Property User_Aktif As String
    Public Shared Function TampilUser() As String
        Return "Petugas Kasir : " & User_Aktif
    End Function

End Class
