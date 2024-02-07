using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId
    {
        public unsigned long long m_Value;
    }
    public unsafe partial struct axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr
    {
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* NativePtr { get; }
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId*)nativePtr;
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* nativePtr) => new axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr(nativePtr);
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr(IntPtr nativePtr) => new axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinIdPtr(nativePtr);
        public ref unsigned long long m_Value => ref Unsafe.AsRef<unsigned long long>(&NativePtr->m_Value);
    }
}
