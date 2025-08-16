# SpacecraftFollower

Behavior responsible for following the spacecraft’s position and rotation.

## Public variables
| Name       | Type       | Description                                                  |
| ---------- | ---------- | ------------------------------------------------------------ |
| spacecraft | GameObject | The in-game spacecraft object to be followed by this object. |

## Public Functions
### Start
Called on component initialization. Currently does not contain any logic.

#### Params
None

### Update
Called once per frame. Updates the follower’s position and rotation to match the assigned spacecraft.

#### Params
None