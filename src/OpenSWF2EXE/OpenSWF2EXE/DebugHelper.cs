using System.Diagnostics;

namespace OpenSWF2EXE
{
    public static class DebugHelper
    {
        public static void WriteLine(object msg)
        {
            Debug.WriteLine(msg.ToString());
        }
    }
}