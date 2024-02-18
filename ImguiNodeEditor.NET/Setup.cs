using System;
using System.Numerics;
using System.Runtime.InteropServices;
using AxNodeEditorNET;
using ImGuiNET;

namespace ImguiNodeEditorNET
{
    public static class Setup
    {
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr axNodeEditor_GetCurrentContext();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetCurrentContext(IntPtr ptr);
    }
}