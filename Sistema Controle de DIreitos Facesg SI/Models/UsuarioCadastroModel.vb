Imports System.ComponentModel.DataAnnotations

Public Class UsuarioCadastroModel


    Public Property User_id() As Int32

    <Required(ErrorMessage:="campo obrigatorio")>
    <DataType(DataType.EmailAddress, ErrorMessage:="Email formato invalido")>
    <Display(Name:="Email")>
    Public Property TXT_EMAIL() As String



    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Senha")>
    Public Property TXT_SENHA() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Nome")>
    Public Property TXT_NOME() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Data Cancelamento")>
    Public Property DAT_Cancelamento() As Date


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero Empresa")>
    Public Property NUM_Empresa() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero Grupo")>
    Public Property NUM_Grupo() As String
End Class
