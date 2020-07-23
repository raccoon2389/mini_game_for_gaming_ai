import numpy as np # 배열 라이브러리
from PIL import ImageGrab # 스크린 캡처 라이브러리
from keras.models import load_model
import cv2
import keyboard
import matplotlib.pyplot as plt
import pyautogui
import time

model = load_model('./B_model/--88--0.0191.hdf5')
while (keyboard.is_pressed('esc')==0): # 무한 반복
    screen = ImageGrab.grab().resize(((150,112))) # 스크린을 캡쳐하여 변수에 저장
    screen1 = np.array(screen) # 이미지를 배열로 변환
    cv2.imshow("game",cv2.cvtColor(screen1, cv2.COLOR_BGR2RGB))
    # cv2.waitKey(0)
    # cv2.destroyAllWindows() 
    # b, g, r = cv2.split(screen1)
    # im2 =cv2.merge([r,g,b])

    # plt.imshow(im2)
    # plt.show()

    
    x = np.asarray(screen).reshape(1,112,150,3) # 이미지를 배열로 변환
    out = model.predict(x/255.)
    command = out.argmax()+1
    print(command) 
    key_new = 5
    if key_new != command:
        pyautogui.keyUp('down')
        pyautogui.keyUp('left')
        pyautogui.keyUp('right')
        pyautogui.keyUp('up')
    
        key_new = command
        if(command == 1):
            
            pyautogui.keyDown('down')
            pyautogui.keyDown('left')

        if(command == 2):
            pyautogui.keyDown('down')
        
        if(command == 3):
            pyautogui.keyDown('down')
            pyautogui.keyDown('right')
        
        if(command == 4):
            pyautogui.keyDown('left')
        
        if(command == 6):
            pyautogui.keyDown('right')
        if(command == 7):
            pyautogui.keyDown('left')
            pyautogui.keyDown('up')
        if(command == 8):
            pyautogui.keyDown('up')
        if(command == 9):
            pyautogui.keyDown('up')
            pyautogui.keyDown('right')
        if(command == 5):
            pyautogui.press('space')

    if(command == 5):
        pyautogui.press('space')

    