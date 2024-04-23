using System;

namespace AxNodeEditorNET
{
    public partial struct LinkId
    {        
        public static unsafe explicit operator LinkId(uint index)
        {
            return new LinkId() {
                _base_Details_SafePointerType_LinkId = new Details_SafePointerType_LinkId() {
                    _base_Details_SafeType_voidptr_LinkId = new Details_SafeType_voidptr_LinkId() {
                        m_Value = (void*)index
                    }
                }
            };
        }
        
        public static unsafe implicit operator LinkId(IntPtr index)
        {
            return new LinkId() {
                _base_Details_SafePointerType_LinkId = new Details_SafePointerType_LinkId() {
                    _base_Details_SafeType_voidptr_LinkId = new Details_SafeType_voidptr_LinkId() {
                        m_Value = (void*)index
                    }
                }
            };
        }

        public static unsafe explicit operator IntPtr(LinkId id)
        {
            return (IntPtr)id._base_Details_SafePointerType_LinkId._base_Details_SafeType_voidptr_LinkId.m_Value;
        }

        public static unsafe LinkId operator ++(in LinkId id)
        {
            IntPtr ptr = (IntPtr)id._base_Details_SafePointerType_LinkId._base_Details_SafeType_voidptr_LinkId.m_Value;
            return new LinkId() {
                _base_Details_SafePointerType_LinkId = new Details_SafePointerType_LinkId() {
                    _base_Details_SafeType_voidptr_LinkId = new Details_SafeType_voidptr_LinkId() {
                        m_Value = (void*)(ptr + 1)
                    }
                }
            };
        }

        public override string ToString()
        {
            return ((IntPtr)this).ToString();
        }
    }
}