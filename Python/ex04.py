import pyautogui
import time

start = time.time()
print('start : ', start)

def find_target(file_name, timeout=10):
    while True:
        time.sleep(1)
        end = time.time()
        # print('end : ', end)
        
        file_a = pyautogui.locateOnScreen(file_name)
        # print(file_a)
        if file_a is not None : 
            # print("찾음")
            # pyautogui.click(file_a)
            return file_a
        
        if (end - start) > timeout :
            print(timeout,"초 지남")
            break

box = find_target('a.png', 3)
pyautogui.click(box)

# file_a = pyautogui.locateOnScreen("a.png")
# print(file_a)
# pyautogui.click(file_a, duration=2)
