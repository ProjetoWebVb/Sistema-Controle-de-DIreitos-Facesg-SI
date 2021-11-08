@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Empresa
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalhes</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
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

    </dl>
</div>
<p>
       @Html.ActionLink("Voltar a lista", "Index")
</p>
