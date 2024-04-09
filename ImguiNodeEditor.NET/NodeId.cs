using System;

namespace AxNodeEditorNET
{
    public partial struct NodeId
    {
        public bool Equals(NodeId other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            return obj is NodeId other && Equals(other);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)this).GetHashCode();
        }

        public static unsafe explicit operator NodeId(uint index)
        {
            return new NodeId() {
                _base_Details_SafePointerType_NodeId = new Details_SafePointerType_NodeId() {
                    _base_Details_SafeType_voidptr_NodeId = new Details_SafeType_voidptr_NodeId() {
                        m_Value = (void*)index
                    }
                }
            };
        }

        public static unsafe implicit operator NodeId(IntPtr index)
        {
            return new NodeId() {
                _base_Details_SafePointerType_NodeId = new Details_SafePointerType_NodeId() {
                    _base_Details_SafeType_voidptr_NodeId = new Details_SafeType_voidptr_NodeId() {
                        m_Value = (void*)index
                    }
                }
            };
        }

        public static unsafe explicit operator IntPtr(NodeId id)
        {
            return (IntPtr)id._base_Details_SafePointerType_NodeId._base_Details_SafeType_voidptr_NodeId.m_Value;
        }

        public static unsafe NodeId operator ++(in NodeId id)
        {
            IntPtr ptr = (IntPtr)id._base_Details_SafePointerType_NodeId._base_Details_SafeType_voidptr_NodeId.m_Value;
            return new NodeId() {
                _base_Details_SafePointerType_NodeId = new Details_SafePointerType_NodeId() {
                    _base_Details_SafeType_voidptr_NodeId = new Details_SafeType_voidptr_NodeId() {
                        m_Value = (void*)(ptr + 1)
                    }
                }
            };
        }

        public static bool operator ==(in NodeId a, in NodeId b)
        {
            return (IntPtr)a == (IntPtr)b;
        }

        public static bool operator !=(NodeId a, NodeId b)
        {
            return !(a == b);
        }
    }
}