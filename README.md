# BadPaint
#### Video Demo: https://www.youtube.com/watch?v=gFGA0INf0iU
#### Description:
BadPaint is a basic paint program written in C# with .NET as a Windows Forms application. It's designed to work with Windows 10 and up.

## The idea

As usual, I wanted to challenge myself. My inspiration for this project leads to messing around with Mario Paint and mspaint. I believe in the idea that art should be a fun experience, but I usually find myself frustrated. Of course, my little paint program isn't going to overtake Photoshop or GIMP over the span of a few days. I watched a few YouTube videos on others creating Windows Forms apps and making their own art programs, so I took the liberty to try it for myself.

This wasn't originally going to be my final project, but I'm afraid the original idea I had is a bit too ambitious to finish without sloppy decisions.

## Features

### Pens

BadPaint has two pens bound to the left and right mouse buttons. Currently, these pens are the only tool available.

### Line Width

The line width of both pens is controlled by the numerical input labeled "Line Width" on the right of the config panel at the top right. A valid line width consists of an integer between 0 and 100 inclusive.

### Color Palette

The color of the pens can be changed by clicking the corresponding mouse button on the chosen color. Both pens store their own color.

A custom color can be chosen by clicking the "!" button on the custom color chooser. Once a color is chosen from the dialog, the color box itself can be clicked in the same manner as other palette boxes to choose the color.

### Saving

To save the image, click the top button with a floppy icon. A dialog will appear to save the file as a PNG.

### Loading

To load an image, click the bottom button with a folder icon. A dialog will appear to load an image file. At this moment in time, cancelling this operation will cause a crash.

### Fill button

The fill button will fill the entire document with the pen color corresponding to the mouse button pressed.

## Credits & Acknowledgements

Arcade textures - https://opengameart.org/content/arcade-carpet-textures
Color palette - https://en.wikipedia.org/wiki/Web_colors
