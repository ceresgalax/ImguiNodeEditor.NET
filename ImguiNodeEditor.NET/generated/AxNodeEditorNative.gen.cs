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
        public static extern byte axNodeEditor_AcceptNewItem1(Vector4* color, float thickness);
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
        public static extern byte axNodeEditor_BeginGroupHint(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_BeginNode(NodeId id);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_BeginPin(PinId id, PinKind kind);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_BeginShortcut();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_BreakLinks(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_BreakLinks1(PinId pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_CanvasToScreen(Vector2* pos);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_CenterNodeOnScreen(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_ClearSelection();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr axNodeEditor_CreateEditor(Config* config);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_DeleteLink(LinkId linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_DeleteNode(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_DeselectLink(LinkId linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_DeselectNode(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_DestroyEditor(IntPtr ctx);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* axNodeEditorDetails_SafeType_voidptr_axNodeEditor_LinkId_Get(Details_SafeType_voidptr_LinkId* __self);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* axNodeEditorDetails_SafeType_voidptr_axNodeEditor_NodeId_Get(Details_SafeType_voidptr_NodeId* __self);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* axNodeEditorDetails_SafeType_voidptr_axNodeEditor_PinId_Get(Details_SafeType_voidptr_PinId* __self);
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
        public static extern void axNodeEditor_Flow(LinkId linkId, FlowDirection direction);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetActionContextLinks(LinkId* links, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetActionContextNodes(NodeId* nodes, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetActionContextSize();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetBackgroundClickButtonIndex();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetBackgroundDoubleClickButtonIndex();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Config* axNodeEditor_GetConfig(IntPtr ctx);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr axNodeEditor_GetCurrentEditor();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern float axNodeEditor_GetCurrentZoom();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern LinkId axNodeEditor_GetDoubleClickedLink();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern NodeId axNodeEditor_GetDoubleClickedNode();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern PinId axNodeEditor_GetDoubleClickedPin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetGroupMax();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetGroupMin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* axNodeEditor_GetHintBackgroundDrawList();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* axNodeEditor_GetHintForegroundDrawList();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern LinkId axNodeEditor_GetHoveredLink();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern NodeId axNodeEditor_GetHoveredNode();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern PinId axNodeEditor_GetHoveredPin();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_GetLinkPins(LinkId linkId, PinId* startPinId, PinId* endPinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* axNodeEditor_GetNodeBackgroundDrawList(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetNodeCount();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetNodePosition(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetNodeSize(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern float axNodeEditor_GetNodeZPosition(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetOrderedNodeIds(NodeId* nodes, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_GetScreenSize();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetSelectedLinks(LinkId* links, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetSelectedNodes(NodeId* nodes, int size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int axNodeEditor_GetSelectedObjectCount();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Style* axNodeEditor_GetStyle();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* axNodeEditor_GetStyleColorName(StyleColor colorIndex);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Group(Vector2* size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_HasAnyLinks(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_HasAnyLinks1(PinId pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_HasSelectionChanged();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsActive();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsBackgroundClicked();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsBackgroundDoubleClicked();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsLinkSelected(LinkId linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsNodeSelected(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_IsSuspended();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_Link(LinkId id, PinId startPinId, PinId endPinId, Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_NavigateToContent(float duration);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_NavigateToSelection(byte zoomIn, float duration);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_PinHadAnyLinks(PinId pinId);
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
        public static extern void axNodeEditor_PushStyleColor(StyleColor colorIndex, Vector4* color);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleVar(StyleVar varIndex, float value);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleVar1(StyleVar varIndex, Vector2* value);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_PushStyleVar2(StyleVar varIndex, Vector4* value);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryDeletedLink(LinkId* linkId, PinId* startId, PinId* endId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryDeletedNode(NodeId* nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewLink(PinId* startId, PinId* endId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewLink1(PinId* startId, PinId* endId, Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewNode(PinId* pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_QueryNewNode1(PinId* pinId, Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RejectDeletedItem();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RejectNewItem();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RejectNewItem1(Vector4* color, float thickness);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_RestoreNodeState(NodeId nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Resume();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 axNodeEditor_ScreenToCanvas(Vector2* pos);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SelectLink(LinkId linkId, byte append);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SelectNode(NodeId nodeId, byte append);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetCurrentEditor(IntPtr ctx);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetGroupSize(NodeId nodeId, Vector2* size);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetNodePosition(NodeId nodeId, Vector2* editorPosition);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_SetNodeZPosition(NodeId nodeId, float z);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowBackgroundContextMenu();
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowLinkContextMenu(LinkId* linkId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowNodeContextMenu(NodeId* nodeId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte axNodeEditor_ShowPinContextMenu(PinId* pinId);
        [DllImport("cimguinodeeditor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void axNodeEditor_Suspend();
    }
}
