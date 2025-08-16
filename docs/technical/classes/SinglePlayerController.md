# SinglePlayerController

Behavior responsible for controlling a single spacecraft by the player.

## Public variables

### GameObject Vessel
| Name   | Type       | Description                                                              |
| ------ | ---------- | ------------------------------------------------------------------------ |
| Vessel | GameObject | The in-game object representing the spacecraft controlled by the player. |

## Public Functions
### Start

Called on component initialization. Retrieves the Spacecraft component from the assigned Vessel object.

#### Params

None

### Update

Called once per frame. Reads keyboard input and controls the spacecraft:

- **Up Arrow** – accelerate
- **Down Arrow** – decelerate
- **A** – turn left
- **D** – turn right
- **S** – pull up
- **W** – pull down

#### Params

None