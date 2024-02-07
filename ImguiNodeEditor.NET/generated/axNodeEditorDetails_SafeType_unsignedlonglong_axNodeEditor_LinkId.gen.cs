using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId
    {
        public unsigned long long m_Value;
    }
    public unsafe partial struct axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr
    {
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* NativePtr { get; }
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* nativePtr) => NativePtr = nativePtr;
        public axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr(IntPtr nativePtr) => NativePtr = (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId*)nativePtr;
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* nativePtr) => new axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr(nativePtr);
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr(IntPtr nativePtr) => new axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkIdPtr(nativePtr);
        public ref unsigned long long m_Value => ref Unsafe.AsRef<unsigned long long>(&NativePtr->m_Value);
    }
}
