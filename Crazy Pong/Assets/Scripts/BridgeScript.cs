using UnityEngine;

/// <summary>
/// Bridge used to communicate with a page
/// </summary>
public class BridgeScript : MonoBehaviour
{

    public void SendScoreToPage(int score)
    {
        // Sends the message through JS plugin
        WebGLPluginJS.SendScoreToPage(score);
    }
}