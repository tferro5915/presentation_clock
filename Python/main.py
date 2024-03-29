"""Creates a presentation timer GUI. 

Host window for controlling/monitoring the timer. 
Client window to show the countdown timed countdown and progressbar. 
Widget for just a progress bar that can be displayed over a presentation for the audience. 

TODO: Update client to be resizable for different resolutions/screen-size
"""
import os, sys, math
import tkinter as tk
from tkinter import ttk
from datetime import timedelta

# Constants
interval = timedelta(seconds=1)

# Window placeholders
host_window = tk.Tk()
client_window = tk.Toplevel()
widget_window = tk.Toplevel()

# Theme setup
bg = ["gray", "black"]  # Normal, inverted (for flashing)
fg = ["black", "gray"]
bar = ['red', 'black']

s = ttk.Style()
s.theme_use("default")
colors = ['green', 'yellow', 'red', 'gray', 'black']
thicknesses = [20, 200, 30]
ts = [str(x) for x in thicknesses]
for c in colors:
    for t in thicknesses:
        s.configure(str(t) + "." + c + ".Horizontal.TProgressbar", foreground=c, background=c, thickness=t)

current_bg = bg[0]
current_fg = fg[0]
current_bar = bar[0]

# Placeholder variables in TK to hole GUI inputs/outputs
minute_total = tk.DoubleVar(host_window, value="00.0")
minute_green = tk.StringVar(host_window, value="00.0")
minute_yellow = tk.StringVar(host_window, value="00.0")
minute_red = tk.StringVar(host_window, value="00.0")
minute_flash = tk.StringVar(host_window, value="00.0")
minute_shim = tk.StringVar(host_window, value="00.0")
time_display = tk.StringVar(host_window, value="00:00")
progress = tk.DoubleVar(host_window, value=0)

time = timedelta(seconds=0)
paused = True
tic_listener = None

needs_reset = True
def value_changed(*args): 
    global needs_reset
    needs_reset=True
minute_total.trace_add("write", value_changed)



def build_window():
    """Build up the initial windows and create event handlers.
    """
    global host_window, minute_total, minute_green, minute_yellow, minute_red, minute_flash
    global progress_host, progress_client, progress_widget, clock_display_client

    # Host Window - User inputs
    host_window.attributes('-topmost',True)
    host_window.geometry("400x200")
    host_window.title("Presentation Timer: Host")
    control_frame_1 = tk.Frame(host_window)

    total_label = tk.Label(control_frame_1, text="Total", height=4)
    total_label.pack(side="left")
    minuteEntry_total = tk.Entry(control_frame_1, width=4, font=("Arial",12,""), textvariable=minute_total)
    minuteEntry_total.pack(side="left")

    green_label = tk.Label(control_frame_1, text="Green", height=4)
    green_label.pack(side="left")
    minuteEntry_green = tk.Entry(control_frame_1, width=4, font=("Arial",12,""), textvariable=minute_green)
    minuteEntry_green.pack(side="left")

    yellow_label = tk.Label(control_frame_1, text="Yellow", height=4)
    yellow_label.pack(side="left")
    minuteEntry_yellow = tk.Entry(control_frame_1, width=4, font=("Arial",12,""), textvariable=minute_yellow)
    minuteEntry_yellow.pack(side="left")

    red_label = tk.Label(control_frame_1, text="Red", height=4)
    red_label.pack(side="left")
    minuteEntry_red = tk.Entry(control_frame_1, width=4, font=("Arial",12,""), textvariable=minute_red)
    minuteEntry_red.pack(side="left")

    flash_label = tk.Label(control_frame_1, text="Flash", height=4)
    flash_label.pack(side="left")
    minuteEntry_flash = tk.Entry(control_frame_1, width=4, font=("Arial",12,""), textvariable=minute_flash)
    minuteEntry_flash.pack(side="left")

    control_frame_1.pack(side="top")
    
    # Host Window - buttons
    control_frame_2 = tk.Frame(host_window)
    
    load_icons()
    play_button = ttk.Button(control_frame_2, image=play_icon, command=play)
    play_button.pack(side="left", padx=10)
    pause_button = ttk.Button(control_frame_2, image=pause_icon, command=pause)
    pause_button.pack(side="left", padx=10)
    reset_button = ttk.Button(control_frame_2, image=reset_icon, command=reset)
    reset_button.pack(side="left", padx=10)
    stop_button = ttk.Button(control_frame_2, image=stop_icon, command=stop)
    stop_button.pack(side="left", padx=10)
    
    spacer_label = tk.Label(control_frame_2, text=" | ", height=4)
    spacer_label.pack(side="left")
    
    plus_button = ttk.Button(control_frame_2, image=plus_icon, command=plus)
    plus_button.pack(side="left", padx=5)
    minuteEntry_shim = tk.Entry(control_frame_2, width=4, font=("Arial",12,""), textvariable=minute_shim)
    minuteEntry_shim.pack(side="left")
    minus_button = ttk.Button(control_frame_2, image=minus_icon, command=minus)
    minus_button.pack(side="left", padx=5)

    control_frame_2.pack(side="top")

    # Host Window - clock and progress bar
    lights_frame_host = tk.Frame(host_window)

    clock_display_host = tk.Label(host_window, textvariable=time_display, font=("Arial",30,""))
    clock_display_host.pack(side="left", padx=20)

    progress_host = ttk.Progressbar(host_window, style=ts[0] + ".gray.Horizontal.TProgressbar", orient="horizontal", length=200, mode="determinate", maximum=100, variable=progress)
    progress_host.pack(side="left", padx=20)

    lights_frame_host.pack(side="top")

    # Client Window
    client_window.attributes('-topmost',True)
    client_window.geometry("1880x1000")
    client_window.title("Presentation Timer: Client")
    client_window.config(bg=current_bg)

    # Client Window - clock and progress bar
    lights_frame_client = tk.Frame(client_window)

    clock_display_client = tk.Label(client_window, textvariable=time_display, font=("Arial",450,""))
    clock_display_client.pack(side="top", pady=10)

    progress_client = ttk.Progressbar(client_window, style=ts[1] + ".gray.Horizontal.TProgressbar", orient="horizontal", length=1850, mode="determinate", maximum=100, variable=progress)
    progress_client.pack(side="left", padx=20)

    lights_frame_client.pack(side="top")

    # Widget Window
    widget_window.attributes('-topmost',True)
    widget_window.config(bg="black")
    widget_window.geometry("300x50")
    widget_window.title("Presentation Timer: Widget")
    widget_window.overrideredirect(True)
    widget_window._offsetx = 0
    widget_window._offsety = 0
    widget_window.bind('<Button-1>', click_window)
    widget_window.bind('<B1-Motion>', drag_window)

    # Widget Window - progress bar
    progress_widget = ttk.Progressbar(widget_window, style=ts[2] + ".gray.Horizontal.TProgressbar", orient="horizontal", length=280, mode="determinate", maximum=100, variable=progress)
    progress_widget.pack(side="top", pady=10)


def pause():
    """Pause button event handler
    """
    global paused
    paused = True

def reset():
    """Reset button event handler
    """
    global time, minute_total, current_bg, current_fg, needs_reset
    time = timedelta(minutes=float(minute_total.get()))
    progress_host.config(style=ts[0] + ".gray.Horizontal.TProgressbar")
    progress_client.config(style=ts[1] + ".gray.Horizontal.TProgressbar")
    progress_widget.config(style=ts[2] + ".gray.Horizontal.TProgressbar")
    current_bg = bg[0]
    current_fg = fg[0]
    client_window.config(bg=current_bg)
    clock_display_client.config(fg=current_fg)
    needs_reset = False
    toc()

def stop():
    """Stop button event handler
    """
    pause()
    reset()

def play():
    """Play button event handler
    """
    global paused, tic_listener
    if needs_reset or not paused:
        paused = True
        reset()
    paused = False
    tic_listener = host_window.after(math.floor(interval.total_seconds() * 1000), tic)

def plus():
    """Increase remaining time.
    """
    global time
    time = time + timedelta(minutes=float(minute_shim.get()))
    toc()
    
def minus():
    """Reduce remaining time.
    """
    global time
    time = time - timedelta(minutes=float(minute_shim.get()))
    toc()

def tic():
    """Time tic event handler
    """
    global time, paused, tic_listener
    if not paused:
        tic_listener = host_window.after(math.floor(interval.total_seconds() * 1000), tic)
        time = time - interval
        toc()

def toc():
    """Updates display when event handlers require it
    """
    global time, time_display, progress, progress_host, progress_client, progress_widget, clock_display_client

    if time >= timedelta():
        mins, secs = divmod(time.total_seconds(), 60)
    else:
        mins, secs = divmod(time.total_seconds(), -60)
    time_display.set('{:02.0f}:{:02.0f}'.format(mins, secs))
    progress_ = 100 - (time / (timedelta(minutes=float(minute_total.get())))) * 100
    progress.set(max(min(progress_,100),0))
        
    if time <= timedelta(minutes=float(minute_flash.get())):
        toggle_bg()
        client_window.config(bg=current_bg)
        clock_display_client.config(fg=current_fg)
        progress_widget.config(style=ts[2] + "." + current_bar + ".Horizontal.TProgressbar")
    elif time <= timedelta(minutes=float(minute_red.get())):
        progress_host.config(style=ts[0] + ".red.Horizontal.TProgressbar")
        progress_client.config(style=ts[1] + ".red.Horizontal.TProgressbar")
        progress_widget.config(style=ts[2] + ".red.Horizontal.TProgressbar")
    elif time <= timedelta(minutes=float(minute_yellow.get())):
        progress_host.config(style=ts[0] + ".yellow.Horizontal.TProgressbar")
        progress_client.config(style=ts[1] + ".yellow.Horizontal.TProgressbar")
        progress_widget.config(style=ts[2] + ".yellow.Horizontal.TProgressbar")
    elif time <= timedelta(minutes=float(minute_green.get())):
        progress_host.config(style=ts[0] + ".green.Horizontal.TProgressbar")
        progress_client.config(style=ts[1] + ".green.Horizontal.TProgressbar")
        progress_widget.config(style=ts[2] + ".green.Horizontal.TProgressbar")
    else: 
        progress_host.config(style=ts[0] + ".gray.Horizontal.TProgressbar")
        progress_client.config(style=ts[1] + ".gray.Horizontal.TProgressbar")
        progress_widget.config(style=ts[2] + ".gray.Horizontal.TProgressbar")

def toggle_bg():
    """Flash background (toggle normal and inverted colors)
    """
    global current_bg, current_fg, current_bar
    if current_bg == "gray":
        current_bg = bg[1]
        current_fg = fg[1]
        current_bar = bar[1]
    else:
        current_bg = bg[0]
        current_fg = fg[0]
        current_bar = bar[0]

def drag_window(event):
    """Event handler for widget curser movements (while clicked).
    
    To allow widget to be moved around with click and curser movements. 

    :param event: TK Event
    :type event: TK Event
    """
    x = widget_window.winfo_pointerx() - widget_window._offsetx
    y = widget_window.winfo_pointery() - widget_window._offsety
    widget_window.geometry('+{x}+{y}'.format(x=x,y=y))

def click_window(event):
    """Event handler for widget curser clicks.
    
    To allow widget to be moved around with click and curser movements. 

    :param event: TK Event
    :type event: TK Event
    """
    widget_window._offsetx = event.x
    widget_window._offsety = event.y

def resource_path(relative_path: str) -> str:
    """Get path to file.

    Source: https://stackoverflow.com/questions/31836104/pyinstaller-and-onefile-how-to-include-an-image-in-the-exe-file

    :param relative_path: relative path to file
    :type relative_path: string
    :return: absolute path to file
    :rtype: string
    """
    try:
        base_path = sys._MEIPASS
    except Exception:
        base_path = os.path.abspath("Resources/")

    return os.path.join(base_path, relative_path)

def load_icons():
    """Loads the icons needed for buttons.
    """
    global play_icon, stop_icon, pause_icon, reset_icon, plus_icon, minus_icon
    play_icon = tk.PhotoImage(file=resource_path('play.png'), master=host_window)
    stop_icon = tk.PhotoImage(file=resource_path('stop.png'), master=host_window)
    pause_icon = tk.PhotoImage(file=resource_path('pause.png'), master=host_window)
    reset_icon = tk.PhotoImage(file=resource_path('reset.png'), master=host_window)
    plus_icon = tk.PhotoImage(file=resource_path('plus.png'), master=host_window)
    minus_icon = tk.PhotoImage(file=resource_path('minus.png'), master=host_window)

def mainloop():
    """Enter main TK GUI loop.
    
    Incase someone wants to run as an import and call main when ready. This way once the window is built you can adjust it before entering the main loop.
    """
    client_window.mainloop()
    host_window.mainloop()

if __name__ == "__main__":
    build_window()
    mainloop()
