﻿//-----------------------------------------------------------------------
// <copyright file="StartupHandler.cs">
//   APL 2.0
// </copyright>
// <license>
//   Copyright 2012 Alexander Jochum
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </license>
//-----------------------------------------------------------------------
namespace MonoDevelop.StyleCop
{
  using MonoDevelop.Components.Commands;

  /// <summary>
  /// This class get's initialized on MonoDevelop startup and setup all necessary stuff that has to be loaded only once.
  /// </summary>
  internal sealed class StartupHandler : CommandHandler
  {
    /// <summary>
    /// This method get's called on MonoDevelop startup and will setup all necessary stuff that has to be loaded only once.
    /// </summary>
    protected override void Run()
    {
      base.Run();

      // Call the initialize function of ProjectUtilities so it'll call it's static constructor.
      ProjectUtilities.Initialize();
      System.Diagnostics.Debug.WriteLine("MonoDevelop.StyleCop Addin loaded..");
    }
  }
}