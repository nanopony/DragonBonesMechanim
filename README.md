# Mechanim wrapper for DragonBones Runtime 

It is a simple wrapper that allows one to use Mechanim coupled with
DragonBones. See Demos/Assets/Scene/Mechanim.unity for an example on how.

Add `StateMachineBehaviourWrapper` to every state in Animator StateMachine builder and fill in transition durations and animation name for states. That behaviour will invoke required animation upon entering the state, and if it is a transition it also will make transition between old and new animations.

## DragonBones C# Runtime

Copyright 2012-2017 The DragonBones Team.
