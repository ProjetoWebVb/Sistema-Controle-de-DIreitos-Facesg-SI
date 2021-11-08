@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Empresa
@Code
    ViewData("Title") = "Delete"
End Code

<h1>Deletar</h1>

<h3>Tem certeza que deseja Deletar?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Deletar" class="btn btn-default" /> |
            @Html.ActionLink("Voltar a lista", "Index")
        </div>
    End Using
</div>
