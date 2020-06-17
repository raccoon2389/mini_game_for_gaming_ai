import numpy as np # 배열 라이브러리
from PIL import ImageGrab # 스크린 캡처 라이브러리
from keras.models import load_model
import cv2
import keyboard
import matplotlib.pyplot as plt

# import pyautogui

model = load_model('./model/--100--0.0354.hdf5')
while (keyboard.is_pressed('esc')==0): # 무한 반복
    screen = ImageGrab.grab().resize(((150,112))) # 스크린을 캡쳐하여 변수에 저장
    screen1 = np.array(screen) # 이미지를 배열로 변환
    cv2.imshow("game",cv2.cvtColor(screen1, cv2.COLOR_BGR2RGB))

    # b, g, r = cv2.split(screen1)
    # im2 =cv2.merge([r,g,b])

    # plt.imshow(im2)
    # plt.show()


    x = np.asarray(screen).reshape(1,112,150,3) # 이미지를 배열로 변환
    out = model.predict(x/255.)
    command = out.argmax()+1
    print(command) 
    # if(command == 1|2|3):
    #     pyautogui.press('down',10,0.1)
    
    # if(command == 3|6|9):
    #     pyautogui.press('right')
    
    # if(command == 7|8|9):
    #     pyautogui.press('up')
    
    # if(command == 1|4|7):
    #     pyautogui.press('left')
