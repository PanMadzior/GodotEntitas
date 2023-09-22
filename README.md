# Godot with Entitas and Zenject
 ![godot-entitas-zenject](https://github.com/PanMadzior/GodotEntitas/assets/7965590/d96a6a53-b90c-44a9-baf5-78352db983d0)
 
Godot proof of concept test project with external C# plugins created mainly for Unity:
- [Entitas](https://github.com/sschmid/Entitas) - ECS framework (v1.14.1)
- [Zenject](https://github.com/modesttree/Zenject) - dependency injection framework (v9.1.0)

## Installation notes
### Entitas
- Download `Entitas.zip` and `Jenny.zip`.
- Create new folder `Entitas` inside your Godot project and extract `Entitas.zip` inside it.
- Extract `Jenny.zip` directly to to the root of your project.
- Make sure to create C# project and solution of your project. You can do it by creating a C# script inside Godot.
- In your `.csproj` add references to the following `.dll` files:
  - `Entitas\DesperateDevs\DesperateDevs.Caching.dll`
  - `Entitas\DesperateDevs\DesperateDevs.Extensions.dll`
  - `Entitas\DesperateDevs\DesperateDevs.Reflection.dll`
  - `Entitas\DesperateDevs\DesperateDevs.Serialization.dll`
  - `Entitas\DesperateDevs\DesperateDevs.Threading.dll`
  - `Entitas\Entitas\Entitas.dll`
  - `Entitas\Entitas\Entitas.CodeGeneration.Attributes.dll`
  - In Rider you can do it by right clicking on your project > `Add` > `Add reference...`.
- Run console command `dotnet Jenny\Jenny.Generator.Cli.dll` in the root folder to generate `Jenny.properties`.
- Edit `Jenny.properties`:
  - Add `Jenny` and `Entitas\Entitas` paths to the `Jenny.SearchPaths`.
  - Set `Jenny.Plugins.ProjectPath` with your `.csproj` file.
  - Set `Jenny.Plugins.TargetDirectory` to `Generated` or any other folder where you want your generated files to be placed.
  - Set `Entitas.CodeGeneration.Plugins.Contexts` to your needs.
- To generate code use command `dotnet Jenny\Jenny.Generator.Cli.dll gen`.
  - If you run into some generation errors try removing `Generated` folder first.
  - Use shell script `_JennyGenerateScript.sh` to do it automatically.
- If you run in some other issues, check out [godot-entitas-template](https://github.com/Guendeli/godot-entitas-template) repo by Guendeli.

### Zenject
- Download `Zenject-NonUnity@v9.1.0.zip`.
- Create folder `Zenject` and extract `.dll` files there.
- Add references to all the Zenject `.dll` files in your `csproj`.

## Project notes
Check out `Game/MainScene.tscn` and `Game/Sources` folder for the example setup. In `Game/Sources/Core` you can find ports of the Unity Zenject scripts and an Entitas controller.

## Caution
This setup worked on Windows and I haven't tried building the project yet.
