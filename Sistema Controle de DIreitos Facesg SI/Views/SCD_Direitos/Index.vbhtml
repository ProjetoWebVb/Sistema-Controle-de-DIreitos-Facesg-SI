@ModelType IEnumerable(Of Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Direitos)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Controle de Direitos</h2>
<br></br>

<p>
    
    
    <div><div><a href="~/SCD_Direitos/Create" class="btn btn-primary btn-lg">Criar &raquo;</a></div></div>


</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayName("Menu")
        </th>
        <th>
            @Html.DisplayName("Menu Pai")
        </th>
        <th>
            @Html.DisplayName("Numero Ordenacao")
        </th>
        <th>
            @Html.DisplayName("Visualizar")
        </th>
        <th>
            @Html.DisplayName("Consultar")
        </th>
        <th>
            @Html.DisplayName("Inserir")
        </th>
        <th>
            @Html.DisplayName("Alterar")
        </th>
        <th>
            @Html.DisplayName("Remover")
        </th>
        <th>
            @Html.DisplayName("Nome Empresa")
        </th>
        <th>
            @Html.DisplayName("Nome Grupo")
        </th>
        <th>
            @Html.DisplayName("Sigla Sistema")
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TXT_Menu)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TXT_Menu_Pai)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.NUM_Ordernacao)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BOL_Visualizar)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BOL_Consultar)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BOL_Inserir)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BOL_Alterar)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BOL_Remover)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.SCD_Empresa.TXT_Nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.SCD_Grupo.TXT_Nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.SCD_Sistema.TXT_Sigla)
            </td>
            <td>
                @Html.ActionLink("Editar", "Edit", New With {.id = item.NUM_Codigo}) |
                @Html.ActionLink("Detalhes", "Details", New With {.id = item.NUM_Codigo}) |
                @Html.ActionLink("Deletar", "Delete", New With {.id = item.NUM_Codigo})
            </td>
        </tr>
    Next

</table>
