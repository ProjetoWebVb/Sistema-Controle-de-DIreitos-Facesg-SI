@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Usuario
@Code
    ViewData("Title") = "Delete"
End Code

<h1>Deletar</h1>

<h3>Voce tem certeza que deseja Deletar?</h3>
<div>
   
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayName("Senha")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Senha)
        </dd>

        <dt>
            @Html.DisplayName("Nome")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Nome)
        </dd>

        <dt>
            @Html.DisplayName("Data Cancelamento")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DAT_Cancelamento)
        </dd>

        <dt>
            @Html.DisplayName("Empresa")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SCD_Empresa.TXT_Nome)
        </dd>

        <dt>
            @Html.DisplayName("Grupo")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SCD_Grupo.TXT_Nome)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Deletar" class="btn btn-default" /> |
            @Html.ActionLink("Voltar a lista", "Index")
        </div>
    End Using
</div>
