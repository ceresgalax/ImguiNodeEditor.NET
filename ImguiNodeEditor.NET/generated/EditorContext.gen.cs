using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct EditorContext
    {
    }
    public unsafe partial struct EditorContextPtr
    {
        public EditorContext* NativePtr { get; }
        public EditorContextPtr(EditorContext* nativePtr) => NativePtr = nativePtr;
        public EditorContextPtr(IntPtr nativePtr) => NativePtr = (EditorContext*)nativePtr;
        public static implicit operator EditorContextPtr(EditorContext* nativePtr) => new EditorContextPtr(nativePtr);
        public static implicit operator EditorContext* (EditorContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator EditorContextPtr(IntPtr nativePtr) => new EditorContextPtr(nativePtr);
    }
}
