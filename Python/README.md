# Presentation Clock (Make with Python)

![Presentation_Timer](https://user-images.githubusercontent.com/8659479/205778720-cb85a346-42f1-469b-be0a-6ee92fadffad.png)

## Build

* Open a terminal
* Navigate to project folder
* Run `pip install pyinstaller`
* Run `pyinstaller --onefile --windowed --add-data "Resources/play.png;." --add-data "Resources/stop.png;." --add-data "Resources/pause.png;." --add-data "Resources/reset.png;." --add-data "Resources/plus.png;." --add-data "Resources/minus.png;." Python/main.py`. Note `;` may need to be replaced with `:` when running in linux. 

## Run

* Open executable or run as a python script (`python main.py`).
