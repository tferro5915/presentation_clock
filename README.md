# Presentation Clock

Creates a presentation timer GUI. 

## Components

* Host window for controlling/monitoring the timer. 
* Client window to show the countdown timed countdown and progressbar. 
* Widget for just a progress bar that can be displayed over a presentation for the audience. 

## Run

* Open executable or run as a python script (`python main.py`).
* Place the windows on the desired monitors/screens. 
* Set total number of minutes for the presentation.
* Set at what time the color of the progress bar should change to green, yellow, red, and flashing (red/black).
* Click play to start the countdown. 
* Click Pause, stop, or reset as needed. 
* Shim the time to adjust the running clock as needed, by entering the amount to adjust and clicking plus to increase by that amount or minus to decrease. 

## Generate executable
* Open a terminal
* Navigate to project folder
* Run `pip install -U pyinstaller`
* Run `pyinstaller --onefile --windowed --add-data "play.png;." --add-data "stop.png;." --add-data "pause.png;." --add-data "reset.png;." --add-data "plus.png;." --add-data "minus.png;." main.py`
