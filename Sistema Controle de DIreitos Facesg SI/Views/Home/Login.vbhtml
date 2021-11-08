@ModelType  Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Usuario
@Code
    ViewData("Title") = "Login"
End Code



<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <script src="~/Scripts/jquery-3.4.1.js"></script>
    
    <title>Index</title>
</head>
<body>

    @Using (Html.BeginForm("Logar", "Home", FormMethod.Post, New With {.id = "frmLogin"}))
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})



        @<div class="form-horizontal">

    <h2>Pagina de login</h2>

    <br>

    <br>
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    <div class="form-group">
        <div class="col-md-1">
            @Html.DisplayName("Email")
        </div>
        <div class="col-md-11">
            @Html.EditorFor(Function(model) model.TXT_Email, New With {.htmlAttributes = New With {.class = "form-control"}})
            @*@Html.Label("emailerror", "Email inválido", New With {.htmlAttributes = New With {.display = "none"}})*@
            <label id="emailerror" style="display:none;" class="text-danger">Email inválido</label>

        </div>
    </div>

    <div class="form-group">
        <div class="col-md-1">
            @Html.DisplayName("Senha")
        </div>
        <div class="col-md-11">
            @Html.EditorFor(Function(model) model.TXT_Senha, New With {.htmlAttributes = New With {.class = "form-control", .type = "Password"}})
            @*<input type="password" id="TXT_Senha" name="password">*@
            <label id="senhaerror" style="display:none;" class="text-danger">Campo obrigatório</label>
        </div>
    </div>

    @*senha nao pode ficar vazia e o email temq ter validação de email*@
    <p> <Button type="button" onclick="validar();" class="btn btn-primary btn-lg">Login &raquo;</Button></p>
    <p> <Button type="button" id="btnResetSenha" Class="btn btn-warning btn-sm">Esqueceu a senha? </Button></p>
    <div class="form-group">
        <h2 class="text-danger"> @ViewBag.erro </h2>

    </div>


</div>
    End Using

    
</body>
</html>
@Section Scripts
    <script>
        function validar() {
            var $form = $("#frmLogin");
            var email = document.getElementById('TXT_Email');
            var ctrl = true;

            if (validaEmail(email.value)) {
                document.getElementById("emailerror").style.display = "none";
            } else {
                document.getElementById("emailerror").style.display = "block";
                ctrl = false;
            }

            var senha = document.getElementById('TXT_Senha');
            if (senha.value == NaN | senha.value == "") {
                document.getElementById("senhaerror").style.display = "block";
                ctrl = false;
            } else {
                document.getElementById("senhaerror").style.display = "none";
            }


            if (ctrl) {
                $form.submit();
                //window.location.href = "../SCD_Usuario/Index";
            }

        }

        function resetSenha() {
            var email = $("#TXT_Email").val();
            debugger;
            if (email == NaN | email == "") {
                alert('Favor preencher email para recuperação de senha');
            } else if (validaEmail(email)) {
                alert('entrei aqui');
                enviarEmail(email);
                //Implementar rotina que vai enviar o email com a nova senha

            } else {
                alert('Email no formato inválido:');
            }


        }

        function validaEmail(email) {
            var regex = /^([\w-]+(?:\.[\w-]+)*)@@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
            return regex.test(email);
        }

        $("#btnResetSenha").click(function () {
            
            var email = $("#TXT_Email").val();
            if (validaEmail(email)) {
                $.post("/Home/ResetSenha", { pEmail: email }, function (data) {
                    if (data == "OK") {
                        alert("Email com redefinição de senha enviado com sucesso!");
                    } else {
                        alert(data);
                    }

                    //$("#msg").html(data);
                });
            } else {
                alert("Email de formato incorreto");
            }
        });
    </script>



End Section
