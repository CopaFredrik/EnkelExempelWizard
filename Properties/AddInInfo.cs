using Mono.Addins;

// Declares that this assembly is an add-in
[assembly: Addin("EnkelExempelWizard", "1.0")]

// Declares that this add-in depends on the scada v1.0 add-in root
[assembly: AddinDependency("::scada", "1.0")]

[assembly: AddinName("EnkelExempelWizard")]
[assembly: AddinDescription("Ett enkelt exempel på en Wizard för zenon Editor.")]