using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Config
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
        public CanvasSizeMode CanvasSizeMode;
        public int DragButtonIndex;
        public int SelectButtonIndex;
        public int NavigateButtonIndex;
        public int ContextMenuButtonIndex;
        public byte EnableSmoothZoom;
        public float SmoothZoomPower;
    }
    public unsafe partial struct ConfigPtr
    {
        public Config* NativePtr { get; }
        public ConfigPtr(Config* nativePtr) => NativePtr = nativePtr;
        public ConfigPtr(IntPtr nativePtr) => NativePtr = (Config*)nativePtr;
        public static implicit operator ConfigPtr(Config* nativePtr) => new ConfigPtr(nativePtr);
        public static implicit operator Config* (ConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ConfigPtr(IntPtr nativePtr) => new ConfigPtr(nativePtr);
        public IntPtr SettingsFile { get => (IntPtr)NativePtr->SettingsFile; set => NativePtr->SettingsFile = (byte*)value; }
        public ref IntPtr BeginSaveSession => ref Unsafe.AsRef<IntPtr>(&NativePtr->BeginSaveSession);
        public ref IntPtr EndSaveSession => ref Unsafe.AsRef<IntPtr>(&NativePtr->EndSaveSession);
        public ref IntPtr SaveSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->SaveSettings);
        public ref IntPtr LoadSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->LoadSettings);
        public ref IntPtr SaveNodeSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->SaveNodeSettings);
        public ref IntPtr LoadNodeSettings => ref Unsafe.AsRef<IntPtr>(&NativePtr->LoadNodeSettings);
        public IntPtr UserPointer { get => (IntPtr)NativePtr->UserPointer; set => NativePtr->UserPointer = (void*)value; }
        public ImVector<float> CustomZoomLevels => new ImVector<float>(NativePtr->CustomZoomLevels);
        public ref CanvasSizeMode CanvasSizeMode => ref Unsafe.AsRef<CanvasSizeMode>(&NativePtr->CanvasSizeMode);
        public ref int DragButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->DragButtonIndex);
        public ref int SelectButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->SelectButtonIndex);
        public ref int NavigateButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->NavigateButtonIndex);
        public ref int ContextMenuButtonIndex => ref Unsafe.AsRef<int>(&NativePtr->ContextMenuButtonIndex);
        public ref bool EnableSmoothZoom => ref Unsafe.AsRef<bool>(&NativePtr->EnableSmoothZoom);
        public ref float SmoothZoomPower => ref Unsafe.AsRef<float>(&NativePtr->SmoothZoomPower);
    }
}
