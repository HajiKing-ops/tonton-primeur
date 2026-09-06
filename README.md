# Tonton Primeur - Gestion de stock

Application de bureau développée en C# avec Windows Forms pour gérer les articles (fruits et légumes) et leurs fournisseurs.

Ce projet a été réalisé dans le cadre d'un TP d'apprentissage de WinForms, ADO.NET et MySQL/MariaDB.

## Fonctionnalités

### Gestion des articles

- Afficher les articles avec le nom de leur fournisseur
- Ajouter un article
- Sélectionner un article dans le tableau
- Modifier un article
- Supprimer un article avec confirmation
- Trier les articles par nom : A à Z et Z à A
- Choisir le fournisseur associé à un article dans une ComboBox

### Gestion des fournisseurs

- Afficher les fournisseurs
- Ajouter un fournisseur
- Sélectionner un fournisseur dans le tableau
- Modifier un fournisseur
- Supprimer un fournisseur avec confirmation
- Empêcher la suppression d'un fournisseur encore associé à des articles grâce à la contrainte de clé étrangère de la base de données

## Technologies utilisées

- C#
- Windows Forms
- ADO.NET
- MySQL / MariaDB
- XAMPP (serveur local de développement)
- NuGet : `MySqlConnector`
- Git

## Base de données

La base de données se nomme `stock_fruits_legumes` et contient deux tables :

- `article`
- `fournisseur`

Relation : un fournisseur peut fournir plusieurs articles. Chaque article est associé à un seul fournisseur.

Importez le fichier `stock_fruits_legumes.sql` dans phpMyAdmin ou dans votre serveur MySQL/MariaDB avant de lancer l'application.

## Installation et lancement

1. Cloner le dépôt :

   ```bash
   git clone <url-du-depot>
   ```

2. Importer `stock_fruits_legumes.sql` dans MySQL/MariaDB.
3. Démarrer MySQL dans XAMPP.
4. Ouvrir la solution dans Visual Studio.
5. Vérifier la chaîne de connexion dans la classe `Data/Database.cs` : serveur, port, nom de base, utilisateur et mot de passe.
6. Restaurer les packages NuGet si Visual Studio le demande.
7. Compiler puis lancer le projet avec `F5`.

## Sécurité et bonnes pratiques

- Les requêtes `INSERT`, `UPDATE` et `DELETE` utilisent des paramètres SQL.
- Les suppressions demandent une confirmation à l'utilisateur.
- Les connexions et commandes MySQL sont libérées avec `using`.
- Ne publiez pas un vrai mot de passe de base de données dans Git. Pour un projet réel, placez la chaîne de connexion dans un fichier de configuration ignoré par Git.

## Auteur

Roman Salamzada

