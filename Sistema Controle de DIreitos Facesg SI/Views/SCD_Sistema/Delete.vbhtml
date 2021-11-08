@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Sistema
@Code
    ViewData("Title") = "Delete"
End Code

<h1>Deletar</h1>

<h3>Voce tem certeza que deseja deletar?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayName("Sigla")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Sigla)
        </dd>

        <dt>
            @Html.DisplayName("Nome")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Nome)
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
