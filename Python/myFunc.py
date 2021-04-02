import pyautogui
import time
import pyperclip

start = time.time()
print('start : ', start)
def find_target(file_name, timeout=10):
    while True:
        time.sleep(1)
        end = time.time()
        
        file_a = pyautogui.locateOnScreen(file_name)
        if file_a is not None : 
            return file_a
        
        if (end - start) > timeout :
            print(timeout,"초 지남")
            break

def doA():
    for i in range(0,5):
        print("i : ", i)

def han_write(text):
    pyperclip.copy(text) # ctrl + c
    pyautogui.hotkey('ctrl', 'v')
        