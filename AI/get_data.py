import numpy as np
from PIL import Image

train = np.zeros((4500,150,112,3))
i=0
for f in [1,2,3,4,5,6,7,8,9]:
    for d in range(500):
        img = Image.open(f"Traindata/{f}/{d}.png").resize(((112,150)))
        data = np.asarray(img)/255.
        train[i] = data
        i +=1
        print(i)
np.save("train.npy",train)