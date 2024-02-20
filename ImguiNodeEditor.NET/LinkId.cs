using System;

namespace AxNodeEditorNET
{
    public partial struct LinkId
    {        
        public static unsafe implicit operator LinkId(uint index)
        {
            return new LinkId() {
                _base_Details_SafePointerType_LinkId = new Details_SafePointerType_LinkId() {
                    _base_Details_SafeType_voidptr_LinkId = new Details_SafeType_voidptr_LinkId() {
                        m_Value = (void*)index
                    }
                }
            };
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
        
    }
}