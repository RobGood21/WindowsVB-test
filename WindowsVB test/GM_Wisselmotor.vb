﻿Module GM_Wisselmotor

    'wordt gebruikt in: F_Product, F_ProductZoek
    Public IDGROEP As Integer, IDGROEPINDEX As Integer
    Public IDPRODUCT As Integer
    '*****
    'ín gebruik bij orders, ontvangsten
    Public IDSUPPLIER As Integer
    Public IDSHOP As Integer
    Public IDGETONTVANGST As Integer
    Public IDADMINKOOP As Integer

    'Openstatus van formulieren
    Public OPGETPRODUCTADD As Integer '1=Maak nieuw record 2=bekijk en open bestaand record
    Public OPSUPPLIER As Integer '1=open met ID supplier
    Public OPADMINKOOP As Integer '1=open nieuw van F_GetPoduct , 2=openbestaand vanuit F_getproduct, 3= openleeg




End Module
