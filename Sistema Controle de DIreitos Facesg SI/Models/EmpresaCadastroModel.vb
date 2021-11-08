Imports System.ComponentModel.DataAnnotations

Public Class EmpresaCadastroModel

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero da Empresa:")>
    Public Property NUM_EMPRESA() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Nome:")>
    Public Property TXT_NOME() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Data de Cancelamento:")>
    <DataType(DataType.Date, ErrorMessage:="Data Invalida")>
    Public Property DAT_CANCELAMENTO() As String

End Class