Imports System.ComponentModel.DataAnnotations

Public Class DireitoCadastroModel

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero do Sistema:")>
    Public Property NUM_SISTEMA() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero da Empresa:")>
    Public Property NUM_EMPRESA() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero do Grupo:")>
    Public Property NUM_GRUPO() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Menu:")>
    Public Property TXT_MENU() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Menu Pai:")>
    Public Property TXT_MENU_PAI() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero de Ordenacao:")>
    Public Property NUM_ORDENACAO() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Visualizar:")>
    Public Property BOL_VISUALIZAR() As String


    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Consultar:")>
    Public Property BOL_CONSULTAR() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Inserir:")>
    Public Property BOL_INSERIR() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Alterar:")>
    Public Property BOL_ALTERAR() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Remover:")>
    Public Property BOL_REMOVER() As String

    <Required(ErrorMessage:="campo obrigatorio")>
    <Display(Name:="Numero do Codigo:")>
    Public Property NUM_CODIGO() As String

End Class