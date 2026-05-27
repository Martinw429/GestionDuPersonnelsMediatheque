Application GestionDuPersonnelsMediatheque
------------------------------------------
Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL 
---
Présentation de l'application
-----------------------------
But de l'application :

L'application de bureau donne accès au responsable à des fonctionnalités de gestion des personnels pour chaque médiathèque. Différentes fonctionnalités
permettent au responsable d'avoir, par exemple, une vision du personnel travaillant dans la médiathèque et de leurs services, la possibilité d'ajouter
un personnel, de modifierun personnel, et de gérer les absences : pouvoir les voir, en ajouter et les modifier.

---
Interface et fonctionnalités
----------------------------
L'application doit permettre de :
-Présenter la liste du personnel de la médiathèque(idpersonnel, nom, prénom, tel, mail, idservice)
les idservice présentes les différents services.
-Permettre d'ajouter un personnel.
-Permettre de modifier un personnel.
-Permettre de supprimer un personnel.
-Permettre de gérer les absences du personnel sélectionné.
--------
Diagramme de paquetage
----------------------
L'application est structurée dans le respect du pattern MVC.
-Le package BDDmanager comprend la classe bddmanager
Classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes.
-Le package dal comprend les classes:
-Access
-AbsenceAccess
-PersonnelAccess
-ResponsableAcess
qui permettent d'exploiter le package bddmanager pour envoyer des requêtes SQL.
------
Présentation du cheminement
---------------------------
L'application démarre sur une vue c'est la structure classique des applications C# de bureau. L'interface de début est l'interface authentification.
Les différents partie communique entres elle pour faire fonctionnée l'application, le package bddmanager et dal permette le bon fonctionnement de l'application 
avec la communication à la base de donnée.
---














