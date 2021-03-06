﻿using System;

namespace Bag_Tracer.ViewModel
{
    /// <summary>
    /// Helper class for global methods
    /// </summary>
    internal static class StaticGlobals
    {
        #region Constructors


        #endregion

        #region Members

        private const string APP_NAME = "Bag_Tracer";

        #endregion

        #region Methods

        /// <summary>
        /// Returns the directory containing application configuration files
        /// </summary>
        /// <returns>The full path of the application directory</returns>
        internal static string GetAppDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + $"\\{APP_NAME}\\";
        }

        /// <summary>
        /// Returns the fully qualified Database Connection string
        /// </summary>
        /// <returns>The connection string in the format "Data Source=[ConnecitonString]"</returns>
        internal static string GetConnectionString()
        {
            return "Data Source=" + GetAppDirectory() + $"{APP_NAME}.db";
        }

        #endregion
    }
}
