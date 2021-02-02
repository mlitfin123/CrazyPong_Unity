using System.Runtime.InteropServices;

/// <summary>
/// Class with a JS Plugin functions for WebGL.
/// </summary>
public static class WebGLPluginJS
{
    // Importing "SendMessageToPage"
    [DllImport("__Internal")]
    public static extern void SendScoreToPage(int txt);
}
