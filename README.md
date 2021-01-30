# Ananas_Dungeon_Projet3
Réalisé par Quentin Leuliet, Adel Ait-Brim et Pierre Boussin

# Présentation du jeu
Notre jeu est un RogueLike où le joueur incarne une créature magique qui veut conquérir un donjon. Le joueur se déplacera donc de salle en salle en combattant des ennemies, il pourra récupérer des pièces ainsi que des clés pour ouvrir des coffres qu'il rencontrera dans certaines salles. Le joueur possède aussi un système de sort qui évolue sur 5 niveaux (leurs stats et leurs visuels changeront selon les niveaux), il possède donc un sort de feu qui brule les ennemis, un sort d'éclair qui peut rebondir sur les ennemis proches et un sort de glace qui ralentit les ennemies touchées. Les salles sont générées procéduralement et renouvelés à chaque étage, les mobs sont de plus en plus forts selon les étages.


# Direction artistique 
Pour notre jeu on a voulu un côté "vieux donjon"/magie pour cela nous avons réalisé en 3D des décors comme des vieux murs en pierre, poteau etc pour accentuer le côté ancien. Pour notre inspiration nous nous sommes inspirés des vieux jeux du style ainsi que the binding of isaac. 


# Description du fun 
Le point principal de notre jeu reste les différents sorts. Certains ennemis possèdent une immunité à certain sort (différent pour chacun) ce qui oblige le joueur à alterner ses sorts selon les situations qu'il rencontre. 

# Problèmes rencontrés
Nous n'avons pas rencontré de problème particulier, seules le fait que notre jeu soit en 3D avec notre vision du dessus nous a posé quelques problèmes. 

# Description technique du projet
Au niveau de la génération, je crée une première salle en haut d'un cube puis-je lui dit qu'il a 25 % de chance de créer une salle vers le bas et de creuser un trou vers le bas et 75% de chance de créer une salle vers la droite ou la gauche en crée des trous sur les côtés, si la prochaine salle créee est vers la droite ou gauche et sort de la zone définit elles se transform en salle menant vers le bas, si la salle générée dépasse la limite basse la génération s'arrête. Ensuite je complète le carré avec des salles qui ont un accès minimum à droite et gauche afin qu'elle soit toutes accessibles. 

# Ressenti personel 
Quentin Leuliet : J'ai appris à utiliser Git ainsi que gérer une gestion procédurale. 
Pierre Boussin : Pour ma part j'ai effectué la gestion du projet ainsi que le coté GD, niveau code j'ai trouvé intéressant de coder le systeme de sort. 
Adel Ait-Brim : J'ai découvert comment animer mon propre personnage 3D ainsi que codé les animations pour les lancer au bon moment via le code

# Lien youtube
- https://youtu.be/GlddIqTiQ6s

# License 
- https://assetstore.unity.com/packages/vfx/particles/spells/magic-vfx-ice-free-170242 (particule sort glace)
- https://assetstore.unity.com/packages/vfx/particles/spells/52-special-effects-pack-10419 (sort feu/éclair)
- musique :
- 8bit Dungeon Level by Kevin MacLeod
Link: https://incompetech.filmmusic.io/song/3331-8bit-dungeon-level
License: https://filmmusic.io/standard-license

- Video Dungeon Boss by Kevin MacLeod
Link: https://incompetech.filmmusic.io/song/4583-video-dungeon-boss
License: https://filmmusic.io/standard-license
- Mixamo.com
