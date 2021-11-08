@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.UsuarioCadastroModel
@Code
    ViewData("Title") = "Criar"
End Code

<h1>Criar</h1>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Cadastrar Usuario</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "ext-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.TXT_EMAIL, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TXT_Email, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.TXT_Email, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TXT_SENHA, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TXT_Senha, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.TXT_Senha, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TXT_NOME, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TXT_Nome, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.TXT_Nome, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DAT_Cancelamento, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DAT_Cancelamento, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.DAT_Cancelamento, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NUM_Empresa, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("NUM_Empresa", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.NUM_Empresa, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NUM_Grupo, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("NUM_Grupo", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.NUM_Grupo, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Criar" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Voltar a lista", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")

    <script>
        function validar() {
            var $form = $("#frmLogin");
            var email = document.getElementById('TXT_Email');
            var ctrl = true;
            debugger;
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

        function validaEmail(email) {
            var regex = /^([\w-]+(?:\.[\w-]+)*)@@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
            return regex.test(email);
        }
    </script>
End Section
