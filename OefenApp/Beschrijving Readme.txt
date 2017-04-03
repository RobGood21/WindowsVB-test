30-3-2017 Combobox
Displaymember is wat je ziet in de combobox
Valuemember is de waarde die wordt verkregen met [combobox].selectedvalue
Als je dus de value member op het ID veld zet, wordt met .selectedvalue deze ID verkregen

Bij een opzoekveld van een gekoppelde tabel. Parent bevat de oekopties, child komt de gekozen optie in
Zet Selectedvalue property op de FK van de child dus bv. GB_ID
Zet Datasource op een bindingssource met de parenttable, dus de opzoektabel
Zet valuemember op de PK van de opzoektabel, de parenttabel
Zet displaymember op het te toenen zoekveld in de parenttabel.



Alleen datagrid, formulier.
Gebruik een dataset bv. oefendb dataset als basis met een querie. 
Wildcard = [] voor bereik of % voor willekeurig aantal tekens

Relaties, joining tables
bindingsource objecten benoemen als BS_tabelnaam
methode gevonden ergens via google. 
	Maak een nieuwe datasource MAAR KIES GEEN TABELLEN
	Ga naar datasource rechts klik > Desigener. 
	Maak een querie met gekoppelde velden. 
	Velden zij nu niet te editten of toe tevoegen. 
	Dat datagrid 