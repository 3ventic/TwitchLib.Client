﻿using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events.Client
{
    /// <inheritdoc />
    /// <summary></summary>
    public class OnWhisperReceivedArgs : EventArgs
    {
        /// <summary></summary>
        public WhisperMessage WhisperMessage;
    }
}
