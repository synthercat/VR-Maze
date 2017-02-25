# Project from Udacity's VR course
|Name|Antonis Savvidis|
| ---: | :--- |
|Build Platform |Android|
|Unity Version | `5.5.1f1` |
|GVR SDK | `1.0.3` |

Added :
* API set to 19 (google recommended min-API for cardboard)
* Created chest animation
* Created chest script that enables the resetUI when opened and destroys it's boxcollider
* Key Script that also play different sound for key collection
* Key UI to show ownership of found key
* Instrucions
* Completed Maze construction
* Completed coin placement
* Completed main waypoints placement
* Added mesh collider to the Temple to avoid clicking it from outside without going through the door

Fixes :
* Faster lerp speed for waypoints
* Comverted all visible shaders to mobile / unlit

Ok here is what I did so far :
- Added Lerp movement to Udacity's provided waypoints for smoother transition (with the ability to pause between waypoints)
- Added Udacity Icon to the app
- Added rotate animation to the coins
- Added UI that counts the collected coins
- Changed Atlas-1 material for better performace
- Changed GI to Realtime for quick testing
- Changed prefab shaders to mobile or Unlit for performance
- Removed shadows from the waypoint objects
- Modeled my own walls for better placement
- Created material from them
