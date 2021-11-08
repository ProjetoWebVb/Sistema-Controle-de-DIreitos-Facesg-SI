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
    Public Class SCD_GrupoController
        Inherits System.Web.Mvc.Controller

        Private db As New Facesg_DireitosEntities

        ' GET: SCD_Grupo
        Function Index() As ActionResult
            TempData.Keep("Login")
            ViewData("Login") = TempData("Login")
            Return View(db.SCD_Grupo.ToList())
        End Function

        ' GET: SCD_Grupo/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Grupo As SCD_Grupo = db.SCD_Grupo.Find(id)
            If IsNothing(sCD_Grupo) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Grupo)
        End Function

        ' GET: SCD_Grupo/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: SCD_Grupo/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(model As GrupoCadastroModel) As ActionResult

            Dim Grupo As New SCD_Grupo

            Grupo.NUM_Grupo = model.NUM_GRUPO
            Grupo.TXT_Nome = model.TXT_NOME



            If ModelState.IsValid Then

                db.SCD_Grupo.Add(Grupo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(Grupo)

        End Function

        ' GET: SCD_Grupo/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Grupo As SCD_Grupo = db.SCD_Grupo.Find(id)
            If IsNothing(sCD_Grupo) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Grupo)
        End Function

        ' POST: SCD_Grupo/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="NUM_Grupo,TXT_Nome")> ByVal sCD_Grupo As SCD_Grupo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(sCD_Grupo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(sCD_Grupo)
        End Function

        ' GET: SCD_Grupo/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Grupo As SCD_Grupo = db.SCD_Grupo.Find(id)
            If IsNothing(sCD_Grupo) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Grupo)
        End Function

        ' POST: SCD_Grupo/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim sCD_Grupo As SCD_Grupo = db.SCD_Grupo.Find(id)
            db.SCD_Grupo.Remove(sCD_Grupo)
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
