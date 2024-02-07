using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct axNodeEditor_Style
    {
        public Vector4 NodePadding;
        public float NodeRounding;
        public float NodeBorderWidth;
        public float HoveredNodeBorderWidth;
        public float HoverNodeBorderOffset;
        public float SelectedNodeBorderWidth;
        public float SelectedNodeBorderOffset;
        public float PinRounding;
        public float PinBorderWidth;
        public float LinkStrength;
        public Vector2 SourceDirection;
        public Vector2 TargetDirection;
        public float ScrollDuration;
        public float FlowMarkerDistance;
        public float FlowSpeed;
        public float FlowDuration;
        public Vector2 PivotAlignment;
        public Vector2 PivotSize;
        public Vector2 PivotScale;
        public float PinCorners;
        public float PinRadius;
        public float PinArrowSize;
        public float PinArrowWidth;
        public float GroupRounding;
        public float GroupBorderWidth;
        public float HighlightConnectedLinks;
        public float SnapLinkToPinDir;
        public ImVec4[19] Colors;
    }
    public unsafe partial struct axNodeEditor_StylePtr
    {
        public axNodeEditor_Style* NativePtr { get; }
        public axNodeEditor_StylePtr(axNodeEditor_Style* nativePtr) => NativePtr = nativePtr;
        public axNodeEditor_StylePtr(IntPtr nativePtr) => NativePtr = (axNodeEditor_Style*)nativePtr;
        public static implicit operator axNodeEditor_StylePtr(axNodeEditor_Style* nativePtr) => new axNodeEditor_StylePtr(nativePtr);
        public static implicit operator axNodeEditor_Style* (axNodeEditor_StylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator axNodeEditor_StylePtr(IntPtr nativePtr) => new axNodeEditor_StylePtr(nativePtr);
        public ref Vector4 NodePadding => ref Unsafe.AsRef<Vector4>(&NativePtr->NodePadding);
        public ref float NodeRounding => ref Unsafe.AsRef<float>(&NativePtr->NodeRounding);
        public ref float NodeBorderWidth => ref Unsafe.AsRef<float>(&NativePtr->NodeBorderWidth);
        public ref float HoveredNodeBorderWidth => ref Unsafe.AsRef<float>(&NativePtr->HoveredNodeBorderWidth);
        public ref float HoverNodeBorderOffset => ref Unsafe.AsRef<float>(&NativePtr->HoverNodeBorderOffset);
        public ref float SelectedNodeBorderWidth => ref Unsafe.AsRef<float>(&NativePtr->SelectedNodeBorderWidth);
        public ref float SelectedNodeBorderOffset => ref Unsafe.AsRef<float>(&NativePtr->SelectedNodeBorderOffset);
        public ref float PinRounding => ref Unsafe.AsRef<float>(&NativePtr->PinRounding);
        public ref float PinBorderWidth => ref Unsafe.AsRef<float>(&NativePtr->PinBorderWidth);
        public ref float LinkStrength => ref Unsafe.AsRef<float>(&NativePtr->LinkStrength);
        public ref Vector2 SourceDirection => ref Unsafe.AsRef<Vector2>(&NativePtr->SourceDirection);
        public ref Vector2 TargetDirection => ref Unsafe.AsRef<Vector2>(&NativePtr->TargetDirection);
        public ref float ScrollDuration => ref Unsafe.AsRef<float>(&NativePtr->ScrollDuration);
        public ref float FlowMarkerDistance => ref Unsafe.AsRef<float>(&NativePtr->FlowMarkerDistance);
        public ref float FlowSpeed => ref Unsafe.AsRef<float>(&NativePtr->FlowSpeed);
        public ref float FlowDuration => ref Unsafe.AsRef<float>(&NativePtr->FlowDuration);
        public ref Vector2 PivotAlignment => ref Unsafe.AsRef<Vector2>(&NativePtr->PivotAlignment);
        public ref Vector2 PivotSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PivotSize);
        public ref Vector2 PivotScale => ref Unsafe.AsRef<Vector2>(&NativePtr->PivotScale);
        public ref float PinCorners => ref Unsafe.AsRef<float>(&NativePtr->PinCorners);
        public ref float PinRadius => ref Unsafe.AsRef<float>(&NativePtr->PinRadius);
        public ref float PinArrowSize => ref Unsafe.AsRef<float>(&NativePtr->PinArrowSize);
        public ref float PinArrowWidth => ref Unsafe.AsRef<float>(&NativePtr->PinArrowWidth);
        public ref float GroupRounding => ref Unsafe.AsRef<float>(&NativePtr->GroupRounding);
        public ref float GroupBorderWidth => ref Unsafe.AsRef<float>(&NativePtr->GroupBorderWidth);
        public ref float HighlightConnectedLinks => ref Unsafe.AsRef<float>(&NativePtr->HighlightConnectedLinks);
        public ref float SnapLinkToPinDir => ref Unsafe.AsRef<float>(&NativePtr->SnapLinkToPinDir);
        public ref ImVec4[19] Colors => ref Unsafe.AsRef<ImVec4[19]>(&NativePtr->Colors);
    }
}
