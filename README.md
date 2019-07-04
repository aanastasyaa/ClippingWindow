# ClippingWindow (WinForms, C#)
Приложение решает следующую задачу: **определяет находится ли отрезок в прямоугольном окне или касается его границ, пересекает частично**.

Отрезки задает пользователь, щелкая левой кнопкой мыши по области рисования. 
Положение прямоугольного окна можно менять с помощью полей ввода на форме. 

В основе приложения паттерн MVP. 

Классы в папке *Models* представляют собой три модели **IClippingWindow**, **Point**, **RectangularClippingWindow**, 
которые представляют объекты предметной области.

Класс **MainViewPresenter** - *Presenter*, в котором находится бизнес-логика приложения 
(проверка отрезков на пересечение с окном, добавление новых точек).

Класс **IMainView** - интерфейс представления. 
**MainViewPresenter** взаимодействует с классом формы, которая реализует интерфейс **IMainView**.
**Form1** - класс главной и единственной формы приложения, *View*.

    
