Imports System.ComponentModel.DataAnnotations

Public Class SistemaCadastroModel


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero do Sistema:")>
    Public Property NUM_SISTEMA() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Sigla:")>
    Public Property TXT_SIGLA() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Nome:")>
    Public Property TXT_NOME() As String


End Class

