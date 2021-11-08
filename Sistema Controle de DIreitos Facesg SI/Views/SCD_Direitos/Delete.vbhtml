@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Direitos
@Code
    ViewData("Title") = "Deletar"
End Code

<h1>Deletar</h1>

<h3>Tem certeza que deseja Deletar?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayName("Menu")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Menu)
        </dd>

        <dt>
            @Html.DisplayName("Menu Pai")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TXT_Menu_Pai)
        </dd>

        <dt>
           @Html.DisplayName("Numero Ordenacao")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NUM_Ordernacao)
        </dd>

        <dt>
           @Html.DisplayName("Visualizar")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BOL_Visualizar)
        </dd>

        <dt>
          @Html.DisplayName("Consultar")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BOL_Consultar)
        </dd>

        <dt>
           @Html.DisplayName("Inserir")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BOL_Inserir)
        </dd>

        <dt>
           @Html.DisplayName("Alterar")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BOL_Alterar)
        </dd>

        <dt>
          @Html.DisplayName("Remover")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BOL_Remover)
        </dd>

        <dt>
           @Html.DisplayName("Nome Empresa")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SCD_Empresa.TXT_Nome)
        </dd>

        <dt>
            @Html.DisplayName("Nome Grupo")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SCD_Grupo.TXT_Nome)
        </dd>

        <dt>
           @Html.DisplayName("Sigla Sistema")
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SCD_Sistema.TXT_Sigla)
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
