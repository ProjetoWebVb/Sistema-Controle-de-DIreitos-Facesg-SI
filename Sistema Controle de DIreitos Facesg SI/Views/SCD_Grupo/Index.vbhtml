@ModelType IEnumerable(Of Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Grupo)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Controle de Grupos</h2>
<br></br>

<p>
   
    <div><div><a href="~/SCD_Grupo/Create" class="btn btn-primary btn-lg">Criar &raquo;</a></div></div>


</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayName("Nome")
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TXT_Nome)
            </td>
            <td>
                @Html.ActionLink("Editar", "Edit", New With {.id = item.NUM_Grupo}) |
                @Html.ActionLink("Detalhes", "Details", New With {.id = item.NUM_Grupo}) |
                @Html.ActionLink("Deletar", "Delete", New With {.id = item.NUM_Grupo})
            </td>
        </tr>
    Next

</table>
