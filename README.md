# Unity Graphics Final

## The Original Goals for my project:
  Initially, I was not too sure what I wanted out of this project, but I knew from the start that I wanted to dabble in Virtual Reality using my Oculus Rift. Going into the project and this semester, I did not know anything about developing for VR or using the Unity Engine. With Unity, I wanted to experiment with shaders, lighting, and a different render pipeline than the one chosen by default. By the end of the project, I chose the Universal Render Pipeline(URP), modified the Lighting settings and tested different lighting methods such as Emission, and got Virtual Reality support in my project.

## The Major Features in the current project:
  The most prominent features in the current project would include the Virtual Reality support and combination of Shaders and Emission. To get Virtual Reality supported in the project, I had to decide between a lot of factors: which VR devices would be best supported (both OpenVR and Oculus currently) and which method I would use to set up my XR Rig. I ended up using the XR Interaction Toolkit preview package with the built-in project settings. The emission used in my project works with the Runtime/Realtime lightmaps and uses post-processing to enhance the effects. This is most notable on the “orb” that glows bright until the player smashes it with their hand (which has destruction physics).

## Moments where I learned the most:
  There are many moments during my work on this project where I had to learn something new, but the most distinguishable would be the moment I got a clear understanding of how VR/XR is supported in Unity and how to implement realistic destruction physics. Learning about XR Support and the different approaches you can take in Unity is Unity-specific, but I found it very useful in case I ever want to use it again (which I would love to). The destruction effect that was applied to the “magical orb” is enabled once the player smashes it with their hand. I learned much about the colliders/rigidbodies in Unity as well as how to quickly get an asset to look like it’s shattered apart into a defined number of pieces. The resulting Orb, combined with the emissive lighting and post-processing, created something that I am very proud of as someone new to Unity.
  
References:
 * https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@0.9/manual/locomotion.html
 * https://docs.unity3d.com/Manual/PhysicsSection.html

## The Next Steps to create a Portfolio piece:
  After the player destroys the orb, I was not sure what could/should come next. I thought it would be fun to take the player and change their environment drastically – from a medieval, fantasy crypt to a futuristic computer simulation (like in TRON). I managed to get a solid base environment built, but I am still creatively stumped. Towards the end of the project, my goal was to create a shader that dissolved the world around the player (instead of just temporarily blinding the player with a flash). The problem with this was that I lack the knowledge of replacement shaders. It turns out that I would need replacement shaders on the camera to effectively apply a shader that could affect every object in the scene (without replacing each material). If I could figure out how to get a replacement shader to work, I would be more than welcome to showing this off as a portfolio piece. 


Some of the documentation that I’ll be looking at to guide me in the right direction:
 * https://developer.oculus.com/documentation/unity/unity-gs-overview/?device=RIFT</li>
 * https://docs.unity3d.com/Manual/VROverview.html</li>
 * https://learn.unity.com/tutorial/introduction-to-lighting-and-rendering</li>
 * https://unity.com/ray-tracing</li>

