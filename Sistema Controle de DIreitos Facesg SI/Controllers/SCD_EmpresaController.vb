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
    Public Class SCD_EmpresaController
        Inherits System.Web.Mvc.Controller

        Private db As New Facesg_DireitosEntities

        ' GET: SCD_Empresa
        Function Index() As ActionResult
            TempData.Keep("Login")
            ViewData("Login") = TempData("Login")
            Return View(db.SCD_Empresa.ToList())
        End Function

        ' GET: SCD_Empresa/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Empresa As SCD_Empresa = db.SCD_Empresa.Find(id)
            If IsNothing(sCD_Empresa) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Empresa)
        End Function

        ' GET: SCD_Empresa/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: SCD_Empresa/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(model As EmpresaCadastroModel) As ActionResult

            Dim Empresa As New SCD_Empresa

            Empresa.NUM_Empresa = model.NUM_EMPRESA
            Empresa.TXT_Nome = model.TXT_NOME
            Empresa.DAT_Cancelamento = model.DAT_CANCELAMENTO


            If ModelState.IsValid Then

                db.SCD_Empresa.Add(Empresa)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(Empresa)

        End Function

        ' GET: SCD_Empresa/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Empresa As SCD_Empresa = db.SCD_Empresa.Find(id)
            If IsNothing(sCD_Empresa) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Empresa)
        End Function

        ' POST: SCD_Empresa/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="NUM_Empresa,TXT_Nome,DAT_Cancelamento")> ByVal sCD_Empresa As SCD_Empresa) As ActionResult
            If ModelState.IsValid Then
                db.Entry(sCD_Empresa).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(sCD_Empresa)
        End Function

        ' GET: SCD_Empresa/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Empresa As SCD_Empresa = db.SCD_Empresa.Find(id)
            If IsNothing(sCD_Empresa) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Empresa)
        End Function

        ' POST: SCD_Empresa/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim sCD_Empresa As SCD_Empresa = db.SCD_Empresa.Find(id)
            db.SCD_Empresa.Remove(sCD_Empresa)
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
