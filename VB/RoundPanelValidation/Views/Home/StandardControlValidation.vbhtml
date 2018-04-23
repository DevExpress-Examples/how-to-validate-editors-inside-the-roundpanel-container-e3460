@ModelType RoundPanelValidation.Person
    
@Html.DevExpress().RoundPanel( _
    Sub(settings)
            settings.Name = "roundPanel"
            settings.SetContent( _
                Sub()
                        Html.RenderPartial("StandardControlValidationPartial", Model)
                End Sub)
    End Sub).GetHtml()