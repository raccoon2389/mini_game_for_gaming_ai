import numpy as np
from keras.models import Sequential,load_model
from keras.layers import Dense, Conv2D,MaxPooling2D,Dropout,Flatten
from keras.utils import np_utils
from keras.wrappers.scikit_learn import KerasClassifier
from keras.callbacks import ModelCheckpoint
from sklearn.model_selection import KFold,cross_val_score,train_test_split
import matplotlib.image as Image
import PIL.Image as Image
m_check = ModelCheckpoint("model/--{epoch:02d}--{val_loss:.4f}.hdf5", monitor = 'val_loss',save_best_only=True)



# y = np.zeros((4500,))
# c = 0
# d = 0
# for i in [1,2,3,4,5,6,7,8,9]:
#     for _ in range(500):
#         y[c]=d
#         c += 1
#     d +=1
# np.save("y.npy",y)


x = np.load("train.npy")
print(x[0])

y = np.load("y.npy")
predx = Image.open("495.png").resize(((150,112)))
predx= np.asarray(predx).reshape(1,112,150,3)

y = np_utils.to_categorical(y)
def create_model():
    model = Sequential()
    model.add(Conv2D(200,(3,3),padding='same',activation='relu',input_shape=(112,150,3)))
    model.add(Dropout(0.3))
    model.add(MaxPooling2D(2,2))
    model.add(Conv2D(200,(3,3),padding='same',activation='relu'))
    model.add(Dropout(0.3))
    model.add(MaxPooling2D(2,2))
    model.add(Conv2D(100,(3,3),padding='same',activation='relu'))
    model.add(Dropout(0.3))
    model.add(MaxPooling2D(2,2))
    model.add(Conv2D(100,(3,3),padding='same',activation='relu'))
    model.add(Dropout(0.3))
    model.add(MaxPooling2D(2,2))
    model.add(Conv2D(100,(2,2),padding='same',activation='relu'))
    model.add(Dropout(0.3))
    model.add(MaxPooling2D(2,2))
    model.add(Conv2D(100,(2,2),padding='same',activation='relu'))
    model.add(Dropout(0.3))
    model.add(MaxPooling2D(2,2))

    model.add(Flatten())
    model.add(Dense(500,activation="relu"))
    model.add(Dropout(0.3))
    model.add(Dense(100,activation="relu"))
    model.add(Dropout(0.3))
    model.add(Dense(100,activation="relu"))
    model.add(Dropout(0.3))
    model.add(Dense(100,activation="relu"))
    model.add(Dropout(0.3))

    model.add(Dense(100,activation="relu"))
    model.add(Dropout(0.3))

    model.add(Dense(9,activation="softmax"))

    model.compile(optimizer="adam",loss="categorical_crossentropy",metrics=['acc'])

    return model

seed = np.random.seed(7)

kf = KFold(n_splits=3, shuffle=True,random_state=seed)

x_train,x_test , y_train,y_test = train_test_split(x,y,shuffle=True , random_state=seed)
# model = load_model('./model/--100--0.0354.hdf5')
model = create_model()
# for train_i,test_i in kf.split(x):
#     train_x,train_y = x[train_i],y[train_i]
#     test_x, test_y = x[test_i], y[test_i]

#     model.fit(train_x,train_y,batch_size=30,epochs=100,validation_split=0.25,callbacks=[m_check])
#     score = model.evaluate(test_x,test_y)
#     print(score)
model.fit(x_train,y_train,batch_size=30,epochs=100,callbacks=[m_check],validation_data=[(x_val,y_val)])

model.fit(x_train,y_train,batch_size=30,epochs=100,validation_split=0.25,callbacks=[m_check])
# 
predy = model.evaluate(x_test,y_test)
print(predy)
