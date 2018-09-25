# SmashWiiUSinglesOverlayStep3
Step 3 of a project to create a dynamically editable overlay for Super Smash Bros. Wii U Singles usable for any tournament streamer using HTML, JavaScript, CSS and C#.

Changes from Step 2:
- The manager solution/application has been added to the project, meaning you don't have to manually edit css files!
- Player Ports and Player Backgrounds are now separated.
- Added JQuery library to dynamically update the overlay when the CSS is altered.

Anyone is allowed to clone this repository and create their own overlay manager if they feel it lacks some functionality that they need for their own tournament streams. I will not accept any pull requests unless it fixes an important bug.

I kept the code as simple and seperated in different functions as possible, to make it easier to understand for beginners in programming, anyone is allowed to clone this repository and refactor the code if they feel the code is too redundant. I will not accept any pull requests unless it fixes an important bug.

**Requirements:**
- Visual Studio 2017 (or higher) Community (or Professional/Enterprise).

**How to use:**
**How to use in Visual Studio:**
- Open SmashWiiUOverlayManager.sln using Visual Studio.


- Run the application.

![alt img](https://imgur.com/na4ecHT.png)

- Fill the form on the overlay manager and click Submit.

![alt img](https://imgur.com/dtz4LoR.png)

You can doublecheck whether the application works now by checking if all of the following files exist in "\SmashWiiUOverlayManager\SmashWiiUOverlayManager\bin\ {Debug/Release} \Files\css":
- player1Character.css.
- player1NameText.css.
- player1Port.css.
- player1Score.css.
- player2Character.css.
- player2NameText.css.
- player2Port.css.
- player2Score.css.
- roundBoxTest.css.
- styles.css. (is there by default)

**How to use in Open Broadcaster Software (OBS Studio):**
- Add a new Browser source to your scene.

![alt img](https://imgur.com/em1uLIw.png)

- Check the Local file checkbox and click Browse.

![alt img](https://imgur.com/jhgThI0.png)
- Select gameOverlay.html in the "\SmashWiiUOverlayManager\SmashWiiUOverlayManager\bin\ {Debug/Release} \Files\css" folder. 
- Set the resolution and framerate. (1920 x 1080 at 60 frames per second recommended)
- Check Refresh browser when scene becomes active checkbox.

![alt img](https://imgur.com/RItgGYV.png)

You are now ready to stream with the overlay.

As the streamed set(s) progress, you can update the overlay by filling in the inputs and clicking Submit in the overlay manager.

At this step, the overlay dynamically updates whenever the CSS is altered!
