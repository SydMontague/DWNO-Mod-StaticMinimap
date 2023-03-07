# DWNO StaticMinimap Mod

This mod sets the minimap to always point north instead of following the camera rotation in the PC Version of Digimon World Next 0rder.

## Installation

1. Install [BepInEx](https://github.com/BepInEx/BepInEx) ([Tutorial by Yasha-jin](https://github.com/Yasha-jin/DWNOModdingGuides/blob/main/Guides/HowToInstallBepInExForDWNO.md))
2. Download the latest release from the [Releases Tab](https://github.com/SydMontague/DWNO-Mod-StaticMinimap/releases)
3. Copy the `StaticMinimap.dll` into the `plugins` folder of BepinEx
4. Start the game and enjoy :)

## Building

In order to build the plugin yourself you have to

1. Install BepInEx (see instructions above)
2. clone the project
3. copy the `interop` folder into the project
4. run `dotnet build -c Release` inside the folder (or open the .csproj with Visual Studio)

The `StaticMinimap.dll` should now be in `bin/Release/net6.0`.

You'll have to have .Net 6.0 or higher installed.

## Contact
* Discord: SydMontague#8056, or in either the [Digimon Modding Community](https://discord.gg/cb5AuxU6su) or [Digimon Discord Community](https://discord.gg/0VODO3ww0zghqOCO)
* directly on GitHub
* E-Mail: sydmontague@web.de
* Reddit: [/u/Sydmontague](https://reddit.com/u/sydmontague)