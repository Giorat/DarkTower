DarkTower
===================

This a simple Unity project to test out simple **teleport system for google cardboard** v2 for specific objects/floor with the Dark Tower from "the Dark Tower" books/movie .

![app interaction showcase](https://media.giphy.com/media/xT0xewlzfks0B4rIeA/giphy.gif)
<br>

**Usage STEP by STEP**
 1. Make sure your scene has a Player character with inside the Camera and choose a Teleport-able container that the user can click to teleport to.
 2.  Add [Teleport Script](https://github.com/Giorat/DarkTower/blob/master/Assets/Teleport.cs) to your Player with the children Camera as Camera parameter
 3. Add [V Reyecaster Script](https://github.com/Giorat/DarkTower/blob/master/Assets/VReyecaster.cs) to your Camera
 4. Add an Event Trigger to your Teleport-able container such as terrain or floor and add a Pointer Click event with an object referring to your Player from step 1 with the TeleportRandomly function selected.

**Final Scene should look like this:**
<br>
![unity3d scene objects and scripts](https://preview.ibb.co/hgXUdG/settings_to_teleport.png)
<br>
If you have any problem tweet me at [@giorat96](https://twitter.com/Giorat96).
 
