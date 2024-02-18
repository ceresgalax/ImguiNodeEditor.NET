using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace AxNodeEditorNET
{
    public unsafe partial struct Style
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
        public Vector4 Colors_0;
        public Vector4 Colors_1;
        public Vector4 Colors_2;
        public Vector4 Colors_3;
        public Vector4 Colors_4;
        public Vector4 Colors_5;
        public Vector4 Colors_6;
        public Vector4 Colors_7;
        public Vector4 Colors_8;
        public Vector4 Colors_9;
        public Vector4 Colors_10;
        public Vector4 Colors_11;
        public Vector4 Colors_12;
        public Vector4 Colors_13;
        public Vector4 Colors_14;
        public Vector4 Colors_15;
        public Vector4 Colors_16;
        public Vector4 Colors_17;
        public Vector4 Colors_18;
    }
    public unsafe partial struct StylePtr
    {
        public Style* NativePtr { get; }
        public StylePtr(Style* nativePtr) => NativePtr = nativePtr;
        public StylePtr(IntPtr nativePtr) => NativePtr = (Style*)nativePtr;
        public static implicit operator StylePtr(Style* nativePtr) => new StylePtr(nativePtr);
        public static implicit operator Style* (StylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator StylePtr(IntPtr nativePtr) => new StylePtr(nativePtr);
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
        public RangeAccessor<Vector4> Colors => new RangeAccessor<Vector4>(&NativePtr->Colors_0, 19);
    }
}
