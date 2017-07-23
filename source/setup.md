**Getting Started**

Open up the desired project or form you want to add fullscreen capabilities to, and drop 2 buttons, these can be any kind of buttons. e.g. Toolstrip, Buttons, Dropdownitems etc.

Name one FullScreen, and the other ExitFullScreen. 

Now, grab the code from the [Fullscreen.vb](https://github.com/jdc20181/WindowsFormsFullScreen/blob/master/source/FullScreen.Vb) File, and put in its respective spot.

There is a little more configurating to do - 

You most likely don't want both buttons visible at the same time, it will cause issues, so what we will do is, hide the buttons upon click and show the other button.

On Form load, you want to hide the ExitFullScreen button. 

When the FullScreen Button is clicked you want to Hide the FullScreen Button and show the ExitFullScreen Button. And the same concept when the exit button is clicked. 

Here is an example for those new to VB.net

Button1.visible = Condtion (True, False)
