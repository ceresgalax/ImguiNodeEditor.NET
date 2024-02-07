using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditor_Config
    {
        public byte* SettingsFile;
        public IntPtr BeginSaveSession;
        public IntPtr EndSaveSession;
        public IntPtr SaveSettings;
        public IntPtr LoadSettings;
        public IntPtr SaveNodeSettings;
        public IntPtr LoadNodeSettings;
        public void* UserPointer;
        public ImVector CustomZoomLevels;
        public axNodeEditor_CanvasSizeMode CanvasSizeMode;
        public int DragButtonIndex;
        public int SelectButtonIndex;
        public int NavigateButtonIndex;
        public int ContextMenuButtonIndex;
        public byte EnableSmoothZoom;
        public float SmoothZoomPower;
    }
    public unsafe partial struct axNodeEditor_ConfigPtr
    {
        public axNodeEditor_Config* NativePtr { get; }
        public axNodeEditor_ConfigPtr(axNodeEditor_Config* nativePtr) => NativePtr = nativePtr;
        public axNodeEditor_ConfigPtr(IntPtr nativePtr) => NativePtr = (axNodeEditor_Config*)nativePtr;
        public static implicit operator axNodeEditor_ConfigPtr(axNodeEditor_Config* nativePtr) => new axNodeEditor_ConfigPtr(nativePtr);
        public static implicit operator axNodeEditor_Config* (axNodeEditor_ConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditor_ConfigPtr(IntPtr nativePtr) => new axNodeEditor_ConfigPtr(nativePtr);
        public IntPtr SettingsFile { get => (IntPtr)NativePtr->SettingsFile; set => NativePtr->SettingsFile = (byte*)value; }
        public ref IntPtr BeginSaveSession => ref Unsafe.AsRef<IntPtr>(&NativePtr->BeginSaveSession);
        public ref IntPtr EndSaveSession => ref Unsafe.AsRef<IntPtr>(&NativePtr->EndSaveSession);
        public ref IntPtr SaveSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->SaveSettings);
        public ref IntPtr LoadSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->LoadSettings);
        public ref IntPtr SaveNodeSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->SaveNodeSettings);
        public ref IntPtr LoadNodeSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->LoadNodeSettings);
        public IntPtr UserPointer { get => (IntPtr)NativePtr->UserPointer; set => NativePtr->UserPointer = (void*)value; }
        public ImVector<> CustomZoomLevels => new ImVector<>(NativePtr->CustomZoomLevels);
        public ref axNodeEditor_CanvasSizeMode CanvasSizeMode => ref Unsafe.AsRef<axNodeEditor_CanvasSizeMode>(&NativePtr->CanvasSizeMode);
        public ref int DragButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->DragButtonIndex);
        public ref int SelectButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->SelectButtonIndex);
        public ref int NavigateButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->NavigateButtonIndex);
        public ref int ContextMenuButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->ContextMenuButtonIndex);
        public ref bool EnableSmoothZoom => ref Unsafe.AsRef<bool>(&NativePtr->EnableSmoothZoom);
        public ref float SmoothZoomPower => ref Unsafe.AsRef<float>(&NativePtr->SmoothZoomPower);
    }
}
