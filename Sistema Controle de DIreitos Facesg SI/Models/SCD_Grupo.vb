'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class SCD_Grupo
    Public Property NUM_Grupo As Long
    Public Property TXT_Nome As String

    Public Overridable Property SCD_Direitos As ICollection(Of SCD_Direitos) = New HashSet(Of SCD_Direitos)
    Public Overridable Property SCD_Usuario As ICollection(Of SCD_Usuario) = New HashSet(Of SCD_Usuario)

End Class