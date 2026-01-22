TP#3 – Application de gestion de bibliothèque
Programmation avancée de base de données (420-PA6-AG)
 Institut Grasset – Automne 2025
 
Baahmed Abderezak
Ainine Ghiles
Aissi SAMI 

1. Contexte et objectif du projet
Dans le cadre du TP#3, nous avons développé une application de gestion pour une bibliothèque.
 L’objectif principal est de centraliser et faciliter la gestion des livres, des usagers, des emprunts, des activités (concours et événements) ainsi que du matériel empruntable.
L’application permet au personnel de la bibliothèque d’effectuer les opérations courantes (ajout, modification, consultation, suppression) et d’obtenir des rapports synthétiques afin de suivre efficacement la situation des emprunts, des participations et des évaluations de livres.

2. Besoins fonctionnels
2.1 Gestion des livres
Ajouter, consulter, modifier et supprimer des livres.


Enregistrer les informations essentielles : titre, auteurs, catégories, quantité d’exemplaires et disponibilité.


Rechercher et filtrer les livres selon différents critères.


Gérer les évaluations des livres (notes et commentaires).<



2.2 Gestion des usagers
Ajouter, consulter, modifier et supprimer un usager.


Enregistrer les coordonnées de contact.


Gérer le statut d’un usager (actif ou inactif).


Consulter l’historique des emprunts, participations et emprunts de matériel.


2.3 Gestion des emprunts de livres
Enregistrer un emprunt (usager, livre, dates).


Gérer les dates d’emprunt et de retour.


Suivre l’état d’un emprunt (en cours, en retard, retourné).


Consulter la liste et l’historique des emprunts par usager.


2.4 Gestion des activités (concours et événements)
Créer et gérer des activités regroupées sous une entité Activité.


Distinguer les activités par type (concours ou événement).


Gérer la capacité maximale d’une activité.


Enregistrer et consulter les participations des usagers.


2.5 Gestion du matériel
Enregistrer et gérer le matériel empruntable (ex. ordinateurs portables, projecteurs).


Suivre la disponibilité du matériel.


Gérer les emprunts et consulter l’historique.





2.6 Rapports
Générer des rapports ciblés :


Emprunts par usager (avec état).


Participations par activité.


Évaluations des livres (moyenne, distribution, commentaires).


2.7 Mises à jour et corrections
Modifier ou supprimer un livre, un usager, un emprunt, une participation ou un emprunt de matériel lorsque nécessaire.


3. Contraintes et attentes de qualité
L’intégrité des données doit être respectée :
 La suppression d’un usager ne doit pas effacer l’historique de ses emprunts ou évaluations.


L’interface doit être simple, claire et cohérente.


Le projet doit respecter une architecture en couches avec le patron Repository.


Le code doit être structuré, documenté et maintenu dans un dépôt Git avec des commits réguliers et compréhensibles.


Périmètre du projet
 Le système doit permettre une gestion complète (CRUD) pour chaque domaine et offrir des écrans de consultation ainsi que des rapports de synthèse.








4. Décomposition en modules
L’application est divisée en modules fonctionnels afin de séparer clairement les responsabilités et faciliter la maintenance.
Modules principaux
Gestion des Livres


Catalogue des livres (titre, auteurs, catégories, quantité).


Recherche, filtre et consultation.


Gestion des évaluations.


Gestion des Usagers


Profil et coordonnées.


Gestion du statut actif/inactif.


Consultation de l’historique.


Gestion des Emprunts


Création et gestion des emprunts.


Gestion des retours et des états.


Vérification de la disponibilité des exemplaires.


Gestion des Activités (Concours / Événements)


Création et gestion des activités.


Gestion des participations.


Consultation des participants.


Gestion du Matériel


Inventaire du matériel.


Gestion des prêts, disponibilité et historique.


Rapports


Emprunts par usager.


Participations par activité.


Évaluations des livres.


Connexion et Persistance


Accès aux données via des repositories.


Utilisation d’Entity Framework et LINQ.


Gestion du contexte de base de données.


Interface Utilisateur


Écrans CRUD pour chaque domaine.


Écrans de consultation et de rapports.


Validation des données.


5. Technologies utilisées
Langage : C#


Base de données : SQL Server


ORM : Entity Framework (Code First + Migrations)


Requêtes : LINQ


Interface : Windows Forms / Web


Contrôle de version : Git






6. Aide à l’utilisation
Cloner le dépôt Git du projet.


Ouvrir la solution dans Visual Studio.


Appliquer les migrations pour créer la base de données.


Lancer l’application.


Utiliser les menus pour gérer les livres, usagers, emprunts, activités, matériel et consulter les rapports.



7. Conclusion
Cette application répond aux besoins exprimés par le client en offrant une gestion complète et structurée d’une bibliothèque.
 Elle respecte les contraintes techniques et fonctionnelles demandées et permet une évolution future grâce à une architecture claire et modulaire.

