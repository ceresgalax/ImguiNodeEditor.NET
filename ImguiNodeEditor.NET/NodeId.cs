using System;

namespace AxNodeEditorNET
{
    public partial struct NodeId
    {
        public static unsafe implicit operator NodeId(uint index)
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
    }
}