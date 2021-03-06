@ModelType IEnumerable(Of Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Empresa)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Controle de Empresas</h2>
<br></br>

<p>
    
    <div><div><a href="~/SCD_Empresa/Create" class="btn btn-primary btn-lg">Criar &raquo;</a></div></div>


</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayName("Nome")
        </th>
        <th>
            @Html.DisplayName("Data Cancelamento")
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TXT_Nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DAT_Cancelamento)
            </td>
            <td>
                @Html.ActionLink("Editar", "Edit", New With {.id = item.NUM_Empresa}) |
                @Html.ActionLink("Detalhes", "Details", New With {.id = item.NUM_Empresa}) |
                @Html.ActionLink("Deletar", "Delete", New With {.id = item.NUM_Empresa})
            </td>
        </tr>
    Next

</table>
