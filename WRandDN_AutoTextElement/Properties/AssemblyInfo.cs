using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WRandDN_AutoTextElement")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("WRandDN_AutoTextElement")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e5b53ae1-ff2c-4db3-837a-207ef3ac6177")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: log4net.Config.RepositoryAttribute("Miner")]
#if DEBUG
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "miner.log4netD.config", Watch = true)]
#else
	[assembly: log4net.Config.XmlConfigurator(ConfigFile = "miner.log4net.config",Watch=true)]
#endif
