# GreenlandVR
Virtual reality visualization of Greenland glacier  

"Reality, Virtually, Hackathon" at MIT  
http://www.realityvirtuallyhack.com  

This is a simple app that was developed by team "Ice Breakers" at a weekend hackathon devoted to virtual and augmented reality.
At various times it was working on a Samsung phone in a GearVR,
and an iPhone in a Google Cardboard.  

-------
REQUIREMENTS  

These are the requirements for some configurations we have tried:

iPhone target:
- Mac  
- Unity  
- Google VR SDK for Unity
- Xcode  
- iPhone  
- Google Cardboard-compatible VR viewer  

macOS desktop target:
- Mac
- Unity

Android phone target:
- Windows/Linux
- Unity
- Google VR SDK for Unity
- Android SDK
- Oculus run-time library
- Samsung phone  
- Samsung GearVR

-------
INSTALLATION  

1) Clone project  
2) Open it as a new project in Unity  
3) Select File > Build & Run  
4) When it asks where to save the build, create a folder called "Builds" in the project folder,  
   and then save the build as "iOS" in that folder.

-------
REFERENCES  

https://docs.unity3d.com/Manual/ExternalVersionControlSystemSupport.html  
https://unity3d.com/learn/tutorials/topics/mobile-touch/building-your-unity-game-ios-device-testing  

--------
ISSUES

Here are some issues we ran into, and some solutions.  If you figure out how to solve other issues, please put the solution here.

======
Problem:  
Xcode build error:
Signing for "Unity-iPhone" requires a development team. Select a development team in the project editor.
Code signing is required for product type 'Application' in SDK 'iOS 10.0'

Solution:  
Need to choose a development team in Xcode General project settings.
  - in Xcode, select "Unity-iPhone" project in left sidebar
  - select "Unity-iPhone" target in inner sidebar
  - choose "General" in menu bar in window
  - in "Signing" section, select a Team from the popup


======
Problem:  
Crashes on startup

Solution:  
Unity bug workaround:  
  - in Unity Build Settings  
  - click "Player Settings..."  
  - in Inspector window, uncheck "Auto Graphics API"  
  - remove the Metal option


=====
Problem:  
Crashes on startup with message
"This app has crashed because it attempted to access privacy-sensitive data without a usage description. The app's Info.plist must contain an NSCameraUsageDescription key with a string value explaining to the user how the app uses this data."

Solution:  
Unity bug workaround: need to manually add an info.plist entry in Xcode.
  - in Xcode, select "Unity-iPhone" project in left sidebar
  - select "Unity-iPhone" target in inner sidebar
  - choose "Info" in menu bar in window
  - hover over last entry, click "+"
  - add item called "Privacy - Camera Usage Description"

=====  

--------
