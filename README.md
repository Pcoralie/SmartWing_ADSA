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


#### Step 1 :
Compute real airplane trajectory from point S(start point) to point E (end point)
Plane moves in a 2D space with Longitude and Latitude.

In a second time we can eventually have a third dimension which is the altitude.

#### Step 2:
Convert the trajectory into commands.



## State of the Art :

* Dubins :
The shortest curve that connects two points in the two-dimensional Euclidean plane (i.e. x-y plane) with a constraint on the curvature of the path and with prescribed initial and terminal tangents to the path, and an assumption that the vehicle traveling the path can only travel forward. The shortest path will be made by joining circular arcs of maximum curvature and straight lines.

* A* :
Used in pathfinding and graph traversal, which is the process of finding a path between multiple points, called “nodes”. It aims to find a path to the given goal node having the smallest cost (least distance travelled, shortest time, etc.).
It extends Dijkstra's algorithm and achieves better performance by using heuristics.

## Current Process

#### 2D

For this step we used the code "dubins_path_planning.py" from author Atsushi Sakai:
[dubins path planning 2D](https://github.com/AtsushiSakai/PythonRobotics/blob/master/PathPlanning/DubinsPath/dubins_path_planning.py). 

This code plot the trajectory from one point to an other point in a 2D space picture.

#### 3D

Plane moves in 3D space with Longitude, Latitude and altitude.

For this step we use the code :  [dubins Airplane 3D](https://github.com/unr-arl/DubinsAirplane "dubinsAirplane").

Dubins airplane is an extension of the classical Dubins car model for the 3D case of an ariplane. In dubins airplane paths there are the altitude component.  Based on the difference between the altitude of the initial and final configurations, Dubins airplane paths can be classified as low, medium, or high altitude gain.

To have more information, the website of Kostas Alexis : [Kostas Alexis](http://www.kostasalexis.com/dubins-airplane.html "dubins-airplane-kostas")
