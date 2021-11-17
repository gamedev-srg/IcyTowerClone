# Icy Doodle Jump!

This is an icy doodle jumper clone with 4 different difficulty levels

The game implements Unity physics and required the player to jump through all of the obstacles in order to finish the game

The Controls are - Use A to go left and D to go right, Press Space to jump.
the only question now is can you finish the game?


Our game is using riggedbody2d to animate the charecter, if you collied with the edge of a platform you can see that ball spinning, we used Unity's gravity system. and to 
make the player move left and right we used Velocity. Notice that when a player jumps, he cant jump whilst in the air.
that is because we used raycasthit, we and we layred the platforms so the only object the ray can interact with is the platform.
we made a follower script so the ball could spin in place and the player could move it freely while the screen seen to satnd still , the background actually follows the player,
and the rotation is being resert each frame.

For scene transition in the different levels we used a different scene for each level and at the end of each and every level wev'e set a 2D object which when it comes with contact with the Player tag calls the SceneManager and appends 1 to the current level. 
This process was a bit tricky and buggy, at first we tried to call each scene by name and found out a lot of people are having trouble with that feature so we thought about appending the scenes by order.

For the game fail and restart we used a border limit for the game map which is below zero. If the player falls down beneath this point the stage will restart by calling the SceneManager.
