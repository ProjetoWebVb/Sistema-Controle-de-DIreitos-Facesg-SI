@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Usuario
@Code
    ViewData("Title") = "Details"
End Code

<h1>Detalhes</h1>

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
</div>
<p>
  @Html.ActionLink("Voltar a Lista", "Index")
</p>
