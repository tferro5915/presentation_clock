# Presentation Clock

Creates a presentation timer GUI. 

## Components

* Host window for controlling/monitoring the timer. 
* Client window to show the countdown timed countdown and progressbar. 
* Widget for just a progress bar that can be displayed over a presentation for the audience. 

## Generate executable
* Open a terminal
* Navigate to project folder
* Run `pip install -U pyinstaller`
* Run `pyinstaller --onefile --windowed --add-data "play.png;." --add-data "stop.png;." --add-data "pause.png;." --add-data "reset.png;." main.py`
* 