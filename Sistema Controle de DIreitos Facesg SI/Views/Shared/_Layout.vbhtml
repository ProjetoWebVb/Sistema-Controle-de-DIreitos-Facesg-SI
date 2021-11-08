
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Controle os direitos</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Sistema de Controle de Direitos", "Login", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">

                    @If Not String.IsNullOrEmpty(ViewData("Login")) Then
                        @<li>@Html.ActionLink("Usuario", "Index", "SCD_Usuario")</li>
                        @<li>@Html.ActionLink("Sistema", "Index", "SCD_Sistema")</li>
                        @<li>@Html.ActionLink("Grupo", "Index", "SCD_Grupo")</li>
                        @<li>@Html.ActionLink("Empresa", "Index", "SCD_Empresa")</li>
                        @<li>@Html.ActionLink("Direitos", "Index", "SCD_Direitos")</li>
                        @<li>@Html.ActionLink("Sair", "Login", "Home")</li>
                        @<li>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</li>
                      
                        @<li>@Html.ActionLink("Usuario Logado: " & ViewData("Login").ToString, "", New With {.Class = "Float-right text-white bg-dark"})</li>
                    Else
                        @<li>@Html.ActionLink("Sobre", "About", "Home")</li>
                        @<li>@Html.ActionLink("Contato", "Contact", "Home")</li>
                    End If




                </ul>
            </div>
        </div>
    </div>
    <div Class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
