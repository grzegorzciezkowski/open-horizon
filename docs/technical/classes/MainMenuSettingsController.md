# MainMenuSettingsController
Behavior responsible for managing main menu settings, including graphics, audio, and control key bindings.

## Public variables

| Name                   | Type            | Description                                                                       |
|------------------------|-----------------|-----------------------------------------------------------------------------------|
| gameSettings           | GameSettings    | Reference to the loaded game settings used for updating and saving configuration. |
| antiAliasingInput      | TMP_Dropdown    | Dropdown UI element for selecting the anti-aliasing setting.                      |
| musicVolumeInput       | Slider          | Slider UI element for adjusting music volume.                                     |
| soundEffectVolumeInput | Slider          | Slider UI element for adjusting sound effects volume.                             |
| backgroundMusic        | AudioSource     | AudioSource used to play background music and adjust volume dynamically.          |
| accelerateInput        | TMP\_InputField | Input field displaying the key currently bound to the "Accelerate" action.        |
| decelerateInput        | TMP\_InputField | Input field displaying the key currently bound to the "Decelerate" action.        |
| pullUpInput            | TMP\_InputField | Input field displaying the key currently bound to the "Pull Up" action.           |
| pullDownInput          | TMP\_InputField | Input field displaying the key currently bound to the "Pull Down" action.         |
| turnLeft               | TMP\_InputField | Input field displaying the key currently bound to the "Turn Left" action.         |
| turnRight              | TMP\_InputField | Input field displaying the key currently bound to the "Turn Right" action.        |

## Public Functions
### Start
Called on component initialization. Loads the game settings and updates all UI elements (dropdowns, sliders, input fields) to reflect the current configuration.

#### Params
None

### SetAntiAliasing
Updates the anti-aliasing setting based on the selected dropdown option and saves the updated game settings.

#### Params
| Name         | Type | Description                                                  |
|--------------|------|--------------------------------------------------------------|
| optionIndex  | int  | Index of the selected anti-aliasing option in the dropdown.  |


### SetMusicVolume
Updates the music volume in the game settings, adjusts the backgroundMusic volume, and saves the updated settings.

#### Params
| Name  | Type  | Description                                   |
|-------|-------|-----------------------------------------------|
| value | float | New music volume (typically between 0 and 1). |


### SetSoundsEffectsVolume
Updates the sound effects volume in the game settings and saves the updated settings.

#### Params
| Name  | Type  | Description                                           |
|-------|-------|-------------------------------------------------------|
| value | float | New sound effects volume (typically between 0 and 1). |


### RebindControl
Rebinds a specified control action to a new key. Updates the game settings and saves the configuration.

#### Params
| Name         | Type          | Description                                                    |
|--------------|---------------|----------------------------------------------------------------|
| rebindAction | ControlAction | The action to rebind (e.g., Accelerate, Decelerate, TurnLeft). |
| key          | KeyCode       | The new key to bind to the specified action.                   |
