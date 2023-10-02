# TestTask

### lib.dll

## Instructions for use

# Add plugin
To get a plugin, just create a class that implements the IPlugin interface

# Get plugin
To get a plugin, create an instance of the Plugins class and call the GetPlugin method, with the name of the plugin as its arguments. This could be nameof(PlaginName) or just "PlaginName"

# Implementation

The library only works with Windows and .NET Framework 1.1 and higher.

The IPlugin interface and the abstract class PluginBase implement business logic and are needed for conveniently adding new plugins. The Plugins class is responsible for adding plugins, which is a factory that uses reflection to create plugin instances.

