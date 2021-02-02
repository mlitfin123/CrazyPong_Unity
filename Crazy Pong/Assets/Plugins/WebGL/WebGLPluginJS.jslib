// Creating functions for the Unity
mergeInto(LibraryManager.library, {

   // Method used to send a message to the page
    SendScoreToPage: function (score) {
        var FinalScore = score;

        window.alert("Your Final Score is: " + FinalScore + "!")

      // Pass message to the page
        ReactUnityWebGL.receiveMessageFromUnity(FinalScore); // This function is embeded into the page
   }
});