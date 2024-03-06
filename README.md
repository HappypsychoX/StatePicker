 
 # StatePicker
 
The **StatePicker** control is a custom WPF ComboBox designed to allow users to select a state from the 
list of all US states. It provides a convenient dropdown interface for users to choose their desired state, making it ideal for applications that require state selection functionality. The control simplifies the process of handling state-related data and ensures a consistent user experience across different parts of your application.

## Usage
By default the *SelectedItem* property returns the abbreviation for the selected State. This can be changed by adding the following code to the control declaration in xaml: `SelectedValuePath = "Name"`. This will return the full name of the state as a string. 

Example: `<StatePicker:StatePicker x:Name="statePicker" Width="120" Height="25" HorizontalAlignment="Left" SelectedValuePath="Name"/>`

![Example ](https://github.com/HappypsychoX/StatePicker/blob/master/Example1.png)

## License
This project is distributed under the terms of the GNU General Public License (GPL) version 3. You are free to use, modify, and distribute this software in accordance with the GPL v3.

For more details, please refer to the full text of the license, which can be found at:

[GNU GPL v3](https://opensource.org/license/gpl-2-0)
