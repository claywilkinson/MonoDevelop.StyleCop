﻿//-----------------------------------------------------------------------
// <copyright file="BaseAnalysisHandler.cs">
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
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using MonoDevelop.Components.Commands;

  /// <summary>
  /// This class will manage the general StyleCop functionality.
  /// It doesn't handle the collecting of files which should be scanned.
  /// </summary>
  internal abstract class BaseAnalysisHandler : CommandHandler
  {
  }
}