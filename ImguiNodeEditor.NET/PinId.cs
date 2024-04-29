using System;

namespace AxNodeEditorNET
{
    public partial struct PinId
    {
        public static unsafe explicit operator PinId(int index)
        {
            return new PinId() {
                _base_Details_SafePointerType_PinId = new Details_SafePointerType_PinId() {
                    _base_Details_SafeType_voidptr_PinId = new Details_SafeType_voidptr_PinId() {
                        m_Value = (void*)index
                    }
                }
            };
        }
        
        public static unsafe explicit operator PinId(uint index)
        {
            return new PinId() {
                _base_Details_SafePointerType_PinId = new Details_SafePointerType_PinId() {
                    _base_Details_SafeType_voidptr_PinId = new Details_SafeType_voidptr_PinId() {
                        m_Value = (void*)index
                    }
                }
            };
        }
        
        public static unsafe explicit operator PinId(ulong index)
        {
            return new PinId() {
                _base_Details_SafePointerType_PinId = new Details_SafePointerType_PinId() {
                    _base_Details_SafeType_voidptr_PinId = new Details_SafeType_voidptr_PinId() {
                        m_Value = (void*)index
                    }
                }
            };
        }

        public static unsafe explicit operator PinId(IntPtr index)
        {
            return new PinId() {
                _base_Details_SafePointerType_PinId = new Details_SafePointerType_PinId() {
                    _base_Details_SafeType_voidptr_PinId = new Details_SafeType_voidptr_PinId() {
                        m_Value = (void*)index
                    }
                }
            };
        }
        
        public static unsafe explicit operator IntPtr(PinId id)
        {
            return (IntPtr)id._base_Details_SafePointerType_PinId._base_Details_SafeType_voidptr_PinId.m_Value;
        }

        public static unsafe PinId operator ++(in PinId id)
        {
            IntPtr ptr = (IntPtr)id._base_Details_SafePointerType_PinId._base_Details_SafeType_voidptr_PinId.m_Value;
            return new PinId() {
                _base_Details_SafePointerType_PinId = new Details_SafePointerType_PinId() {
                    _base_Details_SafeType_voidptr_PinId = new Details_SafeType_voidptr_PinId() {
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