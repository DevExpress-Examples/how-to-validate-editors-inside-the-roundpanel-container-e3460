Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace DevExpress.Razor.Controllers
    Public Class HomeController
        Inherits Controller
        Public Function Index() As ActionResult
            Return View()
        End Function
        Public Function DXControlValidation() As ActionResult
            Return View("DXControlValidation", New Person())
        End Function
        Public Function DXControlValidationPartial(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal person As Person) As ActionResult
            Return ValidationInternal(person, "SuccessValidation", "DXControlValidationPartial")
        End Function
        Public Function StandardControlValidation() As ActionResult
            Return View("StandardControlValidation", New Person())
        End Function
        Public Function StandardControlValidationPartial(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal person As Person) As ActionResult
            Return ValidationInternal(person, "SuccessValidation", "StandardControlValidationPartial")
        End Function

        Public Function SuccessValidation() As ActionResult
            Return View("SuccessValidation")
        End Function

        Private Function ValidationInternal(ByVal person As Person, ByVal successAction As String, ByVal typeAction As String) As ActionResult
            If ModelState.IsValid Then
                Return View(successAction)
            End If

            Return View(typeAction, person)

        End Function
    End Class
End Namespace
