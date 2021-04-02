import pyautogui
import time
import myFunc as mf

pyautogui.hotkey('win', 'r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')
time.sleep(1)

window = pyautogui.getWindowsWithTitle('제목 없음 - 그림판')[0]
window.maximize()
box = pyautogui.locateOnScreen('font.png')
pyautogui.click(box)
pyautogui.move(0, 200, duration=2)
pyautogui.click()
time.sleep(1)

mf.han_write('집가고싶다')
time.sleep(1)

window.close()
time.sleep(1)

pyautogui.hotkey('n')
