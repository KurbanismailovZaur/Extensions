using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class RuntimePlatformExtensions
    {
        public static bool IsEditor(this RuntimePlatform platform) => platform.EqualsToAny(RuntimePlatform.WindowsEditor, RuntimePlatform.OSXEditor, RuntimePlatform.LinuxEditor);

        public static bool IsStandalone(this RuntimePlatform platform) => platform.EqualsToAny(RuntimePlatform.WindowsPlayer, RuntimePlatform.OSXPlayer, RuntimePlatform.LinuxPlayer);

        public static bool IsMobile(this RuntimePlatform platform) => platform.EqualsToAny(RuntimePlatform.Android, RuntimePlatform.IPhonePlayer);
    }
}