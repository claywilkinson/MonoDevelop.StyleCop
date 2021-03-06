﻿//-----------------------------------------------------------------------
// <copyright file="StaticStringResources.cs">
//   APL 2.0
// </copyright>
// <license>
//   Copyright 2013-2014 Alexander Jochum
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
  /// <summary>
  /// This class initializes all string resources which are used in multiple places.
  /// </summary>
  public static class StaticStringResources
  {
    #region Constructors

    /// <summary>
    /// Initializes static members of the <see cref="StaticStringResources"/> class.
    /// </summary>
    static StaticStringResources()
    {
      ProjectSettingsFileNotLoadedOrCreated = "The settings file for the project could not be loaded or created: {0}";
      StyleCopCancelText = "Cancel StyleCop";
      StyleCopFullAnalysisText = "Run StyleCop (Rescan All)";
      StyleCopRunText = "Run StyleCop";
      Title = "StyleCop";
    }

    #endregion Constructors

    #region Public properties

    /// <summary>
    /// Gets the ProjectSettingsFileNotLoadedOrCreated message.
    /// </summary>
    public static string ProjectSettingsFileNotLoadedOrCreated
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the text of cancel StyleCop context menu entry.
    /// </summary>
    public static string StyleCopCancelText
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the text of full StyleCop analysis context menu entry.
    /// </summary>
    public static string StyleCopFullAnalysisText
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the text of default StyleCop analysis context menu entry.
    /// </summary>
    public static string StyleCopRunText
    {
      get;
      private set;
    }

    /// <summary>
    /// Gets the Title text.
    /// </summary>
    public static string Title
    {
      get;
      private set;
    }

    #endregion Public properties
  }
}