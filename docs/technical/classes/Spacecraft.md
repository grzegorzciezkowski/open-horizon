# Spacecraft

Behavior responsible for handling spacecraft movement, including acceleration, deceleration, rotation, and pitch controls.

## Public variables
| Name         | Type  | Description                                                                 |
| ------------ | ----- | --------------------------------------------------------------------------- |
| Acceleration | float | The rate at which the spacecraft increases speed.                           |
| Deceleration | float | The rate at which the spacecraft decreases speed.                           |
| MaximumSpeed | float | The maximum forward speed the spacecraft can reach.                         |
| Agility      | float | The agility factor determining how quickly the spacecraft can rotate/pitch. |
| Speed        | float | The current forward speed of the spacecraft.                                |

## Public Functions
### Start
Called on component initialization. Retrieves the Rigidbody component attached to the spacecraft.

#### Params
None

### Update
Called once per frame. Currently empty but can be used for per-frame updates in the future.

#### Params
None

### Accelerate
Increases the spacecraft’s speed by Acceleration until it reaches MaximumSpeed. Updates the Rigidbody’s velocity.

#### Params
None

### Decelerate
Decreases the spacecraft’s speed by Deceleration until it reaches zero. Updates the Rigidbody’s velocity.

#### Params
None

### TurnRight
Rotates the spacecraft to the right around the Y-axis based on Agility. Updates the Rigidbody’s velocity.

#### Params
None

### TurnLeft
Rotates the spacecraft to the left around the Y-axis based on Agility. Updates the Rigidbody’s velocity.

#### Params
None

### PullUp
Tilts the spacecraft upward (rotation around the X-axis) based on Agility. Updates the Rigidbody’s velocity.

#### Params
None

### PullDown
Tilts the spacecraft downward (rotation around the X-axis) based on Agility. Updates the Rigidbody’s velocity.

#### Params
None