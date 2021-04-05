import pyautogui
import time
import pyperclip

time.sleep(2)

pyautogui.hotkey('win', 'r')
pyautogui.write('notepad')
pyautogui.hotkey('enter')

pyautogui.write("12345")
pyautogui.write(" a b c d e ", interval=0.1)

pyperclip.copy("코코딩딩") # ctrl + c
pyautogui.hotkey('ctrl', 'v')

# moveTo mouseDown mouseUp locateOnScreen click

'''
    pyautogui 클릭, 마우스 조작, 키보드 조작 라이브러리
    Pillow 이미지 사용 라이브러리

    matplotlb 그래프 사용 라이브러리
    numpy 데이터 사용 라이브러리
'''

#12345 a b c d e 코코딩딩