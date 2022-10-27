PongProject Write-Up

With this project I created Pong.
The Paddle script allows you to move the two paddles on either side of the screen and uses the RigidBody2D component to allow the Ball to bounce off it.
The Ball script allows the Ball to move around the screen freely and again uses the RigidBody2D component so that it bounces off of other objects (there is also Physics material 2D attached to the Ball object).
The GameManager script brings everything together and allows the scores to be updated using text mesh pro, and this script also allows you to use the ‘escape’ key to quit the game.
The Goal script makes it so the scores change when the ball interacts with the player’s goals.
Player1’s paddle is controlled using ‘s’ key to move up and ‘w’ key to move down, while Player2’s paddle is controlled using the ‘up’ and ‘down’ keys.
The controls were configured using Unity’s Input Manager. 