# Presentation Clock

Creates a presentation timer GUI. 

## Components

* Host window for controlling/monitoring the timer. 
* Client window to show the countdown timer and progressbar. 
* Widget for just a progress bar, that can be displayed over a presentation for the audience. 

![Presentation_Timer](https://user-images.githubusercontent.com/8659479/205778720-cb85a346-42f1-469b-be0a-6ee92fadffad.png)

## Run

* Open executable or run as a python script (`python main.py`).
* Place the windows on the desired monitors/screens. 
* Set total number of minutes for the presentation.
* Set at what time in the countdown the color of the progress bar should change to green, yellow, red, and flashing (red/black). These are entered as minutes in decimal form.
* Click play to start the countdown. 
* Click Pause, stop, or reset as needed. 
* Shim the time to adjust the running clock as needed, by entering the amount to adjust (in minutes) and clicking plus to increase by that amount or minus to decrease. 

## Generate executable

* Open a terminal
* Navigate to project folder
* Run `pip install pyinstaller`
* Run `pyinstaller --onefile --windowed --add-data "Resources/play.png;." --add-data "Resources/stop.png;." --add-data "Resources/pause.png;." --add-data "Resources/reset.png;." --add-data "Resources/plus.png;." --add-data "Resources/minus.png;." Python/main.py`. Note `;` may need to be replaced with `:` when running in linux. 
