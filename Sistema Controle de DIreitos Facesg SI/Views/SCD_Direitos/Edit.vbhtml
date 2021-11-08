@ModelType Sistema_Controle_de_DIreitos_Facesg_SI.SCD_Direitos
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Editar Direitos</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.NUM_Sistema, "Numero Sistema", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("NUM_Sistema", Nothing, htmlAttributes:= New With { .class = "form-control" })
                @Html.ValidationMessageFor(Function(model) model.NUM_Sistema, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NUM_Empresa, "Numero Empresa", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("NUM_Empresa", Nothing, htmlAttributes:= New With { .class = "form-control" })
                @Html.ValidationMessageFor(Function(model) model.NUM_Empresa, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NUM_Grupo, "Numero Grupo", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("NUM_Grupo", Nothing, htmlAttributes:= New With { .class = "form-control" })
                @Html.ValidationMessageFor(Function(model) model.NUM_Grupo, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TXT_Menu, "Menu", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TXT_Menu, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.TXT_Menu, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.TXT_Menu_Pai, "Menu Pai", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TXT_Menu_Pai, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.TXT_Menu_Pai, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NUM_Ordernacao, "Numero Ordenacao", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NUM_Ordernacao, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NUM_Ordernacao, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BOL_Visualizar, "Visualizar", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.BOL_Visualizar)
                    @Html.ValidationMessageFor(Function(model) model.BOL_Visualizar, "", New With { .class = "text-danger" })
                </div>
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BOL_Consultar, "Consultar", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.BOL_Consultar)
                    @Html.ValidationMessageFor(Function(model) model.BOL_Consultar, "", New With { .class = "text-danger" })
                </div>
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BOL_Inserir, "Inserir", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.BOL_Inserir)
                    @Html.ValidationMessageFor(Function(model) model.BOL_Inserir, "", New With { .class = "text-danger" })
                </div>
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BOL_Alterar, "Alterar", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.BOL_Alterar)
                    @Html.ValidationMessageFor(Function(model) model.BOL_Alterar, "", New With { .class = "text-danger" })
                </div>
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.BOL_Remover, "Remover", htmlAttributes:=New With {.Class = "control-label col-md-2"})
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.BOL_Remover)
                    @Html.ValidationMessageFor(Function(model) model.BOL_Remover, "", New With { .class = "text-danger" })
                </div>
            </div>
        </div>

        @Html.HiddenFor(Function(model) model.NUM_Codigo)

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Salvar" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Voltar a lista", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
