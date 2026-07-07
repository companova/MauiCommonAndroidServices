// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Reliability", "CA2007:Consider calling ConfigureAwait on the awaited task", Justification = "This is MAUI UI. Default behavior that would force the UI thread context is what we need.")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "No need to catch specific exceptions in this context." )]
[assembly: SuppressMessage("Performance", "CA1805:Do not initialize unnecessarily", Justification = "Better be explicit with the initialization.")]