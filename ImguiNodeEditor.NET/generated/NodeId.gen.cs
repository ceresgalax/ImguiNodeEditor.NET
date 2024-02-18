using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct NodeId
    {
        public Details_SafePointerType_NodeId _base_Details_SafePointerType_NodeId;
    }
    public unsafe partial struct NodeIdPtr
    {
        public NodeId* NativePtr { get; }
        public NodeIdPtr(NodeId* nativePtr) => NativePtr = nativePtr;
        public NodeIdPtr(IntPtr nativePtr) => NativePtr = (NodeId*)nativePtr;
        public static implicit operator NodeIdPtr(NodeId* nativePtr) => new NodeIdPtr(nativePtr);
        public static implicit operator NodeId* (NodeIdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator NodeIdPtr(IntPtr nativePtr) => new NodeIdPtr(nativePtr);
        public ref Details_SafePointerType_NodeId _base_Details_SafePointerType_NodeId => ref Unsafe.AsRef<Details_SafePointerType_NodeId>(&NativePtr->_base_Details_SafePointerType_NodeId);
    }
}
