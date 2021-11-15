# Sequence Lock

A component that allows you to create a lock / unlock mechanism using a sequence of switches.

## Requirements

1. Any number of 3D switch objects with colliders that you can click on with the mouse.
2. A lock object which can be opened using a script.

## How to use

Add the `Switch` component to each of the objects you wish to use as a switch for the lock. You can attach the `onClickEffect` event to any effect you want to use to indicate to the press to the player. For example, you could attach this to an `AudioSource` and play a sound.

Add the `Lock` component to the object you wish to use to represent the lock. This script contains the array `Switches`. You need to drag in the sequence of switches in order that unlock it. You can repeat switches in this sequence.

Attach the `onUnlock` event of the `Lock` script to any object to provide unlock feedback. For example, you could attach this event to an `Animator` object and trigger an unlock animation.
