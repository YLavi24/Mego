import tkinter as tk
from datetime import datetime
import math

# פונקציה להמרת שעה, דקות ושניות לפורמט המיוחד שלנו
def convert_to_custom_time(hour, minute, second, microsecond):
    # חישוב השעה מתוך 24 שעות
    custom_hour = hour
    
    # חישוב החלק מתוך 1080 חלקים בשעה
    total_seconds = hour * 3600 + minute * 60 + second + microsecond / 1_000_000
    custom_part = (total_seconds % 3600) * 1080 // 3600
    
    # חישוב הרגע מתוך 76 רגעים בחלק
    seconds_in_part = ((total_seconds % 3600) * 1080 % 3600) / 3600 * 76
    
    return custom_hour, int(custom_part), seconds_in_part

# פונקציה לציור המחוגים של השעון
def draw_clock(custom_hour, custom_part, custom_moment):
    canvas.delete("hands")
    
    # חישוב זוויות המחוגים
    hour_angle = 360 * custom_hour / 24 - 90
    part_angle = 360 * custom_part / 1080 - 90
    moment_angle = 360 * custom_moment / 76 - 90
    
    # ציור מחוג השעות
    hour_x = clock_center_x + clock_radius * 0.5 * math.cos(math.radians(hour_angle))
    hour_y = clock_center_y + clock_radius * 0.5 * math.sin(math.radians(hour_angle))
    canvas.create_line(clock_center_x, clock_center_y, hour_x, hour_y, fill="black", width=6, tag="hands")
    
    # ציור מחוג החלקים
    part_x = clock_center_x + clock_radius * 0.6 * math.cos(math.radians(part_angle))
    part_y = clock_center_y + clock_radius * 0.6 * math.sin(math.radians(part_angle))
    canvas.create_line(clock_center_x, clock_center_y, part_x, part_y, fill="blue", width=4, tag="hands")
    
    # ציור מחוג הרגעים
    moment_x = clock_center_x + clock_radius * 0.9 * math.cos(math.radians(moment_angle))
    moment_y = clock_center_y + clock_radius * 0.9 * math.sin(math.radians(moment_angle))
    canvas.create_line(clock_center_x, clock_center_y, moment_x, moment_y, fill="red", width=2, tag="hands")

# פונקציה לעדכון הזמן ולהצגת השעון
def update_clock():
    now = datetime.now()
    hour, minute, second, microsecond = now.hour, now.minute, now.second, now.microsecond
    custom_hour, custom_part, custom_moment = convert_to_custom_time(hour, minute, second, microsecond)
    
    # עדכון השעון הדיגיטלי
    custom_part_str = str(custom_part).zfill(4) if custom_part >= 1000 else str(custom_part).zfill(3)
    digital_clock.config(text=f"{custom_hour:02}:{custom_part_str}:{int(custom_moment):02}", fg="black")
    
    draw_clock(custom_hour, custom_part, custom_moment)
    
    # עדכון צבע השעות על השעון
    for i in range(24):
        color = "red" if i == custom_hour else "black"
        canvas.itemconfig(hour_texts[i], fill=color)
    
    # עדכון צבע החלקים על השעון
    for i, text_id in enumerate(part_texts):
        color = "red" if i * 30 <= custom_part < (i + 1) * 30 else "blue"
        canvas.itemconfig(text_id, fill=color)

    
    window.after(1, update_clock)  # עדכון השעון כל מילישנייה לתנועה חלקה

# יצירת חלון tkinter
window = tk.Tk()
window.title("Custom Clock")

# יצירת קנבס לשעון
clock_radius = 200
clock_center_x = clock_radius + 20
clock_center_y = clock_radius + 20

canvas = tk.Canvas(window, width=2 * clock_center_x, height=2 * clock_center_y, bg="white")
canvas.pack()

# יצירת תווית לשעון הדיגיטלי
digital_clock = tk.Label(window, font=("Helvetica", 16), bg="white", fg="blue")
digital_clock.pack()

# ציור סימוני השעות על השעון
hour_texts = []
for i in range(24):
    angle = 360 * i / 24 - 90
    x = clock_center_x + clock_radius * 0.9 * math.cos(math.radians(angle))
    y = clock_center_y + clock_radius * 0.9 * math.sin(math.radians(angle))
    text = canvas.create_text(x, y, text=str(i), font=("Helvetica", 12))
    hour_texts.append(text)

# ציור סימוני החלקים על השעון
part_texts = []
for i in range(0, 1080, 30):  # מציג כל 30 חלקים
    angle = 360 * i / 1080 - 90
    x = clock_center_x + clock_radius * 0.75 * math.cos(math.radians(angle))
    y = clock_center_y + clock_radius * 0.75 * math.sin(math.radians(angle))
    text = canvas.create_text(x, y, text=str(i), font=("Helvetica", 8), fill="blue")
    part_texts.append(text)

# ציור סימוני הרגעים על השעון
moment_texts = []
for i in range(0, 76, 2):  # מציג כל 2 רגעים
    angle = 360 * i / 76 - 90
    x = clock_center_x + clock_radius * 0.6 * math.cos(math.radians(angle))
    y = clock_center_y + clock_radius * 0.6 * math.sin(math.radians(angle))
    text = canvas.create_text(x, y, text=str(i), font=("Helvetica", 8), fill="red")
    moment_texts.append(text)

# קריאה לפונקציה לעדכון השעון בפעם הראשונה
update_clock()

# הרצת חלון tkinter
window.mainloop()
