# GameSettings
Data container class responsible for storing and managing game configuration, including graphics, sounds, and control settings. Provides static methods for saving and loading settings to/from JSON files.

## Public variables
| Name     | Type                                      | Description                                    |
|----------|-------------------------------------------|------------------------------------------------|
| graphics | [GraphicsSettings](./GraphicsSettings.md) | Stores all graphic-related configuration.      |
| sounds   | [SoundsSettings](./SoundsSettings.md)     | Stores all sound-related configuration.        |
| controls | [ControlsSettings](./ControlsSettings.md) | Stores all control key bindings configuration. |

## Public Functions
### Save (static)
Serializes the provided GameSettings instance into JSON format and writes it to the specified file path.

#### Params
| Name     | Type         | Description                                         |
|----------|--------------|-----------------------------------------------------|
| data     | GameSettings | The settings instance to be saved.                  |
| filePath | string       | Path to the file where the settings will be stored. |


### Load (static)
Loads game settings from a JSON file at the specified file path. If the file does not exist, returns a new GameSettings instance with default values.

#### Params
| Name     | Type   | Description                               |
|----------|--------|-------------------------------------------|
| filePath | string | Path to the file from which to load data. |

#### Returns
| Type         | Description                                            |
|--------------|--------------------------------------------------------|
| GameSettings | The loaded game settings or a new instance if missing. |
