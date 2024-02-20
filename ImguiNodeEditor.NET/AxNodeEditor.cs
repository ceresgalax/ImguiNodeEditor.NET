namespace AxNodeEditorNET
{
    public partial class AxNodeEditor
    {
        public static unsafe StylePtr GetStylePtr()
        {
            // TODO: Not sure why ImGui.NET isn't generating wrapper code like this. Need to investigate.
            return new StylePtr(AxNodeEditorNative.axNodeEditor_GetStyle());
        }
    }
}