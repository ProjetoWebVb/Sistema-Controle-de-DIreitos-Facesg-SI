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
    Public Class SCD_UsuarioController
        Inherits System.Web.Mvc.Controller

        Private db As New Facesg_DireitosEntities

        ' GET: SCD_Usuario
        Function Index() As ActionResult
            Dim sCD_Usuario = db.SCD_Usuario.Include(Function(s) s.SCD_Empresa).Include(Function(s) s.SCD_Grupo)
            ViewData("Login") = TempData("Login")
            TempData.Keep("Login")

            Return View(sCD_Usuario.ToList())
        End Function

        ' GET: SCD_Usuario/Details/5
        Function Details(ByVal id As Int32) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Usuario As SCD_Usuario = db.SCD_Usuario.Find(id)
            If IsNothing(sCD_Usuario) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Usuario)
        End Function

        ' GET: SCD_Usuario/Create
        Function Create() As ActionResult
            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome")
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome")
            Return View()
        End Function

        ' POST: SCD_Usuario/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(model As UsuarioCadastroModel) As ActionResult

            Dim Usuario As New SCD_Usuario

            Usuario.TXT_Email = model.TXT_EMAIL
            Usuario.TXT_Nome = model.TXT_NOME
            Usuario.TXT_Senha = model.TXT_SENHA
            Usuario.NUM_Empresa = model.NUM_Empresa
            Usuario.NUM_Grupo = model.NUM_Grupo
            Usuario.DAT_Cancelamento = model.DAT_Cancelamento

            If ModelState.IsValid Then

                db.SCD_Usuario.Add(Usuario)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome", Usuario.NUM_Empresa)
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome", Usuario.NUM_Grupo)
            Return View(Usuario)
        End Function

        ' GET: SCD_Usuario/Edit/5
        Function Edit(ByVal id As Int32) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Usuario As SCD_Usuario = db.SCD_Usuario.Find(id)
            If IsNothing(sCD_Usuario) Then
                Return HttpNotFound()
            End If



            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome", sCD_Usuario.NUM_Empresa)
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome", sCD_Usuario.NUM_Grupo)
            Return View(sCD_Usuario)
        End Function

        ' POST: SCD_Usuario/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(model As UsuarioCadastroModel) As ActionResult

            Dim Usuario As New SCD_Usuario


            Usuario.TXT_Email = model.TXT_EMAIL
            Usuario.TXT_Nome = model.TXT_NOME
            Usuario.TXT_Senha = model.TXT_SENHA
            Usuario.NUM_Empresa = model.NUM_Empresa
            Usuario.NUM_Grupo = model.NUM_Grupo
            Usuario.DAT_Cancelamento = model.DAT_Cancelamento

            If ModelState.IsValid Then
                db.Entry(Usuario).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome", Usuario.NUM_Empresa)
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome", Usuario.NUM_Grupo)
            Return View(Usuario)
        End Function

        ' GET: SCD_Usuario/Delete/5
        Function Delete(ByVal id As Int32) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Usuario As SCD_Usuario = db.SCD_Usuario.Find(id)
            If IsNothing(sCD_Usuario) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Usuario)
        End Function

        ' POST: SCD_Usuario/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim sCD_Usuario As SCD_Usuario = db.SCD_Usuario.Find(id)
            db.SCD_Usuario.Remove(sCD_Usuario)
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
