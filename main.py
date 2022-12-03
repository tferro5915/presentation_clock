
import tkinter as tk
from tkinter import ttk

bg = ["gray", "black"]
current_bg = bg[0]
fg = ["black", "gray"]
current_fg = fg[0]
bar = ['red', 'black']
current_bar = bar[0]

host_window = tk.Tk()
host_window.attributes('-topmost',True)

client_window = tk.Toplevel()
client_window.config(bg=current_bg)
client_window.attributes('-topmost',True)

widget_window = tk.Toplevel()
widget_window.config(bg="black")
widget_window.attributes('-topmost',True)

minute_total = tk.DoubleVar(host_window, value="00")
minute_green = tk.StringVar(host_window, value="00")
minute_yellow = tk.StringVar(host_window, value="00")
minute_red = tk.StringVar(host_window, value="00")
minute_flash = tk.StringVar(host_window, value="00")

time = tk.DoubleVar(host_window, value=0)
time_display = tk.StringVar(host_window, value="00:00")

paused = tk.BooleanVar(host_window, value=True)
progress = tk.DoubleVar(host_window, value=0)
    
play_icon = tk.PhotoImage(file='play.png')
stop_icon = tk.PhotoImage(file='stop.png')
pause_icon = tk.PhotoImage(file='pause.png')
reset_icon = tk.PhotoImage(file='reset.png')

hold_after = None

s = ttk.Style()
s.theme_use("default")
colors = ['green', 'yellow', 'red', 'gray', 'black']
thicknesses = [20, 200, 30]
ts = [str(x) for x in thicknesses]
for c in colors:
    for t in thicknesses:
        s.configure(str(t) + "." + c + ".Horizontal.TProgressbar", foreground=c, background=c, thickness=t)


def main():
    global minute_total, minute_green, minute_yellow, minute_red, minute_flash, progress_host, progress_client, progress_widget, clock_display_client
    
    host_window.geometry("400x200")
    host_window.title("Presentation Timer: Host")
    
    client_window.geometry("1880x1000")
    client_window.title("Presentation Timer: Client")
    
    widget_window.geometry("300x50")
    widget_window.title("Presentation Timer: Widget")
    widget_window.overrideredirect(True)
    widget_window._offsetx = 0
    widget_window._offsety = 0
    widget_window.bind('<Button-1>', clickwin)
    widget_window.bind('<B1-Motion>', dragwin)
    
    control_frame_1 = tk.Frame(host_window)
    
    total_label = tk.Label(control_frame_1, text="Total", height=4)
    total_label.pack(side="left")
    minuteEntry_total = tk.Entry(control_frame_1, width=3, font=("Arial",18,""), textvariable=minute_total)
    minuteEntry_total.pack(side="left")
    
    green_label = tk.Label(control_frame_1, text="Green", height=4)
    green_label.pack(side="left")
    minuteEntry_green = tk.Entry(control_frame_1, width=3, font=("Arial",18,""), textvariable=minute_green)
    minuteEntry_green.pack(side="left")
    
    yellow_label = tk.Label(control_frame_1, text="Yellow", height=4)
    yellow_label.pack(side="left")
    minuteEntry_yellow = tk.Entry(control_frame_1, width=3, font=("Arial",18,""), textvariable=minute_yellow)
    minuteEntry_yellow.pack(side="left")
    
    red_label = tk.Label(control_frame_1, text="Red", height=4)
    red_label.pack(side="left")
    minuteEntry_red = tk.Entry(control_frame_1, width=3, font=("Arial",18,""), textvariable=minute_red)
    minuteEntry_red.pack(side="left")
    
    flash_label = tk.Label(control_frame_1, text="Flash", height=4)
    flash_label.pack(side="left")
    minuteEntry_flash = tk.Entry(control_frame_1, width=3, font=("Arial",18,""), textvariable=minute_flash)
    minuteEntry_flash.pack(side="left")
    
    control_frame_1.pack(side="top")
    control_frame_2 = tk.Frame(host_window)
    
    play_button = ttk.Button(control_frame_2, image=play_icon, command=play)
    play_button.pack(side="left", padx=20)
    pause_button = ttk.Button(control_frame_2, image=pause_icon, command=pause)
    pause_button.pack(side="left", padx=20)
    reset_button = ttk.Button(control_frame_2, image=reset_icon, command=reset)
    reset_button.pack(side="left", padx=20)
    stop_button = ttk.Button(control_frame_2, image=stop_icon, command=stop)
    stop_button.pack(side="left", padx=20)
    
    control_frame_2.pack(side="top")
    
    
    lights_frame_host = tk.Frame(host_window)
    
    clock_display_host = tk.Label(host_window, textvariable=time_display, font=("Arial",30,""))
    clock_display_host.pack(side="left", padx=20)
    
    progress_host = ttk.Progressbar(host_window, style=ts[0] + ".gray.Horizontal.TProgressbar", orient="horizontal", length=200, mode="determinate", maximum=100, variable=progress)
    progress_host.pack(side="left", padx=20)
    
    lights_frame_host.pack(side="top")
    
    lights_frame_client = tk.Frame(client_window)
    
    
    clock_display_client = tk.Label(client_window, textvariable=time_display, font=("Arial",450,""))
    clock_display_client.pack(side="top", pady=10)
    
    progress_client = ttk.Progressbar(client_window, style=ts[1] + ".gray.Horizontal.TProgressbar", orient="horizontal", length=1850, mode="determinate", maximum=100, variable=progress)
    progress_client.pack(side="left", padx=20)
    
    lights_frame_client.pack(side="top")
    
    progress_widget = ttk.Progressbar(widget_window, style=ts[2] + ".gray.Horizontal.TProgressbar", orient="horizontal", length=280, mode="determinate", maximum=100, variable=progress)
    progress_widget.pack(side="top", pady=10)
    
    
def pause():
    global paused
    paused.set(True)
    
def reset():
    global time, minute_total, current_bg, current_fg
    if hold_after is not None:
        host_window.after_cancel(hold_after)
    time.set(float(minute_total.get()) * 60)
    progress_host.config(style=ts[0] + ".gray.Horizontal.TProgressbar")
    progress_client.config(style=ts[1] + ".gray.Horizontal.TProgressbar")
    progress_widget.config(style=ts[2] + ".gray.Horizontal.TProgressbar")
    current_bg = bg[0]
    current_fg = fg[0]
    client_window.config(bg=current_bg)
    clock_display_client.config(fg=current_fg)
    update_display()
    
def stop():
    pause()
    reset()

def play():
    global paused, hold_after
    if time.get() <= 0 or not paused.get():
        paused.set(True)
        reset()
    paused.set(False)
    hold_after = host_window.after(1000, tick)
    
def tick():
    global time, time_display, paused, hold_after
    if not paused.get():
        hold_after = host_window.after(1000, tick)
        time.set(time.get() - 1)
        update_display()

def update_display():
    global time, time_display, progress, progress_host, progress_client, progress_widget, clock_display_client
    
    if time.get() >= 0:
        mins, secs = divmod(time.get(), 60)
        time_display.set('{:02.0f}:{:02.0f}'.format(mins, secs))
        
        progress.set(100 - (time.get() / (minute_total.get() * 60)) * 100)
        if time.get() < float(minute_red.get()) * 60:
            progress_host.config(style=ts[0] + ".red.Horizontal.TProgressbar")
            progress_client.config(style=ts[1] + ".red.Horizontal.TProgressbar")
            progress_widget.config(style=ts[2] + ".red.Horizontal.TProgressbar")
        elif time.get() < float(minute_yellow.get()) * 60:
            progress_host.config(style=ts[0] + ".yellow.Horizontal.TProgressbar")
            progress_client.config(style=ts[1] + ".yellow.Horizontal.TProgressbar")
            progress_widget.config(style=ts[2] + ".yellow.Horizontal.TProgressbar")
        elif time.get() < float(minute_green.get()) * 60:
            progress_host.config(style=ts[0] + ".green.Horizontal.TProgressbar")
            progress_client.config(style=ts[1] + ".green.Horizontal.TProgressbar")
            progress_widget.config(style=ts[2] + ".green.Horizontal.TProgressbar")
        else: 
            progress_host.config(style=ts[0] + ".gray.Horizontal.TProgressbar")
            progress_client.config(style=ts[1] + ".gray.Horizontal.TProgressbar")
            progress_widget.config(style=ts[2] + ".gray.Horizontal.TProgressbar")
    else:
        mins, secs = divmod(-time.get(), 60)
        time_display.set('-{:02.0f}:{:02.0f}'.format(mins, secs))
        
        progress.set(100)
        progress_host.config(style=ts[0] + ".red.Horizontal.TProgressbar")
        progress_client.config(style=ts[1] + ".red.Horizontal.TProgressbar")
        progress_widget.config(style=ts[2] + ".red.Horizontal.TProgressbar")
        
    if time.get() < float(minute_flash.get()) * 60:
        toggle_bg()
        client_window.config(bg=current_bg)
        clock_display_client.config(fg=current_fg)
        progress_widget.config(style=ts[2] + "." + current_bar + ".Horizontal.TProgressbar")

def toggle_bg():
    global current_bg, current_fg, current_bar
    if current_bg == "gray":
        current_bg = bg[1]
        current_fg = fg[1]
        current_bar = bar[1]
    else:
        current_bg = bg[0]
        current_fg = fg[0]
        current_bar = bar[0]

def dragwin(event):
    x = widget_window.winfo_pointerx() - widget_window._offsetx
    y = widget_window.winfo_pointery() - widget_window._offsety
    widget_window.geometry('+{x}+{y}'.format(x=x,y=y))
    
def clickwin(event):
    widget_window._offsetx = event.x
    widget_window._offsety = event.y

if __name__ == "__main__":
    main()
    client_window.mainloop()
    host_window.mainloop()
