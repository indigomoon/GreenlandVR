# greenlandVR
Reality, Virtually hackathon at MIT

Unity VR project for hackathon.
Currently testing on Mac, target is iOS in Cardboard viewer.

Requirements:
Mac
Unity
Xcode

References:
https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-ios-device-testing

-------
PROBLEM:  
Crashes on startup

SOLUTION:  
Unity bug workaround: in Unity build settings, uncheck auto graphics API, remove the Metal option

-------
PROBLEM:  
Crashes on startup with message 
"This app has crashed because it attempted to access privacy-sensitive data without a usage description. The app's Info.plist must contain an NSCameraUsageDescription key with a string value explaining to the user how the app uses this data."

SOLUTION:  
Unity bug workaround: need to manually add an info.plist entry in Xcode.
In Xcode:
  choose Unity-iPhone project in left sidebar
  choose "info" in menu bar in window
  hover over last entry, click "+"
  add item called "Privacy - Camera Usage Description"
  
--------
