* CAMERA TOUR CREATOR *
	v. 1.0
Copyright 2014-2015 Authors of www.AIBotSystem.com. All Rights Reserved.

This system gives you a cost-effective, bloat-free, and simple way of rapidly creating automatic camera tours.

To get started, play the 3 example scenes.

NOTE: The example scenes will throw "Script not found" warnings.  These all point to the Bootcamp map.  This is due to using the Unity's free Bootcamp map.  We only needed the terrain so we removed the scripts for that project.
It does not impact the product you purchased in any way.


WHAT IT DOES: It allows a camera in your scene to automatically fly around smoothly, giving your user a "tour" of the scene.  
This is great for cut-scenes, cinematics, and game demos.  
It's also very useful if you are an artist and you have environment products to sell on the Asset Store and want a fast, 
easy solution for showcasing your beautiful environments!



HOW TO USE: 
	1) Add the "CameraTourCreator.dll" component to your camera.
	
	2) Drag the "Camera Waypoint Route" prefab onto the scene.
	This prefab allows you to visually edit the waypoints for the camera movement.
	You may add unlimited Waypoint Nodes. Simply copy/paste them around your scene. If you're doing it right, they will connect.
	If not, make sure Gizmos are turned on in the Editor.
	The camera will only recognize waypoint nodes that are direct children of the Camera Waypoint Route parent object. 
	The first Waypoint Node is the first location to fly to.


	3) With your waypoints setup, now go back to your camera and find the Camera Tour Creator component.
	4) Drag the "Camera Waypoint Route" gameobject you just used into the "Waypoint Route" slot.
	5) Your waypoints are now set up in the camera.  At this point you are ready to go.


OPTIONAL SETTINGS:
	Movement Type: 
		1) PLAY_LOOP = Camera will follow waypoints, then go back and loop again, forever.
		2) PLAY_ONCE = Camera will follow waypoints, and stop at last waypoint.
		3) PLAY_RANDOM = Camera will follow waypoints in random order.

	Rotation Type:
		1) OBJECT_FOCUS = Camera will always look at an object [Object to Focus slot], while following the waypoints.
		2) AUTO_Y_ROTATE = Camera will auto rotate on the Y axis while flying through the waypoints. Set the speed of rotation at "Auto Rotate Speed"
		
	Object To Focus: The GameObject to always focus on.  Used by OBJECT_FOCUS.
	
	Auto Rotate Speed: Y-axis rotation speed of the camera while moving through waypoints. Used by AUTO_Y_ROTATE

	Seconds to Pause: # seconds to pause at a waypoint, before moving onto the next one.

	Waypoint Route: The waypoint parent gameobject that contains the waypoint child nodes.

	Cam Speed: The speed of the camera flying through the waypoints.

	Waypoint Stop Dist: The minimum distance the camera will reach to a waypoint before moving to the next one.




PUBLIC VARIABLE REFERENCE (C#):
	ObjectToFocus : GameObject
	AutoRotateSpeed : Float
	SecondsToPause : Float
	WaypointRoute : GameObject
	CamSpeed : Float
	WaypointStopDist : Float

	public enum MovementType { PLAY_LOOP, PLAY_ONCE, PLAY_RANDOM }
	public MovementType movementType = MovementType.PLAY_LOOP;	


	public enum RotationType { OBJECT_FOCUS, AUTO_Y_ROTATE }
	public RotationType rotationType = RotationType.AUTO_Y_ROTATE;

---------------------------------------------

Thank you for your purchase! 
Any questions or if you need help, please contact us at aibotsystem@gmail.com.

---------------------------------------------

Custom Development: Sorry, we cannot perform custom development for your game projects. 
Due to legal reasons, please do not send us your game ideas, source code, project files, or your copyrighted materials, since we create games ourselves :)