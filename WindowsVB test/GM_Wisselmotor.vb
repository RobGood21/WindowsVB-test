Module GM_Wisselmotor

    'wordt gebruikt in: F_Product, F_ProductZoek
    Public IDGROEP As Integer, IDGROEPINDEX As Integer
    Public IDPRODUCT As Integer
    Public IDGETPRODUCTADD As Integer
    '*****
    'ín gebruik bij orders, ontvangsten
    Public IDSUPPLIER As Integer
    Public IDSHOP As Integer
    Public IDGETONTVANGST As Integer = 0
    Public IDADMINKOOP As Integer
    Public IDLOCATIE As Integer 'Locatie id van de plek waar een product standaard ligt

    'Openstatus van formulieren
    Public OPGETPRODUCTADD As Integer '1=Maak nieuw record 2=bekijk en open bestaand record
    Public OPPRODUCT As Integer 'Hoe F_Product te openen
    Public OPSUPPLIER As Integer '1=open met ID supplier
    Public OPADMINKOOP As Integer '1=open nieuw van F_GetPoduct , 2=openbestaand vanuit F_getproduct, 3= openleeg

    'Zoek formulier onthouden laatste waarde
    Public ZOEKGROEP As Integer
    Public ZOEKTXT As String
    Public ZOEKGROEPCH As Boolean
    Public ZOEKTXTCH As Boolean

    'Gebruiker opties.
    'Deze opties zijn door gebruiker instelbaar, in later stadium dit opslaan in Database
    Public PERIOD As Boolean = True 'true zet een punt om in een komma in valuta velden
    Public LOCATIESTART As Integer = 1 'default locatie
    Public LOCATIEHOLDERSTART As Integer = 4 'default locatie holder

    Public Function PuntKomma(T As String) As String
        'beetje kromme truck om de punt in een komma te zetten voor valuta velden
        Dim R As String = ""
        If PERIOD = True Then
            If T = "." Then
                R = ","
            Else
                R = T
            End If
        End If
        Return R
    End Function

End Module
