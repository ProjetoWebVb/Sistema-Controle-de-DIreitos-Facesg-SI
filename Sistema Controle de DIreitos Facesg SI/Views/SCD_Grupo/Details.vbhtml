@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Grupo
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayName("Nome")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Nome)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Voltar a lista", "Index")
</p>
