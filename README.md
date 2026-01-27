TP#3 – Application de gestion de bibliothèque
Programmation avancée de base de données (420-PA6-AG)
Institut Grasset – Automne 2025
AININE Ghiles
AISSY Samy
BAAHMED Abderezak

1. Contexte et objectif général
Le client, une bibliothèque, souhaite disposer d’une application de gestion centralisée permettant de gérer efficacement l’ensemble de ses activités quotidiennes.
Cette application doit regrouper les informations relatives aux livres, usagers, emprunts, activités (concours et événements) ainsi qu’au matériel empruntable.
L’objectif principal est de faciliter les opérations courantes (ajout, modification, consultation, suppression) tout en offrant des rapports de synthèse permettant d’obtenir rapidement un portrait global de la situation (emprunts en cours, participations aux activités, évaluations des livres).
 Périmètre du système
Le système doit permettre une gestion complète (CRUD) pour chaque domaine fonctionnel et offrir des écrans de consultation ainsi que des rapports de synthèse adaptés aux besoins de la bibliothèque.

2. Besoins fonctionnels
2.1 Gestion des livres
Ajouter, consulter, modifier et supprimer des livres.

Conserver les informations essentielles : titre, auteur(s), catégorie(s), quantité d’exemplaires disponibles.

Permettre la consultation de la liste des livres avec des fonctions de recherche et de filtrage : 

2.2 Gestion des usagers
Ajouter, consulter, modifier et supprimer un usager.

Enregistrer les coordonnées de contact.

Gérer le statut d’un usager (actif ou inactif).

2.3 Gestion des emprunts
Enregistrer les emprunts de livres par les usagers (date d’emprunt, date de retour prévue).

Suivre l’état d’un emprunt (en cours, en retard, retourné).

Consulter l’historique des emprunts d’un usager.
 

2.4 Gestion des activités (concours et événements)
Créer et gérer des activités regroupant les concours et événements sous une entité commune.

Enregistrer les participations des usagers.

Gérer la capacité maximale et consulter la liste des participants.
 

2.5 Gestion du matériel
Enregistrer et gérer le matériel empruntable (ex. : laptop, projecteur).

Suivre la disponibilité, les emprunts et l’historique du matériel.
 

2.6 Rapports
Générer des synthèses ciblées :

Emprunts par usager.

Participations par activité.

Évaluations et statistiques sur les livres (moyenne, commentaires).

2.7 Mises à jour et corrections
Modifier ou supprimer un livre, un usager, un emprunt, une participation ou un emprunt de matériel lorsque nécessaire.
 

3. Contraintes et attentes du client
L’intégrité des données doit être respectée : la suppression d’un usager ou d’un livre ne doit pas entraîner la perte de l’historique des emprunts ou des évaluations.

L’interface utilisateur doit être simple, cohérente et facile à utiliser.

Le projet doit être structuré, documenté et livré avec un historique Git clair et cohérent.


4. Décomposition en modules fonctionnels
L’application est divisée en modules afin de séparer clairement les responsabilités et faciliter l’évolution, les tests et la maintenance.
Modules principaux
1.	Gestion des livres

 Catalogue des livres, recherche, filtrage, évaluations.

2.	Gestion des usagers

 Profils usagers, statut actif/inactif, historique.

3.	Gestion des emprunts

 Prêts, retours, règles de disponibilité.

4.	Gestion des activités

 Concours et événements, inscriptions et participants.

5.	Gestion du matériel

 Inventaire, prêts et historique.

6.	Rapports

 Synthèses et statistiques.

7.	Connexion et persistance

 Accès aux données via repositories et gestion des transactions.

8.	Interface utilisateur

 Écrans CRUD, écrans de consultation et rapports.


5. Modélisation conceptuelle – Entités principales
Usager
●	UsagerId (PK)

●	Nom, Prénom

●	Email, Téléphone, Adresse

●	Statut (Actif / Inactif)

●	DateInscription

Livre
●	LivreId (PK)

●	Titre

●	ISBN

●	QuantiteExemplaires

●	Description

Auteur
●	AuteurId (PK)

●	Nom, Prénom

Catégorie
●	CategorieId (PK)

●	NomCategorie

Emprunt
●	EmpruntId (PK)

●	DateEmprunt

●	DateRetourPrevue

●	DateRetourReelle

●	État

●	UsagerId (FK)

●	LivreId (FK)

Activité
●	ActiviteId (PK)

●	Titre, Description

●	Type (Concours / Événement)

●	Dates

●	CapaciteMax

●	EmployeId (FK)

Participation
●	UsagerId + ActiviteId (PK composite)

●	DateInscription

●	StatutParticipation

Matériel
●	MaterielId (PK)

●	Nom, TypeMateriel

●	NumeroSerie

●	Etat

●	QuantiteDisponible

EmpruntMatériel
●	EmpruntMaterielId (PK)

●	Dates

●	État

●	UsagerId (FK)

●	MaterielId (FK)

Employé
●	EmployeId (PK)

●	Nom, Prénom

●	Rôle
Évaluation
EvaluationId (PK)
Note
Commentaire
DateEvaluation
UsagerId (FK)
	LivreId (FK)


6. Modélisation relationnelle
Le modèle relationnel repose sur :
●	Des clés primaires clairement définies.
●	Des clés étrangères assurant l’intégrité référentielle.
●	Des tables de liaison pour les relations plusieurs-à-plusieurs.
●	Des contraintes de validation (états, plages de valeurs, unicité).

Règles importantes de suppression:
●	Aucune suppression en cascade dangereuse sur les historiques (emprunts, évaluations).
●	Les tables de liaison peuvent utiliser des suppressions en cascade contrôlées.


7. Conclusion
Cette modélisation propose une solution complète, cohérente et évolutive répondant aux besoins exprimés par le client.
La séparation en modules, le respect de l’intégrité des données et la clarté du modèle relationnel assurent une base solide pour l’implémentation avec Entity Framework et SQL Server
