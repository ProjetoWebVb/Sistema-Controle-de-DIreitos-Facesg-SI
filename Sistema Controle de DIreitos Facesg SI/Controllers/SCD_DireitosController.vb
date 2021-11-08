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
    Public Class SCD_DireitosController
        Inherits System.Web.Mvc.Controller

        Private db As New Facesg_DireitosEntities

        ' GET: SCD_Direitos
        Function Index() As ActionResult
            TempData.Keep("Login")
            ViewData("Login") = TempData("Login")

            Dim sCD_Direitos = db.SCD_Direitos.Include(Function(s) s.SCD_Empresa).Include(Function(s) s.SCD_Grupo).Include(Function(s) s.SCD_Sistema)
            Return View(sCD_Direitos.ToList())
        End Function

        ' GET: SCD_Direitos/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Direitos As SCD_Direitos = db.SCD_Direitos.Find(id)
            If IsNothing(sCD_Direitos) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Direitos)
        End Function

        ' GET: SCD_Direitos/Create
        Function Create() As ActionResult
            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome")
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome")
            ViewBag.NUM_Sistema = New SelectList(db.SCD_Sistema, "NUM_Sistema", "TXT_Sigla")
            Return View()
        End Function

        ' POST: SCD_Direitos/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(model As DireitoCadastroModel) As ActionResult

            Dim Direito As New SCD_Direitos

            Direito.NUM_Sistema = model.NUM_SISTEMA
            Direito.NUM_Empresa = model.NUM_EMPRESA
            Direito.NUM_Grupo = model.NUM_GRUPO
            Direito.TXT_Menu = model.TXT_MENU
            Direito.TXT_Menu_Pai = model.TXT_MENU_PAI
            Direito.NUM_Ordernacao = model.NUM_ORDENACAO
            Direito.BOL_Visualizar = model.BOL_VISUALIZAR
            Direito.BOL_Consultar = model.BOL_CONSULTAR
            Direito.BOL_Inserir = model.BOL_INSERIR
            Direito.BOL_Alterar = model.BOL_ALTERAR
            Direito.BOL_Remover = model.BOL_REMOVER


            If ModelState.IsValid Then

                db.SCD_Direitos.Add(Direito)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome", Direito.NUM_Empresa)
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome", Direito.NUM_Grupo)
            ViewBag.NUM_Sistema = New SelectList(db.SCD_Sistema, "NUM_Sistema", "TXT_Sigla", Direito.NUM_Sistema)
            Return View(Direito)
        End Function

        ' GET: SCD_Direitos/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Direitos As SCD_Direitos = db.SCD_Direitos.Find(id)
            If IsNothing(sCD_Direitos) Then
                Return HttpNotFound()
            End If
            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome", sCD_Direitos.NUM_Empresa)
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome", sCD_Direitos.NUM_Grupo)
            ViewBag.NUM_Sistema = New SelectList(db.SCD_Sistema, "NUM_Sistema", "TXT_Sigla", sCD_Direitos.NUM_Sistema)
            Return View(sCD_Direitos)
        End Function

        ' POST: SCD_Direitos/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="NUM_Sistema,NUM_Empresa,NUM_Grupo,TXT_Menu,TXT_Menu_Pai,NUM_Ordernacao,BOL_Visualizar,BOL_Consultar,BOL_Inserir,BOL_Alterar,BOL_Remover,NUM_Codigo")> ByVal sCD_Direitos As SCD_Direitos) As ActionResult
            If ModelState.IsValid Then
                db.Entry(sCD_Direitos).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.NUM_Empresa = New SelectList(db.SCD_Empresa, "NUM_Empresa", "TXT_Nome", sCD_Direitos.NUM_Empresa)
            ViewBag.NUM_Grupo = New SelectList(db.SCD_Grupo, "NUM_Grupo", "TXT_Nome", sCD_Direitos.NUM_Grupo)
            ViewBag.NUM_Sistema = New SelectList(db.SCD_Sistema, "NUM_Sistema", "TXT_Sigla", sCD_Direitos.NUM_Sistema)
            Return View(sCD_Direitos)
        End Function

        ' GET: SCD_Direitos/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim sCD_Direitos As SCD_Direitos = db.SCD_Direitos.Find(id)
            If IsNothing(sCD_Direitos) Then
                Return HttpNotFound()
            End If
            Return View(sCD_Direitos)
        End Function

        ' POST: SCD_Direitos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim sCD_Direitos As SCD_Direitos = db.SCD_Direitos.Find(id)
            db.SCD_Direitos.Remove(sCD_Direitos)
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
