@ModelType RoundPanelValidation.Person
        
@Code
    Html.EnableUnobtrusiveJavaScript()
End Code
    
@Using (Html.BeginForm("StandardControlValidationPartial", "Home", FormMethod.Post))
    @<div>
        <label for="FirstName">FirstName:</label>
        @Html.TextBoxFor(Function(model) model.FirstName)
        @Html.ValidationMessageFor(Function(model) model.FirstName)
    </div>
    @<div>
        <label for="LastName">LastName:</label>
        @Html.TextBoxFor(Function(model) model.LastName)
        @Html.ValidationMessageFor(Function(model) model.LastName)
    </div>
    @<div>
        <label for="Email">Email:</label>
        @Html.TextBoxFor(Function(model) model.Email)
        @Html.ValidationMessageFor(Function(model) model.Email)
    </div>
    @<div class="line">
        <input type="submit" value="Update"/>
    </div>
End Using