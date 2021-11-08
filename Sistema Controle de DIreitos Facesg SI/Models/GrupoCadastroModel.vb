Imports System.ComponentModel.DataAnnotations

Public Class GrupoCadastroModel

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero do Grupo:")>
    Public Property NUM_GRUPO() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Nome:")>
    Public Property TXT_NOME() As String

End Class
