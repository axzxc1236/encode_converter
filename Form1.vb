Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ANSIString() As Byte, MyEncoder As New System.Text.ASCIIEncoding()
        Dim fStream As IO.FileStream
        Dim sFilename As String = Command()
        Dim sSourceString As String = IO.File.ReadAllText(sFilename)
        ANSIString = System.Text.Encoding.Convert(System.Text.Encoding.UTF8, System.Text.Encoding.ASCII, MyEncoder.GetBytes(sSourceString))

        fStream = File.OpenWrite(sFilename)
        fStream.Write(ANSIString, 0, ANSIString.Length)
        fStream.Close()

        Dim a As String = IO.File.ReadAllText(sFilename)

        a = a.Remove(a.Length - 3)

        IO.File.WriteAllText(sFilename, a)

        End
    End Sub
   
End Class
