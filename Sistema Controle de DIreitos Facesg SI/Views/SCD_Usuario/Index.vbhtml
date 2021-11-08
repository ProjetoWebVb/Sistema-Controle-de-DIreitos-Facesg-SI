@ModelType IEnumerable(Of Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Usuario)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Controle de Usuario</h2>
<br></br>

<p>
    
    <div><div><a href="~/SCD_Usuario/Create" class="btn btn-primary btn-lg">Criar &raquo;</a></div></div>


</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayName("Senha")
           
        </th>
        <th>
            @Html.DisplayName("Nome")
        </th>
        <th>
            @Html.DisplayName("Data Cancelamento")
        </th>
        <th>
            @Html.DisplayName("Empresa")
        </th>
        <th>
            @Html.DisplayName("Direito")
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TXT_Senha)
                @Html.HiddenFor(Function(modelItem) item.TXT_Email)

            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TXT_Nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DAT_Cancelamento)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.SCD_Empresa.TXT_Nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.SCD_Grupo.TXT_Nome)
            </td>
            <td>
                @Html.ActionLink("Editar", "Edit", New With {.id = item.User_id}) |
                @Html.ActionLink("Detalhes", "Details", New With {.id = item.User_id}) |
                @Html.ActionLink("Deletar", "Delete", New With {.id = item.User_id})
            </td>
        </tr>
    Next

</table>
