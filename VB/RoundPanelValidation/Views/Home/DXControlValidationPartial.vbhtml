@ModelType RoundPanelValidation.Person

@Code
    Html.EnableUnobtrusiveJavaScript()
End Code

@Using (Html.BeginForm("DXControlValidationPartial", "Home", FormMethod.Post))
    @<div>
        @Html.DevExpress().Label( _
            Sub(settings)
                settings.Text = "FirstName:"
                settings.AssociatedControlName = "FirstName"
            End Sub
        ).GetHtml()
        @Html.DevExpress().TextBox( _
             Sub(settings)
                 settings.Name = "FirstName"
                 settings.ShowModelErrors = True
                 settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
             End Sub
        ).Bind(Model.FirstName).GetHtml()
    </div>
    @<div>
        @Html.DevExpress().Label(
             Sub(settings)
                 settings.Text = "LastName:"
                 settings.AssociatedControlName = "LastName"
             End Sub
        ).GetHtml()
        @Html.DevExpress().TextBox( _
            Sub(settings)
                settings.Name = "LastName"
                settings.ShowModelErrors = True
                settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
            End Sub
        ).Bind(Model.LastName).GetHtml()
    </div>
    @<div>
        @Html.DevExpress().Label( _
            Sub(settings)
                settings.Text = "Email:"
                settings.AssociatedControlName = "Email"
            End Sub
        ).GetHtml()
        @Html.DevExpress().TextBox( _
            Sub(settings)
                settings.Name = "Email"
                settings.ShowModelErrors = True
                settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
            End Sub
        ).Bind(Model.Email).GetHtml()
    </div>
    @<div>
        @Html.DevExpress().Button( _
            Sub(settings)
                settings.Name = "btnUpdate"
                settings.Text = "Update"
                settings.UseSubmitBehavior = True
            End Sub
        ).GetHtml()
    </div>
End Using