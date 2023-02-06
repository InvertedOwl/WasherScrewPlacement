﻿using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(WasherScrewPlacement.BuildInfo.Description)]
[assembly: AssemblyDescription(WasherScrewPlacement.BuildInfo.Description)]
[assembly: AssemblyCompany(WasherScrewPlacement.BuildInfo.Company)]
[assembly: AssemblyProduct(WasherScrewPlacement.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + WasherScrewPlacement.BuildInfo.Author)]
[assembly: AssemblyTrademark(WasherScrewPlacement.BuildInfo.Company)]
[assembly: AssemblyVersion(WasherScrewPlacement.BuildInfo.Version)]
[assembly: AssemblyFileVersion(WasherScrewPlacement.BuildInfo.Version)]
[assembly: MelonInfo(typeof(WasherScrewPlacement.WasherScrewPlacement), WasherScrewPlacement.BuildInfo.Name, WasherScrewPlacement.BuildInfo.Version, WasherScrewPlacement.BuildInfo.Author, WasherScrewPlacement.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]