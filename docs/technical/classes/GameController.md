# GameController
At startup, the GameController should load the saved game settings and apply them to the scene.
This includes configuring graphics (e.g., anti-aliasing), sound volumes, and control bindings.
Its role is to ensure the game starts with the player’s preferred settings already applied.

## Public Variables
| Name       | Type   | Description                                     |
|------------|--------|-------------------------------------------------|
| mainCamera | Camera | Reference to the main camera used in the scene. |


## Public Functions

### Start
Called on component initialization. Loads saved game settings and configures the main camera’s anti-aliasing mode based on the selected option in GameSettings.

#### Params:
None