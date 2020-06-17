import numpy as np
from PIL import Image
import matplotlib.pyplot as plt
train = np.zeros((4500,112,150,3))
i=0
for f in [1,2,3,4,5,6,7,8,9]:
    for d in range(500):
        img = Image.open(f"Traindata/{f}/{d}.png").resize(((150,112)))
        # img2 = np.asarray(img)
        # plt.imshow(img2)
        # plt.show()
        data = np.asarray(img)/255.
        train[i] = data
        i +=1
        print(i)
np.save("train.npy",train)