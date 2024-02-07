using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public static unsafe partial class AxNodeEditorNative
    {
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptCopy();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptCreateNode();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptCut();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptDeletedItem(byte deleteDependencies);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptDuplicate();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptNewItem();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptNewItem(Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AcceptPaste();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_AreShortcutsEnabled();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Begin(byte* id, Vector2* size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_BeginCreate(Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_BeginDelete();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_BeginGroupHint(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_BeginNode(axNodeEditor_NodeId id);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_BeginPin(axNodeEditor_PinId id, axNodeEditor_PinKind kind);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_BeginShortcut();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_BreakLinks(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_BreakLinks(axNodeEditor_PinId pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_CanvasToScreen(Vector2* pos);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_CenterNodeOnScreen(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_ClearSelection();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_EditorContext* axNodeEditor_CreateEditor(axNodeEditor_Config* config);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_DeleteLink(axNodeEditor_LinkId linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_DeleteNode(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_DeselectLink(axNodeEditor_LinkId linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_DeselectNode(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_DestroyEditor(axNodeEditor_EditorContext* ctx);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EnableShortcuts(byte enable);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_End();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EndCreate();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EndDelete();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EndGroupHint();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EndNode();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EndPin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_EndShortcut();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Flow(axNodeEditor_LinkId linkId, axNodeEditor_FlowDirection direction);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetActionContextLinks(axNodeEditor_LinkId* links, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetActionContextNodes(axNodeEditor_NodeId* nodes, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetActionContextSize();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetBackgroundClickButtonIndex();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetBackgroundDoubleClickButtonIndex();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_Config* axNodeEditor_GetConfig(axNodeEditor_EditorContext* ctx);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_EditorContext* axNodeEditor_GetCurrentEditor();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern float axNodeEditor_GetCurrentZoom();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_LinkId axNodeEditor_GetDoubleClickedLink();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_NodeId axNodeEditor_GetDoubleClickedNode();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_PinId axNodeEditor_GetDoubleClickedPin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetGroupMax();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetGroupMin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* axNodeEditor_GetHintBackgroundDrawList();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* axNodeEditor_GetHintForegroundDrawList();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_LinkId axNodeEditor_GetHoveredLink();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_NodeId axNodeEditor_GetHoveredNode();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_PinId axNodeEditor_GetHoveredPin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_GetLinkPins(axNodeEditor_LinkId linkId, axNodeEditor_PinId* startPinId, axNodeEditor_PinId* endPinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* axNodeEditor_GetNodeBackgroundDrawList(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetNodeCount();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetNodePosition(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetNodeSize(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern float axNodeEditor_GetNodeZPosition(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetOrderedNodeIds(axNodeEditor_NodeId* nodes, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetScreenSize();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetSelectedLinks(axNodeEditor_LinkId* links, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetSelectedNodes(axNodeEditor_NodeId* nodes, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetSelectedObjectCount();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_Style* axNodeEditor_GetStyle();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* axNodeEditor_GetStyleColorName(axNodeEditor_StyleColor colorIndex);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Group(Vector2* size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_HasAnyLinks(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_HasAnyLinks(axNodeEditor_PinId pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_HasSelectionChanged();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsActive();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsBackgroundClicked();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsBackgroundDoubleClicked();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsLinkSelected(axNodeEditor_LinkId linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsNodeSelected(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsSuspended();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_Link(axNodeEditor_LinkId id, axNodeEditor_PinId startPinId, axNodeEditor_PinId endPinId, Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_NavigateToContent(float duration);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_NavigateToSelection(byte zoomIn, float duration);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_SaveReasonFlags axNodeEditor_operator_amp(axNodeEditor_SaveReasonFlags lhs, axNodeEditor_SaveReasonFlags rhs);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditor_SaveReasonFlags axNodeEditor_operator_pipe(axNodeEditor_SaveReasonFlags lhs, axNodeEditor_SaveReasonFlags rhs);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_PinHadAnyLinks(axNodeEditor_PinId pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PinPivotAlignment(Vector2* alignment);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PinPivotRect(Vector2* a, Vector2* b);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PinPivotScale(Vector2* scale);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PinPivotSize(Vector2* size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PinRect(Vector2* a, Vector2* b);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PopStyleColor(int count);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PopStyleVar(int count);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleColor(axNodeEditor_StyleColor colorIndex, Vector4* color);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleVar(axNodeEditor_StyleVar varIndex, float value);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleVar(axNodeEditor_StyleVar varIndex, Vector2* value);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleVar(axNodeEditor_StyleVar varIndex, Vector4* value);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryDeletedLink(axNodeEditor_LinkId* linkId, axNodeEditor_PinId* startId, axNodeEditor_PinId* endId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryDeletedNode(axNodeEditor_NodeId* nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewLink(axNodeEditor_PinId* startId, axNodeEditor_PinId* endId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewLink(axNodeEditor_PinId* startId, axNodeEditor_PinId* endId, Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewNode(axNodeEditor_PinId* pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewNode(axNodeEditor_PinId* pinId, Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RejectDeletedItem();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RejectNewItem();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RejectNewItem(Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RestoreNodeState(axNodeEditor_NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Resume();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_ScreenToCanvas(Vector2* pos);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SelectLink(axNodeEditor_LinkId linkId, byte append);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SelectNode(axNodeEditor_NodeId nodeId, byte append);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetCurrentEditor(axNodeEditor_EditorContext* ctx);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetGroupSize(axNodeEditor_NodeId nodeId, Vector2* size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetNodePosition(axNodeEditor_NodeId nodeId, Vector2* editorPosition);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetNodeZPosition(axNodeEditor_NodeId nodeId, float z);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowBackgroundContextMenu();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowLinkContextMenu(axNodeEditor_LinkId* linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowNodeContextMenu(axNodeEditor_NodeId* nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowPinContextMenu(axNodeEditor_PinId* pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Suspend();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId_operator_equal(axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* __self, axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId_operator_equal1(axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* __self, axNodeEditorDetails_SafePointerType_axNodeEditor_LinkId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId_operator_equal(axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* __self, axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId_operator_equal1(axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* __self, axNodeEditorDetails_SafePointerType_axNodeEditor_NodeId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* axNodeEditorDetails_SafePointerType_axNodeEditor_PinId_operator_equal(axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* __self, axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* axNodeEditorDetails_SafePointerType_axNodeEditor_PinId_operator_equal1(axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* __self, axNodeEditorDetails_SafePointerType_axNodeEditor_PinId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsigned long long axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId_Get(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* __self);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId_operator_equal(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* __self, axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_LinkId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsigned long long axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId_Get(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* __self);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId_operator_equal(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* __self, axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_NodeId* __0);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsigned long long axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId_Get(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* __self);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId_operator_equal(axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* __self, axNodeEditorDetails_SafeType_unsignedlonglong_axNodeEditor_PinId* __0);
    }
}
