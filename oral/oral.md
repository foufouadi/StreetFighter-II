# Oral : Street Fighter II simplifié

## Choix
- **Jeu :** Street Fighter II simplifié (une arène, deux combattants, deux joueurs sur le même clavier).
- **Langage et bibliothèque :** C#, que je connais, avec MonoGame, adaptée aux jeux 2D.
- **Version de MonoGame :** OpenGL. C'est la plus ancienne et la plus répandue, donc la plus documentée, et elle fonctionne sur Windows, Linux et macOS.
- **Pas Vulkan ni DX12 :** API plus récentes et plus proches du matériel, donc moins documentées et plus de risques de bugs. DirectX ne fonctionne que sur Windows.

## Sources
J'ai choisi des sites communautaires qui proposent les images, sons et données du jeu déjà extraits et classés. Cela m'évite d'extraire les fichiers du jeu (long, et délicat côté droits d'auteur) et me permet de rester sur une seule version cohérente, la Champion Edition.

- Musiques et sons : https://downloads.khinsider.com/game-soundtracks/album/street-fighter-ii-the-definitive-soundtrack
- Sprites (Ryu, Chun-Li, décor) : https://spritedatabase.net/game/632
- Sprites (interface, effets, écrans) : https://www.spriters-resource.com/arcade/streetfighter2/
- Données des coups : https://wiki.supercombo.gg/w/Street_Fighter_2:_Champion_Edition

Droits : personnages, graphismes et sons appartiennent à Capcom, utilisés uniquement pour ce projet scolaire non commercial.

## Méthode
1. Téléchargement des planches de sprites et des sons.
2. Programme Python (Pillow, SciPy) pour détecter chaque sprite, supprimer le fond et recadrer.
3. Classement par action, avec les feuilles SNES étiquetées comme légende.
4. Vérification automatique (images lisibles, aucun doublon) et aperçus côte à côte Ryu / Chun-Li.

## Problèmes rencontrés

| Problème | Solution |
|---|---|
| Animations mélangées, doublons | Refait de zéro : une action = un dossier, sans doublon |
| Coups reçus confondus | Gardés : visage, corps, accroupi |
| Marche avant et arrière regroupées | Séparées en deux actions |
| Qualité audio (MP3 et OGG perdent, FLAC non lu par MonoGame) | WAV sans perte, FLAC conservés |
| Même nom d'action, coups différents (ex. coup accroupi fort) | Même nom, animation propre à chaque perso |

## Planning

| Période | Objectif |
|---|---|
| Novembre | Sujet validé, projet créé, ressources prêtes, un perso qui bouge |
| Décembre | Animations de base, deux joueurs |
| Janvier | Coups, hitbox, dégâts, barres de vie (prototype jouable) |
| Février | Coups reçus, KO, manches, minuteur, écrans |
| Mars | Deuxième perso complet, décor, sons |
| Avril | Extensions : coups spéciaux, parade, ordinateur |
| Mai | Corrections, tests, rapport |
| Juin | Marge et soutenance |
