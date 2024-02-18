namespace AxNodeEditorNET
{
    [System.Flags]
    public enum SaveReasonFlags
    {
        None = 0,
        Navigation = 1,
        Position = 2,
        Size = 4,
        Selection = 8,
        AddNode = 16,
        RemoveNode = 32,
        User = 64,
    }
}
