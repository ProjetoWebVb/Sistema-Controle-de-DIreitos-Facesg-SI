@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Sistema
@Code
    ViewData("Title") = "Detalhes"
End Code

<h1>Detalhes</h1>

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
</div>
<p>
       @Html.ActionLink("Voltar a lista", "Index")
</p>
