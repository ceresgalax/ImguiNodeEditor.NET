using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId
    {
        public unsigned long long m_Value;
    }
    public unsafe partial struct axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr
    {
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* NativePtr { get; }
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId*)nativePtr;
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* nativePtr) => new axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr(nativePtr);
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr(IntPtr nativePtr) => new axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeIdPtr(nativePtr);
        public ref unsigned long long m_Value => ref Unsafe.AsRef<unsigned long long>(&NativePtr->m_Value);
    }
}
