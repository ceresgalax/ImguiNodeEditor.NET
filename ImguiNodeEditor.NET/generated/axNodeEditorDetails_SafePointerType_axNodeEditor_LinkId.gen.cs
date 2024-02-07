using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId
    {
    }
    public unsafe partial struct axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr
    {
        public axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* NativePtr { get; }
        public axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr(axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId*)nativePtr;
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr(axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* nativePtr) => new axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr(nativePtr);
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* (axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr(IntPtr nativePtr) => new axNodeEditorDetails_SafePointerType_axNodeEditor_LinkIdPtr(nativePtr);
    }
}
