Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ComponentModel.DataAnnotations

Public Class Person
    Private privateFirstName As String
    <Required()> _
    Public Property FirstName() As String
        Get
            Return privateFirstName
        End Get
        Set(ByVal value As String)
            privateFirstName = value
        End Set
    End Property
    Private privateLastName As String
    <Required()> _
    Public Property LastName() As String
        Get
            Return privateLastName
        End Get
        Set(ByVal value As String)
            privateLastName = value
        End Set
    End Property
    Private privateEmail As String
    <Required(), RegularExpression("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage:="Email is invalid")> _
    Public Property Email() As String
        Get
            Return privateEmail
        End Get
        Set(ByVal value As String)
            privateEmail = value
        End Set
    End Property
End Class