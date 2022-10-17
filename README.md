# 2D-Platformer
 This is my repository for a 2D platformer that I made over a two week period as a project for The Tech Academy. I utilized the Unity Engine and C# scripts.
 
 ## Scene Controller
 I began by creating a title screen, the scene where the actual game is played and a screen that displays when the game ends. The transition between scenes were controlled by buttons on the title screen and game over scene. At a later time I made a scene that loads when the user completes the goal of the game by collecting five coins throughout the level and reaching the end goal posts.
 
![Screenshot (192)](https://user-images.githubusercontent.com/104886422/196090577-2a8b5625-1184-4982-9b0f-b1d5319ce7bb.png)
![Screenshot (193)](https://user-images.githubusercontent.com/104886422/196091007-383fae22-ca4f-4272-ba0c-ecc6ee069fb8.png)

## Player Controller
The player object is controlled using the arrow keys and the WASD keys. The W and up arrow keys are used to make the player jump. The player has colliders attached that are used to determine if they are in a jumping state, if the collide with an enemy object that will load the game over scene and will collect a coin if they collide with the coin object, which is counted and displayed in the UI in the top left corner of the screen.

A collider is also positioned below the view of the camera that loads the game over screen upon collision if the player falls off the map.

![Screenshot (194)](https://user-images.githubusercontent.com/104886422/196093311-1284cb5d-5aa9-4dcc-94ed-2358022dc65a.png)
![Screenshot (195)](https://user-images.githubusercontent.com/104886422/196093489-36e6585e-a3b1-4ecb-9895-11baf3459842.png)

## Enemy Controller
The enemy objects patrol the areas in which they are placed. Their scripts have them turn around and move in the opposite direction if they collide with an object, such as the vertical platforms. This doesn't include collisions with the player as it loads the game over screen immediatley upon collision, or if the player collides with the top of the enemy, then the enemy object is destroyed.

![Screenshot (196)](https://user-images.githubusercontent.com/104886422/196094327-cd5830ce-2896-4880-8058-60d9b106df95.png)
![Screenshot (197)](https://user-images.githubusercontent.com/104886422/196094471-11c6f48b-7dcf-40be-a37d-37bff9f3cca5.png)
