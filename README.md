# Pour faire l'installation et la configuration

1. Installer TortoiseSvn (https://tortoisesvn.net/downloads.html)
   - Choisir version 32-bit ou 64-bit [selon que "C:\Program Files (x86)" existe => 64-bit, sinon 32-bit]
   - Choisir version courante (1.14.3)
  
2. Créer un compte github
   1. Dans votre compte github, créer un Personal Access Token (https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token)
      - À l'étape #7, choisir "Never" comme date d'expiration.
      - À l'étape #8, choisir juste "repo"
   3. Copier & Coller votre PAT produit quelque part, vous allez en avoir de besoin plus tard et vous ne pourrez plus le "revoir"
      - Suggestion: Copier-le dans un fichier google doc de votre choix pour le garder bien en sécurité.

3. Se faire inviter au projet http://github.com/philibertperusse/TestSvnUnity
   - Aller dans le projet github cliquer sur "Code" et copier le URL du projet

4. Telecharger (checkout) le projet github sur votre disque
   - Voir étapes 1, 2 & 3 à l'adresse suivante https://docs.github.com/en/get-started/importing-your-projects-to-github/working-with-subversion-on-github/support-for-subversion-clients
   - Dans Windows Explorer, naviguer dans votre dossier où vous voulez mettre votre projet (exemple: C:\Users\beatr\)
   - Faire "click-droit" sur la souris dans le dossier, et choisir "SVN Checkout"
     - Dans le champ "URL of repository", copier le URL du projet
     - Dans le champ "Checkout directory", ajuster le nom du dossier où mettre votre projet localement (ex: enlever le .git et donner un meilleur nom)
 
5. Ouvrir le projet dans Unity
   - Faire "open", "Add project from disk"
   - Naviguer vers votre projet et ensuite dans le sous-dossier "trunk" et faire "Add project"
   - Ouvrir le projet en cliquant dessus
   
6. Faire une première modification pour lier votre compte github à ce projet
   - Dans Unity, Ajouter une scène à votre nom dans Unity et faire un save.
   - Dans TortoiseSvn (Windows Explorer, sur le dossier "trunk" faire un click-droit) et faire "SVN Commit..."
   - Dans la fenêtre SVN, choisir vos nouveaux fichiers et faire "Add"
     - Si les dossiers Temp, Log, UserSettings ou Library apparaissent, faire click droit et choisir "Add to ignore list"
   - Dans la fenêtre, inscrire un petit message qui explique votre changement
   - Faire "Commit"
   - Dans la nouvelle fenêtre, inscrire vos accès Github:
     - Nom d'utilisateur: adresse courriel que vous avez utilisée pour créer votre compte github
     - Mot de passe: le PAT que vous avez créé précédemment.

7. Voilà vous êtes prêts à ajouter des éléments dans votre projet et à collaborer en équipe.
     
