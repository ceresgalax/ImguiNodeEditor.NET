using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public static unsafe partial class AxNodeEditor
    {
        public static bool AcceptCopy()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptCopy();
            return ret != 0;
        }
        public static bool AcceptCreateNode()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptCreateNode();
            return ret != 0;
        }
        public static bool AcceptCut()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptCut();
            return ret != 0;
        }
        public static bool AcceptDeletedItem(bool deleteDependencies)
        {
            byte native_deleteDependencies = deleteDependencies ? (byte)1 : (byte)0;
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptDeletedItem(native_deleteDependencies);
            return ret != 0;
        }
        public static bool AcceptDuplicate()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptDuplicate();
            return ret != 0;
        }
        public static bool AcceptNewItem()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptNewItem();
            return ret != 0;
        }
        public static bool AcceptNewItem(ref Vector4 color, float thickness)
        {
            fixed (Vector4* native_color = &color)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_AcceptNewItem(native_color, thickness);
                return ret != 0;
            }
        }
        public static bool AcceptPaste()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AcceptPaste();
            return ret != 0;
        }
        public static bool AreShortcutsEnabled()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_AreShortcutsEnabled();
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void Begin(ReadOnlySpan<char> id, ref Vector2 size)
#else
        public static void Begin(string id, ref Vector2 size)
#endif
        {
            byte* native_id;
            int id_byteCount = 0;
            if (id != null)
            {
                id_byteCount = Encoding.UTF8.GetByteCount(id);
                if (id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_id = Util.Allocate(id_byteCount + 1);
                }
                else
                {
                    byte* native_id_stackBytes = stackalloc byte[id_byteCount + 1];
                    native_id = native_id_stackBytes;
                }
                int native_id_offset = Util.GetUtf8(id, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            else { native_id = null; }
            fixed (Vector2* native_size = &size)
            {
                AxNodeEditorNative.axNodeEditor_Begin(native_id, native_size);
                if (id_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_id);
                }
            }
        }
        public static bool BeginCreate(ref Vector4 color, float thickness)
        {
            fixed (Vector4* native_color = &color)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_BeginCreate(native_color, thickness);
                return ret != 0;
            }
        }
        public static bool BeginDelete()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_BeginDelete();
            return ret != 0;
        }
        public static bool BeginGroupHint(axNodeEditor_NodeId nodeId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_BeginGroupHint(nodeId);
            return ret != 0;
        }
        public static void BeginNode(axNodeEditor_NodeId id)
        {
            AxNodeEditorNative.axNodeEditor_BeginNode(id);
        }
        public static void BeginPin(axNodeEditor_PinId id, axNodeEditor_PinKind kind)
        {
            AxNodeEditorNative.axNodeEditor_BeginPin(id, kind);
        }
        public static bool BeginShortcut()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_BeginShortcut();
            return ret != 0;
        }
        public static int BreakLinks(axNodeEditor_NodeId nodeId)
        {
            int ret = AxNodeEditorNative.axNodeEditor_BreakLinks(nodeId);
            return ret;
        }
        public static int BreakLinks(axNodeEditor_PinId pinId)
        {
            int ret = AxNodeEditorNative.axNodeEditor_BreakLinks(pinId);
            return ret;
        }
        public static Vector2 CanvasToScreen(ref Vector2 pos)
        {
            fixed (Vector2* native_pos = &pos)
            {
                Vector2 ret = AxNodeEditorNative.axNodeEditor_CanvasToScreen(native_pos);
                return ret;
            }
        }
        public static void CenterNodeOnScreen(axNodeEditor_NodeId nodeId)
        {
            AxNodeEditorNative.axNodeEditor_CenterNodeOnScreen(nodeId);
        }
        public static void ClearSelection()
        {
            AxNodeEditorNative.axNodeEditor_ClearSelection();
        }
        public static axNodeEditor_EditorContext* CreateEditor(ref axNodeEditor_Config config)
        {
            fixed (axNodeEditor_Config* native_config = &config)
            {
                axNodeEditor_EditorContext* ret = AxNodeEditorNative.axNodeEditor_CreateEditor(native_config);
                return ret;
            }
        }
        public static bool DeleteLink(axNodeEditor_LinkId linkId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_DeleteLink(linkId);
            return ret != 0;
        }
        public static bool DeleteNode(axNodeEditor_NodeId nodeId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_DeleteNode(nodeId);
            return ret != 0;
        }
        public static void DeselectLink(axNodeEditor_LinkId linkId)
        {
            AxNodeEditorNative.axNodeEditor_DeselectLink(linkId);
        }
        public static void DeselectNode(axNodeEditor_NodeId nodeId)
        {
            AxNodeEditorNative.axNodeEditor_DeselectNode(nodeId);
        }
        public static void DestroyEditor(ref axNodeEditor_EditorContext ctx)
        {
            fixed (axNodeEditor_EditorContext* native_ctx = &ctx)
            {
                AxNodeEditorNative.axNodeEditor_DestroyEditor(native_ctx);
            }
        }
        public static void EnableShortcuts(bool enable)
        {
            byte native_enable = enable ? (byte)1 : (byte)0;
            AxNodeEditorNative.axNodeEditor_EnableShortcuts(native_enable);
        }
        public static void End()
        {
            AxNodeEditorNative.axNodeEditor_End();
        }
        public static void EndCreate()
        {
            AxNodeEditorNative.axNodeEditor_EndCreate();
        }
        public static void EndDelete()
        {
            AxNodeEditorNative.axNodeEditor_EndDelete();
        }
        public static void EndGroupHint()
        {
            AxNodeEditorNative.axNodeEditor_EndGroupHint();
        }
        public static void EndNode()
        {
            AxNodeEditorNative.axNodeEditor_EndNode();
        }
        public static void EndPin()
        {
            AxNodeEditorNative.axNodeEditor_EndPin();
        }
        public static void EndShortcut()
        {
            AxNodeEditorNative.axNodeEditor_EndShortcut();
        }
        public static void Flow(axNodeEditor_LinkId linkId, axNodeEditor_FlowDirection direction)
        {
            AxNodeEditorNative.axNodeEditor_Flow(linkId, direction);
        }
        public static int GetActionContextLinks(ref axNodeEditor_LinkId links, int size)
        {
            fixed (axNodeEditor_LinkId* native_links = &links)
            {
                int ret = AxNodeEditorNative.axNodeEditor_GetActionContextLinks(native_links, size);
                return ret;
            }
        }
        public static int GetActionContextNodes(ref axNodeEditor_NodeId nodes, int size)
        {
            fixed (axNodeEditor_NodeId* native_nodes = &nodes)
            {
                int ret = AxNodeEditorNative.axNodeEditor_GetActionContextNodes(native_nodes, size);
                return ret;
            }
        }
        public static int GetActionContextSize()
        {
            int ret = AxNodeEditorNative.axNodeEditor_GetActionContextSize();
            return ret;
        }
        public static int GetBackgroundClickButtonIndex()
        {
            int ret = AxNodeEditorNative.axNodeEditor_GetBackgroundClickButtonIndex();
            return ret;
        }
        public static int GetBackgroundDoubleClickButtonIndex()
        {
            int ret = AxNodeEditorNative.axNodeEditor_GetBackgroundDoubleClickButtonIndex();
            return ret;
        }
        public static axNodeEditor_Config* GetConfig(ref axNodeEditor_EditorContext ctx)
        {
            fixed (axNodeEditor_EditorContext* native_ctx = &ctx)
            {
                axNodeEditor_Config* ret = AxNodeEditorNative.axNodeEditor_GetConfig(native_ctx);
                return ret;
            }
        }
        public static axNodeEditor_EditorContext* GetCurrentEditor()
        {
            axNodeEditor_EditorContext* ret = AxNodeEditorNative.axNodeEditor_GetCurrentEditor();
            return ret;
        }
        public static float GetCurrentZoom()
        {
            float ret = AxNodeEditorNative.axNodeEditor_GetCurrentZoom();
            return ret;
        }
        public static axNodeEditor_LinkId GetDoubleClickedLink()
        {
            axNodeEditor_LinkId ret = AxNodeEditorNative.axNodeEditor_GetDoubleClickedLink();
            return ret;
        }
        public static axNodeEditor_NodeId GetDoubleClickedNode()
        {
            axNodeEditor_NodeId ret = AxNodeEditorNative.axNodeEditor_GetDoubleClickedNode();
            return ret;
        }
        public static axNodeEditor_PinId GetDoubleClickedPin()
        {
            axNodeEditor_PinId ret = AxNodeEditorNative.axNodeEditor_GetDoubleClickedPin();
            return ret;
        }
        public static Vector2 GetGroupMax()
        {
            Vector2 ret = AxNodeEditorNative.axNodeEditor_GetGroupMax();
            return ret;
        }
        public static Vector2 GetGroupMin()
        {
            Vector2 ret = AxNodeEditorNative.axNodeEditor_GetGroupMin();
            return ret;
        }
        public static ImDrawListPtr GetHintBackgroundDrawList()
        {
            ImDrawList* ret = AxNodeEditorNative.axNodeEditor_GetHintBackgroundDrawList();
            return new ImDrawListPtr(ret);
        }
        public static ImDrawListPtr GetHintForegroundDrawList()
        {
            ImDrawList* ret = AxNodeEditorNative.axNodeEditor_GetHintForegroundDrawList();
            return new ImDrawListPtr(ret);
        }
        public static axNodeEditor_LinkId GetHoveredLink()
        {
            axNodeEditor_LinkId ret = AxNodeEditorNative.axNodeEditor_GetHoveredLink();
            return ret;
        }
        public static axNodeEditor_NodeId GetHoveredNode()
        {
            axNodeEditor_NodeId ret = AxNodeEditorNative.axNodeEditor_GetHoveredNode();
            return ret;
        }
        public static axNodeEditor_PinId GetHoveredPin()
        {
            axNodeEditor_PinId ret = AxNodeEditorNative.axNodeEditor_GetHoveredPin();
            return ret;
        }
        public static bool GetLinkPins(axNodeEditor_LinkId linkId, ref axNodeEditor_PinId startPinId, ref axNodeEditor_PinId endPinId)
        {
            fixed (axNodeEditor_PinId* native_startPinId = &startPinId)
            {
                fixed (axNodeEditor_PinId* native_endPinId = &endPinId)
                {
                    byte ret = AxNodeEditorNative.axNodeEditor_GetLinkPins(linkId, native_startPinId, native_endPinId);
                    return ret != 0;
                }
            }
        }
        public static ImDrawListPtr GetNodeBackgroundDrawList(axNodeEditor_NodeId nodeId)
        {
            ImDrawList* ret = AxNodeEditorNative.axNodeEditor_GetNodeBackgroundDrawList(nodeId);
            return new ImDrawListPtr(ret);
        }
        public static int GetNodeCount()
        {
            int ret = AxNodeEditorNative.axNodeEditor_GetNodeCount();
            return ret;
        }
        public static Vector2 GetNodePosition(axNodeEditor_NodeId nodeId)
        {
            Vector2 ret = AxNodeEditorNative.axNodeEditor_GetNodePosition(nodeId);
            return ret;
        }
        public static Vector2 GetNodeSize(axNodeEditor_NodeId nodeId)
        {
            Vector2 ret = AxNodeEditorNative.axNodeEditor_GetNodeSize(nodeId);
            return ret;
        }
        public static float GetNodeZPosition(axNodeEditor_NodeId nodeId)
        {
            float ret = AxNodeEditorNative.axNodeEditor_GetNodeZPosition(nodeId);
            return ret;
        }
        public static int GetOrderedNodeIds(ref axNodeEditor_NodeId nodes, int size)
        {
            fixed (axNodeEditor_NodeId* native_nodes = &nodes)
            {
                int ret = AxNodeEditorNative.axNodeEditor_GetOrderedNodeIds(native_nodes, size);
                return ret;
            }
        }
        public static Vector2 GetScreenSize()
        {
            Vector2 ret = AxNodeEditorNative.axNodeEditor_GetScreenSize();
            return ret;
        }
        public static int GetSelectedLinks(ref axNodeEditor_LinkId links, int size)
        {
            fixed (axNodeEditor_LinkId* native_links = &links)
            {
                int ret = AxNodeEditorNative.axNodeEditor_GetSelectedLinks(native_links, size);
                return ret;
            }
        }
        public static int GetSelectedNodes(ref axNodeEditor_NodeId nodes, int size)
        {
            fixed (axNodeEditor_NodeId* native_nodes = &nodes)
            {
                int ret = AxNodeEditorNative.axNodeEditor_GetSelectedNodes(native_nodes, size);
                return ret;
            }
        }
        public static int GetSelectedObjectCount()
        {
            int ret = AxNodeEditorNative.axNodeEditor_GetSelectedObjectCount();
            return ret;
        }
        public static axNodeEditor_Style* GetStyle()
        {
            axNodeEditor_Style* ret = AxNodeEditorNative.axNodeEditor_GetStyle();
            return ret;
        }
        public static string GetStyleColorName(axNodeEditor_StyleColor colorIndex)
        {
            byte* ret = AxNodeEditorNative.axNodeEditor_GetStyleColorName(colorIndex);
            return Util.StringFromPtr(ret);
        }
        public static void Group(ref Vector2 size)
        {
            fixed (Vector2* native_size = &size)
            {
                AxNodeEditorNative.axNodeEditor_Group(native_size);
            }
        }
        public static bool HasAnyLinks(axNodeEditor_NodeId nodeId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_HasAnyLinks(nodeId);
            return ret != 0;
        }
        public static bool HasAnyLinks(axNodeEditor_PinId pinId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_HasAnyLinks(pinId);
            return ret != 0;
        }
        public static bool HasSelectionChanged()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_HasSelectionChanged();
            return ret != 0;
        }
        public static bool IsActive()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_IsActive();
            return ret != 0;
        }
        public static bool IsBackgroundClicked()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_IsBackgroundClicked();
            return ret != 0;
        }
        public static bool IsBackgroundDoubleClicked()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_IsBackgroundDoubleClicked();
            return ret != 0;
        }
        public static bool IsLinkSelected(axNodeEditor_LinkId linkId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_IsLinkSelected(linkId);
            return ret != 0;
        }
        public static bool IsNodeSelected(axNodeEditor_NodeId nodeId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_IsNodeSelected(nodeId);
            return ret != 0;
        }
        public static bool IsSuspended()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_IsSuspended();
            return ret != 0;
        }
        public static bool Link(axNodeEditor_LinkId id, axNodeEditor_PinId startPinId, axNodeEditor_PinId endPinId, ref Vector4 color, float thickness)
        {
            fixed (Vector4* native_color = &color)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_Link(id, startPinId, endPinId, native_color, thickness);
                return ret != 0;
            }
        }
        public static void NavigateToContent(float duration)
        {
            AxNodeEditorNative.axNodeEditor_NavigateToContent(duration);
        }
        public static void NavigateToSelection(bool zoomIn, float duration)
        {
            byte native_zoomIn = zoomIn ? (byte)1 : (byte)0;
            AxNodeEditorNative.axNodeEditor_NavigateToSelection(native_zoomIn, duration);
        }
        public static axNodeEditor_SaveReasonFlags operator&(axNodeEditor_SaveReasonFlags lhs, axNodeEditor_SaveReasonFlags rhs)
        {
            axNodeEditor_SaveReasonFlags ret = AxNodeEditorNative.axNodeEditor_operator_amp(lhs, rhs);
            return ret;
        }
        public static axNodeEditor_SaveReasonFlags operator|(axNodeEditor_SaveReasonFlags lhs, axNodeEditor_SaveReasonFlags rhs)
        {
            axNodeEditor_SaveReasonFlags ret = AxNodeEditorNative.axNodeEditor_operator_pipe(lhs, rhs);
            return ret;
        }
        public static bool PinHadAnyLinks(axNodeEditor_PinId pinId)
        {
            byte ret = AxNodeEditorNative.axNodeEditor_PinHadAnyLinks(pinId);
            return ret != 0;
        }
        public static void PinPivotAlignment(ref Vector2 alignment)
        {
            fixed (Vector2* native_alignment = &alignment)
            {
                AxNodeEditorNative.axNodeEditor_PinPivotAlignment(native_alignment);
            }
        }
        public static void PinPivotRect(ref Vector2 a, ref Vector2 b)
        {
            fixed (Vector2* native_a = &a)
            {
                fixed (Vector2* native_b = &b)
                {
                    AxNodeEditorNative.axNodeEditor_PinPivotRect(native_a, native_b);
                }
            }
        }
        public static void PinPivotScale(ref Vector2 scale)
        {
            fixed (Vector2* native_scale = &scale)
            {
                AxNodeEditorNative.axNodeEditor_PinPivotScale(native_scale);
            }
        }
        public static void PinPivotSize(ref Vector2 size)
        {
            fixed (Vector2* native_size = &size)
            {
                AxNodeEditorNative.axNodeEditor_PinPivotSize(native_size);
            }
        }
        public static void PinRect(ref Vector2 a, ref Vector2 b)
        {
            fixed (Vector2* native_a = &a)
            {
                fixed (Vector2* native_b = &b)
                {
                    AxNodeEditorNative.axNodeEditor_PinRect(native_a, native_b);
                }
            }
        }
        public static void PopStyleColor(int count)
        {
            AxNodeEditorNative.axNodeEditor_PopStyleColor(count);
        }
        public static void PopStyleVar(int count)
        {
            AxNodeEditorNative.axNodeEditor_PopStyleVar(count);
        }
        public static void PushStyleColor(axNodeEditor_StyleColor colorIndex, ref Vector4 color)
        {
            fixed (Vector4* native_color = &color)
            {
                AxNodeEditorNative.axNodeEditor_PushStyleColor(colorIndex, native_color);
            }
        }
        public static void PushStyleVar(axNodeEditor_StyleVar varIndex, float value)
        {
            AxNodeEditorNative.axNodeEditor_PushStyleVar(varIndex, value);
        }
        public static void PushStyleVar(axNodeEditor_StyleVar varIndex, ref Vector2 value)
        {
            fixed (Vector2* native_value = &value)
            {
                AxNodeEditorNative.axNodeEditor_PushStyleVar(varIndex, native_value);
            }
        }
        public static void PushStyleVar(axNodeEditor_StyleVar varIndex, ref Vector4 value)
        {
            fixed (Vector4* native_value = &value)
            {
                AxNodeEditorNative.axNodeEditor_PushStyleVar(varIndex, native_value);
            }
        }
        public static bool QueryDeletedLink(ref axNodeEditor_LinkId linkId, ref axNodeEditor_PinId startId, ref axNodeEditor_PinId endId)
        {
            fixed (axNodeEditor_LinkId* native_linkId = &linkId)
            {
                fixed (axNodeEditor_PinId* native_startId = &startId)
                {
                    fixed (axNodeEditor_PinId* native_endId = &endId)
                    {
                        byte ret = AxNodeEditorNative.axNodeEditor_QueryDeletedLink(native_linkId, native_startId, native_endId);
                        return ret != 0;
                    }
                }
            }
        }
        public static bool QueryDeletedNode(ref axNodeEditor_NodeId nodeId)
        {
            fixed (axNodeEditor_NodeId* native_nodeId = &nodeId)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_QueryDeletedNode(native_nodeId);
                return ret != 0;
            }
        }
        public static bool QueryNewLink(ref axNodeEditor_PinId startId, ref axNodeEditor_PinId endId)
        {
            fixed (axNodeEditor_PinId* native_startId = &startId)
            {
                fixed (axNodeEditor_PinId* native_endId = &endId)
                {
                    byte ret = AxNodeEditorNative.axNodeEditor_QueryNewLink(native_startId, native_endId);
                    return ret != 0;
                }
            }
        }
        public static bool QueryNewLink(ref axNodeEditor_PinId startId, ref axNodeEditor_PinId endId, ref Vector4 color, float thickness)
        {
            fixed (axNodeEditor_PinId* native_startId = &startId)
            {
                fixed (axNodeEditor_PinId* native_endId = &endId)
                {
                    fixed (Vector4* native_color = &color)
                    {
                        byte ret = AxNodeEditorNative.axNodeEditor_QueryNewLink(native_startId, native_endId, native_color, thickness);
                        return ret != 0;
                    }
                }
            }
        }
        public static bool QueryNewNode(ref axNodeEditor_PinId pinId)
        {
            fixed (axNodeEditor_PinId* native_pinId = &pinId)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_QueryNewNode(native_pinId);
                return ret != 0;
            }
        }
        public static bool QueryNewNode(ref axNodeEditor_PinId pinId, ref Vector4 color, float thickness)
        {
            fixed (axNodeEditor_PinId* native_pinId = &pinId)
            {
                fixed (Vector4* native_color = &color)
                {
                    byte ret = AxNodeEditorNative.axNodeEditor_QueryNewNode(native_pinId, native_color, thickness);
                    return ret != 0;
                }
            }
        }
        public static void RejectDeletedItem()
        {
            AxNodeEditorNative.axNodeEditor_RejectDeletedItem();
        }
        public static void RejectNewItem()
        {
            AxNodeEditorNative.axNodeEditor_RejectNewItem();
        }
        public static void RejectNewItem(ref Vector4 color, float thickness)
        {
            fixed (Vector4* native_color = &color)
            {
                AxNodeEditorNative.axNodeEditor_RejectNewItem(native_color, thickness);
            }
        }
        public static void RestoreNodeState(axNodeEditor_NodeId nodeId)
        {
            AxNodeEditorNative.axNodeEditor_RestoreNodeState(nodeId);
        }
        public static void Resume()
        {
            AxNodeEditorNative.axNodeEditor_Resume();
        }
        public static Vector2 ScreenToCanvas(ref Vector2 pos)
        {
            fixed (Vector2* native_pos = &pos)
            {
                Vector2 ret = AxNodeEditorNative.axNodeEditor_ScreenToCanvas(native_pos);
                return ret;
            }
        }
        public static void SelectLink(axNodeEditor_LinkId linkId, bool append)
        {
            byte native_append = append ? (byte)1 : (byte)0;
            AxNodeEditorNative.axNodeEditor_SelectLink(linkId, native_append);
        }
        public static void SelectNode(axNodeEditor_NodeId nodeId, bool append)
        {
            byte native_append = append ? (byte)1 : (byte)0;
            AxNodeEditorNative.axNodeEditor_SelectNode(nodeId, native_append);
        }
        public static void SetCurrentEditor(ref axNodeEditor_EditorContext ctx)
        {
            fixed (axNodeEditor_EditorContext* native_ctx = &ctx)
            {
                AxNodeEditorNative.axNodeEditor_SetCurrentEditor(native_ctx);
            }
        }
        public static void SetGroupSize(axNodeEditor_NodeId nodeId, ref Vector2 size)
        {
            fixed (Vector2* native_size = &size)
            {
                AxNodeEditorNative.axNodeEditor_SetGroupSize(nodeId, native_size);
            }
        }
        public static void SetNodePosition(axNodeEditor_NodeId nodeId, ref Vector2 editorPosition)
        {
            fixed (Vector2* native_editorPosition = &editorPosition)
            {
                AxNodeEditorNative.axNodeEditor_SetNodePosition(nodeId, native_editorPosition);
            }
        }
        public static void SetNodeZPosition(axNodeEditor_NodeId nodeId, float z)
        {
            AxNodeEditorNative.axNodeEditor_SetNodeZPosition(nodeId, z);
        }
        public static bool ShowBackgroundContextMenu()
        {
            byte ret = AxNodeEditorNative.axNodeEditor_ShowBackgroundContextMenu();
            return ret != 0;
        }
        public static bool ShowLinkContextMenu(ref axNodeEditor_LinkId linkId)
        {
            fixed (axNodeEditor_LinkId* native_linkId = &linkId)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_ShowLinkContextMenu(native_linkId);
                return ret != 0;
            }
        }
        public static bool ShowNodeContextMenu(ref axNodeEditor_NodeId nodeId)
        {
            fixed (axNodeEditor_NodeId* native_nodeId = &nodeId)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_ShowNodeContextMenu(native_nodeId);
                return ret != 0;
            }
        }
        public static bool ShowPinContextMenu(ref axNodeEditor_PinId pinId)
        {
            fixed (axNodeEditor_PinId* native_pinId = &pinId)
            {
                byte ret = AxNodeEditorNative.axNodeEditor_ShowPinContextMenu(native_pinId);
                return ret != 0;
            }
        }
        public static void Suspend()
        {
            AxNodeEditorNative.axNodeEditor_Suspend();
        }
        public static axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* operator=(ref axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId __self, ref axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId __0)
        {
            fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* ret = AxNodeEditorNative.axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId_operator_equal(native___self, native___0);
                    return ret;
                }
            }
        }
        public static axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* operator=(ref axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId __self, ref axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId __0)
        {
            fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* ret = AxNodeEditorNative.axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId_operator_equal1(native___self, native___0);
                    return ret;
                }
            }
        }
        public static axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* operator=(ref axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId __self, ref axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId __0)
        {
            fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* ret = AxNodeEditorNative.axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId_operator_equal(native___self, native___0);
                    return ret;
                }
            }
        }
        public static axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* operator=(ref axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId __self, ref axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId __0)
        {
            fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* ret = AxNodeEditorNative.axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId_operator_equal1(native___self, native___0);
                    return ret;
                }
            }
        }
        public static axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* operator=(ref axNodeEditorDetails_SafePointerType_axNodeEditor_PinId __self, ref axNodeEditorDetails_SafePointerType_axNodeEditor_PinId __0)
        {
            fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* ret = AxNodeEditorNative.axNodeEditorDetails_SafePointerType_axNodeEditor_PinId_operator_equal(native___self, native___0);
                    return ret;
                }
            }
        }
        public static axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* operator=(ref axNodeEditorDetails_SafePointerType_axNodeEditor_PinId __self, ref axNodeEditorDetails_SafePointerType_axNodeEditor_PinId __0)
        {
            fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* ret = AxNodeEditorNative.axNodeEditorDetails_SafePointerType_axNodeEditor_PinId_operator_equal1(native___self, native___0);
                    return ret;
                }
            }
        }
        public static unsigned long long Get(ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId __self)
        {
            fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* native___self = &__self)
            {
                unsigned long long ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId_Get(native___self);
                return ret;
            }
        }
        public static axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* operator=(ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId __self, ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId __0)
        {
            fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId_operator_equal(native___self, native___0);
                    return ret;
                }
            }
        }
        public static unsigned long long Get(ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId __self)
        {
            fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* native___self = &__self)
            {
                unsigned long long ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId_Get(native___self);
                return ret;
            }
        }
        public static axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* operator=(ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId __self, ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId __0)
        {
            fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId_operator_equal(native___self, native___0);
                    return ret;
                }
            }
        }
        public static unsigned long long Get(ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId __self)
        {
            fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* native___self = &__self)
            {
                unsigned long long ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId_Get(native___self);
                return ret;
            }
        }
        public static axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* operator=(ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId __self, ref axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId __0)
        {
            fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* native___self = &__self)
            {
                fixed (axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* native___0 = &__0)
                {
                    axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* ret = AxNodeEditorNative.axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId_operator_equal(native___self, native___0);
                    return ret;
                }
            }
        }
    }
}
