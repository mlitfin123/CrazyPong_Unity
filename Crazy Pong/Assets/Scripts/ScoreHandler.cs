using UnityEngine;
using TMPro;

/// </summary>
public class ScoreHandler : MonoBehaviour
{
    // Reference to the bridge
    [SerializeField]
    private BridgeScript bridge;

    /// <summary>
    /// Method for sending score to the bridge
    /// </summary>
    public void SendScoreToPage()
    {
        // Get a message
        var FinalScore = ScoreScript.Score;

        // Send a message to the brigde
        bridge.SendScoreToPage(FinalScore);
    }
}