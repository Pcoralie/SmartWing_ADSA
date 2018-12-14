# SmartWing_ADSA

The project consists in developing the code of a smart Wing.  

## Flight path :

* acceleration
* rotation
* ascent
* put in landing
* stabilisation
* put in position
* circular flight around coordinates of take-off
* put in position
* descent
* approach/transition
* rounding
* touch down

## Objectives / goals

We are interested in the phase of acceleration, descent and circular flight around coordinates of take-off.
The idea of this project is to code trajectories and to extract an image of the trajectory and a text file with the commands to be transmitted to the wing.



![flying_wing](img/FlyingWing.jpg)

The Wing can :
* accelerate / decelerate
* go up / go down
* rotate right /rotate left
* open / close landing gear


#### Step one :
Compute real airplane trajectory from point S(start point) to point E (end point)
Plane moves in a 2D space with Longitude and Latitude.

In a second time we can eventually have a third dimension which is the altitude.

#### Step two:
Convert the trajectory into commands.





## State of the Art :

* Dubins :
The shortest curve that connects two points in the two-dimensional Euclidean plane (i.e. x-y plane) with a constraint on the curvature of the path and with prescribed initial and terminal tangents to the path, and an assumption that the vehicle traveling the path can only travel forward. the shortest path will be made by joining circular arcs of maximum curvature and straight lines.

* A* :
Used in pathfinding and graph traversal, which is the process of finding a path between multiple points, called “nodes”. It aims to find a path to the given goal node having the smallest cost (least distance travelled, shortest time, etc.).
It extends Dijkstra's algorithm and achieves better performance by using heuristics.
