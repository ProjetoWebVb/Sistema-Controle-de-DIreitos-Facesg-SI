Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Sistema_Controle_de_DIreitos_Facesg_SI

Namespace Controllers
    Public Class SCD_SistemaController
        Inherits System.Web.Mvc.Controller

        Private db As New Facesg_DireitosEntities

        ' GET: SCD_Sistema
        Function Index() As ActionResult
            TempData.Keep("Login")
            ViewData("Login") = TempData("Login")
            Return View(db.SCD_Sistema.ToList())
        End Function

        ' GET: SCD_Sistema/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Sistema As SCD_Sistema = db.SCD_Sistema.Find(id)
            If IsNothing(sCD_Sistema) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Sistema)
        End Function

        ' GET: SCD_Sistema/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: SCD_Sistema/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(model As SistemaCadastroModel) As ActionResult

            Dim Sistema As New SCD_Sistema

            Sistema.NUM_Sistema = model.NUM_SISTEMA
            Sistema.TXT_Nome = model.TXT_NOME
            Sistema.TXT_Sigla = model.TXT_SIGLA



            If ModelState.IsValid Then

                db.SCD_Sistema.Add(Sistema)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(Sistema)
        End Function

        ' GET: SCD_Sistema/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Sistema As SCD_Sistema = db.SCD_Sistema.Find(id)
            If IsNothing(sCD_Sistema) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Sistema)
        End Function

        ' POST: SCD_Sistema/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="NUM_Sistema,TXT_Sigla,TXT_Nome")> ByVal sCD_Sistema As SCD_Sistema) As ActionResult
            If ModelState.IsValid Then
                db.Entry(sCD_Sistema).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(sCD_Sistema)
        End Function

        ' GET: SCD_Sistema/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Sistema As SCD_Sistema = db.SCD_Sistema.Find(id)
            If IsNothing(sCD_Sistema) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Sistema)
        End Function

        ' POST: SCD_Sistema/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim sCD_Sistema As SCD_Sistema = db.SCD_Sistema.Find(id)
            db.SCD_Sistema.Remove(sCD_Sistema)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
