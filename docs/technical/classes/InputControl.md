# InputControl

Behavior responsible for rebinding a control key through a UI input field.

## Public variables
| Name                       | Type                       | Description                                                             |
|----------------------------|----------------------------|-------------------------------------------------------------------------|
| mainMenuSettingsController | MainMenuSettingsController | Reference to the main menu settings controller used to rebind controls. |
| rebindAction               | ControlAction              | The specific control action that will be rebound by this input field.   |

## Public Functions
### Start
Called on component initialization. Retrieves the TMP_InputField component and disables the default arrow key navigation.

#### Params
None

### Update
Called once per frame. Checks if the input field is focused and waits for any key press. When a key is pressed:

- Calls RebindControl on mainMenuSettingsController with the assigned rebindAction and detected key.
- Updates the input field text to show the new key.
- Deactivates the input field to stop listening for input.

#### Params
None