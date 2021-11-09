Imports System.Net
Imports System.Web.Services
Imports System.Net.Mail
Imports System.Data.Entity

Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Private db As New Facesg_DireitosEntities

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Login(model As UsuarioCadastroModel) As ActionResult
        ViewData("Message") = "Sua pagina de  login."

        Return View()
    End Function

    Function Logar(model As UsuarioCadastroModel) As ActionResult
        ViewData("Message") = "Sua pagina de login."
        Dim indexEmail As Int32 = model.TXT_EMAIL.IndexOf("@")

        Dim Usuario As New SCD_Usuario
        Usuario.TXT_Email = model.TXT_EMAIL
        Usuario.TXT_Senha = model.TXT_SENHA

        Dim qyou As IList(Of SCD_Usuario)


        Using dbContext As Facesg_DireitosEntities = New Facesg_DireitosEntities
            qyou = (From p In dbContext.SCD_Usuario
                    Where p.TXT_Email = model.TXT_EMAIL
                    Select p).ToList()
        End Using


        If IsNothing(qyou) Then
            ViewBag.erro = "Email nao encontrado"
            Return View("Login", Usuario)
        End If

        If qyou(0).TXT_Senha.Trim <> model.TXT_SENHA.Trim Then
            ViewBag.erro = "Senha errada"
            Return View("Login", Usuario)
        End If


        TempData("Login") = model.TXT_EMAIL.Substring(0, indexEmail)
        TempData.Keep("Login")
        Return RedirectToAction("Index", "SCD_USUARIO")
    End Function

    Function ResetSenha(ByVal pEmail As String) As String
        Try
            Dim usuario As New SCD_Usuario
            Dim qyou As IList(Of SCD_Usuario)

            Using dbContext As Facesg_DireitosEntities = New Facesg_DireitosEntities
                qyou = (From p In dbContext.SCD_Usuario
                        Where p.TXT_Email = pEmail
                        Select p).ToList()
            End Using

            If qyou.Count() = 0 Then
                Return "Usuário não encontrado"
            End If
            usuario = qyou.FirstOrDefault()
            usuario.TXT_Senha = 1234 'Alterando a senha 

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            'Salvar o email e a senha que foi criado para identificar o sistema email: facesgsi@gmail.com e senha : senhateste
            SmtpServer.Credentials = New Net.NetworkCredential("facesgsi@gmail.com", "senhateste")
            SmtpServer.Host = "smtp.gmail.com"
            'SmtpServer.Port = 587 'server para Hotmail
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress("facesgsi@gmail.com")
            mail.Subject = "Redefinição de senha"
            mail.To.Add(pEmail)
            mail.Body = "Sua nova senha será 1234"
            SmtpServer.Send(mail)

            db.Entry(usuario).State = EntityState.Modified
            db.SaveChanges()
            Return "OK"
        Catch ex As Exception
            Return ex.Message
        End Try
        'Return View("Login")


    End Function


    Public Shared Function fResetSenha(ByVal pEmail As String) As String

        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        SmtpServer.Credentials = New Net.NetworkCredential("facesgsi@gmail.com", "senhateste")
        SmtpServer.Host = "smtp.gmail.com"
        'SmtpServer.Port = 587 'server para Hotmail
        SmtpServer.EnableSsl = True
        mail.From = New MailAddress("facesgsi@gmail.com") 'mail from ou seja de quem manda o e-mail
        mail.Subject = "Redefinição de senha"
        mail.To.Add(pEmail) ' mail.to para quem vai . No meu caSO tou a mandar e-mail para mim mesmo

        mail.Body = "Sua nova senha será 1234"
        ' se usa RichTextBox
        'mail.body = RichTextBox1.Text

        SmtpServer.Send(mail)
        Return "Enviado com sucesso"
        'MsgBox("E-mail enviado com sucesso", vbInformation + vbOKOnly, ":D")
        'Return RedirectToAction("Index", "Home")
    End Function


End Class
