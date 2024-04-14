using System;

namespace AxNodeEditorNET
{
    public sealed class Editor : IDisposable
    {
        public readonly IntPtr Context;

        public Editor(ref Config config)
        {
            Context = AxNodeEditor.CreateEditor(ref config);
        }
        
        private void ReleaseUnmanagedResources()
        {
            AxNodeEditor.DestroyEditor(Context);
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~Editor()
        {
            ReleaseUnmanagedResources();
        }

    }
}