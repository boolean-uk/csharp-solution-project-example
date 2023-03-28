
Imports BobsBagelsInc.ITDepartment.Database.PostgreSQL

Public Class LegacyCode

    Private Sub New()


        Dim NeedObjectToAccessTheCompanyPostGRESDatabase As New PostgresSqlDataAccess

        NeedObjectToAccessTheCompanyPostGRESDatabase.DoSomethingWithCompanyDatabase()


    End Sub
End Class
