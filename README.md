# Ananas_Dungeon_Projet3
Réalisé par Quentin Leuliet, Adel Ait-Brim et Pierre Boussin

# Présentation du jeu
Notre jeu est un RogueLike où le joueur incarne une créature magique qui veut conquérir un donjon. Le joueur se déplacera donc de salle en salle en combattant des ennemies, il pourra récuperer des pièces ainsi que des clés pour ouvrir des coffres qu'il rencontrera dans certaines salles. Le joueur possède aussi un systeme de sort qui pourront évoluer sur 5 niveau (leurs stats et leurs visuels changeront selon les niveaux), il possède donc un sort de feu qui brule les ennemis, un sort d'éclair qui peut rebondir sur les ennemis proche et un sort de glace qui ralentit les ennemies touchés. Les salles sont générés procéduralement et renouvellés à chaque étage, les mobs sont de plus en plus forts selon les étages.


# Direction artistique 
Pour notre jeu on a voulu un coté "vieux donjon"/magie pour cela nous avons réalisé en 3D des décors comme des vieux murs en pierre, poteau etc pour accentuer le coté ancien. Pour notre inspiration nous nous sommes inspirés des vieux jeux du style ainsi que the binding of isaac. 


# Description du fun 
Le point principal de notre jeu reste les différents sorts. Certains ennemis possède une immunité a certain sort (différent pour chaque) ce qui oblige le joueur a alterner ses sorts selons les situations qu'il rencontre. 

# Problèmes rencontrés
Nous n'avons pas rencontrés de problème particulier, seules le fait que notre jeu soit en 3D avec notre vision du dessus nous a posé quelque problème. 

# Description technique du projet
Au niveau de la génération, je crée un premier salle en haut d'un cube puis je lui dit qu'il a 25 % de chance de crée une salle vers le bas et de creuser un trou vers le bas et 75% de chance de crée une salle vers la droite ou la gauche en crée des trou sur les côtés, si la prochaine salle crée est vers la droite ou gauche et sort de la zone définit elles se transform en salle menant vers le bas, si la salle génére dépasse la limite basse la génération s'arréte. Ensuite je complete le carré avec des salle qui ont un accès minimum a droite et gauche afin qu'elle soit tous accèssibles. 

# Ressenti personel 
Quentin Leuliet : J'ai appris a utiliser Git ainsi que gérer une gestion procédurale. 
Pierre Boussin : Pour ma part j'ai effectuer la gestion du projet ainsi que le coté GD, niveau code j'ai trouvé intéressant de coder le systeme de sort. 
Adel Ait-Brim : J'ai découvert comment animer mon propre personnage 3D ainsi que codé les animations pour les lancer au bon moment via le code

# Lien youtube
- https://youtu.be/GlddIqTiQ6s

# License 
- https://assetstore.unity.com/packages/vfx/particles/spells/magic-vfx-ice-free-170242 (particule sort glace)
- https://assetstore.unity.com/packages/vfx/particles/spells/52-special-effects-pack-10419 (sort feu/éclair)
musique :
8bit Dungeon Level by Kevin MacLeod
Link: https://incompetech.filmmusic.io/song/3331-8bit-dungeon-level
License: https://filmmusic.io/standard-license

Video Dungeon Boss by Kevin MacLeod
Link: https://incompetech.filmmusic.io/song/4583-video-dungeon-boss
License: https://filmmusic.io/standard-license
Mixamo.com
