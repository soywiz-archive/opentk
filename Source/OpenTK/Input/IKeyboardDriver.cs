#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines the interface for KeyboardDevice drivers.
    /// </summary>
    public interface IKeyboardDriver
    {
        /// <summary>
        /// Gets the list of available KeyboardDevices.
        /// </summary>
        [Obsolete("Use the OpenTK.Input.Keyboard class instead.")]
        IList<KeyboardDevice> Keyboard { get; }
    }
}
