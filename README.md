# Why does this exist

There seem to be an issue with using `ValueCollection` in [`ListBox`](/ListBox-Issue/Views/MainView.axaml?L20) controls of Avalonia.

produces the following error:

```
.nuget\packages\avalonia\11.0.0-preview2\buildTransitive\AvaloniaBuildTasks.targets(98,5): error MSB4018: 

Unexpected failure of task "CompileAvaloniaXamlTask". 

.nuget\packages\avalonia\11.0.0-preview2\buildTransitive\AvaloniaBuildTasks.targets(98,5): error MSB4018: 

System.ArgumentException: Member 'System.Collections.Generic.Dictionary`2/ValueCollection' is declared in another module and needs to be imported 
```