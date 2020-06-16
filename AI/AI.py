import numpy as np # 배열 라이브러리
from PIL import ImageGrab # 스크린 캡처 라이브러리
from keras.models import load_model
import cv2

model = load_model('./model/--17--0.0117.hdf5')
while (True): # 무한 반복
    screen = ImageGrab.grab().resize(((112,150))) # 스크린을 캡쳐하여 변수에 저장
    x = np.asarray(screen).reshape(1,150,112,3)/255. # 이미지를 배열로 변환
    out = model.predict(x)
    cv2.imshow("game",cv2.cvtColor(x, cv2.COLOR_BGR2RGB))
    print(out.argmax()+1) 