Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

Namespace ProgressNet
    <Guid("99f5d5c1-1586-4f8c-b7a1-52e257bc3746")>
    <ClassInterface(ClassInterfaceType.AutoDual)>
    <ComVisible(True)>
    <ProgId("ProgressNet.Server")>
    Public Class NetServer
        Public Sub New()
        End Sub

        <DispId(1)>
        Public Function GetString() As String
            Return "Some String"
        End Function
    End Class
End Namespace

