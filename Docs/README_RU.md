# Extensions 
Extensions - это методы расширения многих типов данных в Unity, что существенно упрощает решение повседневных задач при создании игр.

## Настройка
Для работы с расширениями просто подключите пространство имен `Redcode.Extenesions` в своем коде.

```c#
using Redcode.Extensions;
```

В некоторых случаях в окончании названий методов в этой документации будут символы `XX`, `XXX` или `XXXX`, это означает, что вместо них можно подставлять любую комбинацию [X, Y, Z, W] (в случае векторов) или [R, G, B, A] (в случае цветов).

Пример:
```c#
color.WithG(1f); // изменяет цвет канала G на 1f и возвращает результат как копию.
color.WithRB(0.5f, 1f) // изменяет цвет канала R на 0.5f и B на 1f и возвращает результат как копию.
vector.GetXZ(); // Извлекает X и Z компоненты из вектора им возвращает их как Vector2 объект.
```

## Float и Double
`Remap` - переназначает число из начального диапазона в число конечного диапазона.
```c#
var x = 0.5f;
var remapedX = x.Remap(0f, 1f, 4f, 6f);
```

Переменная `RemapedX` будет равна `5f`.

`Approximately` - выполняет приблизительное сравнение двух чисел с плавающей точкой.
```c#
var x = 0.3333333;
var result = x.Approximately(1f / 3f);
```

## Color и Color32
`With` и `WithXXX` - заменяет значения в указанных каналах цвета и возвращает результат как копию. Имеет 3 перегрузки.
```c#
var gray = Color.black.With(0, 0.5f, 1, 0.75f, 2, 1f); // R = 0.5f, G = 0.75f, B = 1f.

var green = Color.black.WithG(1f);
var pink = Color.black.WithRB(1f, 1f);
var yellow = Color.black.WithRGA(1f, 1f, 0f); // A - альфа канал цвета
```

## Graphic
`SetColorXXX` - устанавливает значение в выбранные каналы цвета свойства Graphic.color.
```c#
image.SetColorR(1f);
image.SetColorGB(1f, 1f);
image.SetColorRBA(0f, 0f, 0f);
```
> Класс `Image` наследован от класса `Graphic`, поэтому он также как и `Graphic` имеет эти методы.

## IComparable
`IsBetween` - проверяет находится-ли объект между двумя другими. Также принимает два дополнительных параметра - булевы значения указывающие нужно ли выполнять проверку включительно или исключительно.
```c#
var x = 1;
var result1 = x.IsBetween(0, 2);                // исключительно
var result2 = x.IsBetween(0, 1, true, true);    // включительно с двух сторон
```

## IEnumerable
`GetRandomElement` - возвращает произвольный элемент последовательности.
```c#
var list = new List<int>() { 1, 2, 3, 4, 5 };
var element = list.GetRandomElement();
```

`Except` - возвращает копию последовательности с исключенным элементом.
```c#
var list = new List<int>() { 1, 2, 3, 4, 5 };
list.Except(3); // [ 1, 2, 4, 5 ]
```

`Shuffled` - возвращает перемешанную копию последовательности.
```c#
var list = new List<int>() { 1, 2, 3, 4, 5 };
var shuffled = list.Shuffled();
```

`AsString` - возвращает строку представляющую элементы последовательности разделенных запятыми и в квадратных скобках.
```c#
var list = new List<int>() { 1, 2, 3, 4, 5 };
print(list.AsString());
```

## IEquatable
`EqualsToAll` - сравнивает текущий объект с переданными в метод, возвращает `true` если для всех них метод `Object.Equals` вернул истину. Передаваемые в метод объекты должны иметь такой же тип как и оригинал.
```c#
int x, y, z;
x = y = z = 1;

var result = x.EqualsToAll(y, z);
```

`EqualsToAny` - сравнивает текущий объект с переданными в метод, возвращает `true` если для хотя-бы одного из них метод `Object.Equals` вернул истину.  Передаваемые в метод объекты должны иметь такой же тип как и оригинал.
```c#
int x = 1;
int y = 1;
int z = 2;

var result = x.EqualsToAny(y, z);
```

## IList
`Pop` - удаляет указанный по индекс элементу из списка и возвращает его.
```c#
var list = new List<int>() { 1, 2, 3, 4, 5 };
var element = list.Pop(2);
```

`PopRandom` - удаляет произвольный элемент из списка и возвращает его.
```c#
var list = new List<int>() { 1, 2, 3, 4, 5 };
var element = list.PopRandom();
```

## System.Object
`EqualsToAll` - сравнивает текущий объект с переданными в метод, возвращает `true` если для всех них метод `Object.Equals` вернул истину.
```c#
int x, y, z;
x = y = z = 1;

var result = x.EqualsToAll(y, z);
```

`EqualsToAny` - сравнивает текущий объект с переданными в метод, возвращает `true` если для хотя-бы одного из них метод `Object.Equals` вернул истину.
```c#
int x = 1;
int y = 1;
int z = 2;

var result = x.EqualsToAny(y, z);
```

## Quaternion
`With` и `WithXXX` - заменяет значения в указанных осях кватерниона и возвращает результат как копию. Имеет 3 перегрузки. Работает напрямую со значениями `X`, `Y`, `Z`, `W` кватерниона (не Эйлеровы углы).

```c#
transform.rotation.With(0, 4f, 2, 8f, 3, -32);

transform.rotation.WithX(8f);
transform.rotation.WithYW(32f, -16f);
transform.rotation.WithXZW(4f, 8f, -32);
```

# Rect
`WithCenter` - устанавливает центр прямоугольника.

`WithPosition` - устанавливает позицию прямоугольника.

`WithHeight` - устанавливает высоту прямоугольника.

`WithWidth` - устанавливает ширину прямоугольника.

`WithMax` - устанавливает максимальную точку прямоугольника.

`WithMin` - устанавливает минимальную точку прямоугольника.

`WithSize` - устанавливает размер прямоугольника.

`WithX` - устанавливает позицию X прямоугольника.

`WithY` - устанавливает позициб Y прямоугольника.

`WithXMin` - устанавливает минимульную позицию X прямоугольника.

`WithYMin` - устанавливает минимальную позициб Y прямоугольника.

`WithXMax` - устанавливает максимальную позицию X прямоугольника.

`WithYMax` - устанавливает максимальную позициб Y прямоугольника.

Пример:
```c#
rect = rect.WithSize(Vector2.one).WithX(4f);
```

## RectTransform
`SetSizeDeltaX` и `SetSizeDeltaY` - устанавливает одно из значений свойства `RectTransform.sizeDelta` в указанное значение.
```c#
rectTransform.SetSizeDeltaX(100f);
rectTransform.SetSizeDeltaY(200f);
```

`SetAnchorMinX` и `SetAnchorMinY` - устанавливает одно из значений свойства `RectTransform.anchorMin` в указанное значение.
```c#
rectTransform.SetAnchorMinX(100f);
rectTransform.SetAnchorMinY(200f);
```

`SetAnchorMaxX` и `SetAnchorMaxY` - устанавливает одно из значений свойства `RectTransform.anchorMax` в указанное значение.
```c#
rectTransform.SetAnchorMaxX(200f);
rectTransform.SetAnchorMaxY(400f);
```

`SetAnchoredPositionX` и `SetAnchoredPositionY` - устанавливает одно из значений свойства `RectTransform.anchoredPosition` в указанное значение.
```c#
rectTransform.SetAnchoredPositionX(100f);
rectTransform.SetAnchoredPositionY(100f);
```

`SetAnchoredPosition3DX` и `SetAnchoredPosition3DXX` - устанавливает выбранное значение свойства `RectTransform.anchoredPosition3D` в указанное значение.
```c#
rectTransform.SetAnchoredPosition3DX(50f);
rectTransform.SetAnchoredPosition3DZ(0f);
rectTransform.SetAnchoredPosition3DXY(10f, 20f);
```

`SetPivotX` и `SetPivotY` - устанавливает одно из значений свойства `RectTransform.pivot` в указанное значение, со смещением элемента.
```c#
rectTransform.SetPivotX(100f);
rectTransform.SetPivotY(100f);
```

`SetPivotOnly`, `SetPivotOnlyX` и `SetPivotOnlyY` - устанавливает одно из значений свойства `RectTransform.pivot` в указанное значение, элемент остается на месте.
```c#
rectTransform.SetPivotOnlyX(100f);
rectTransform.SetPivotOnlyY(200f);
rectTransform.SetPivotOnly(100f, 200f);
```

`GetSize` - вычисляет и возвращает реальный размер элемента.
```c#
var size = rectTransform.GetSize();
```

## Scene
`FindObjectsOfType` - находит все объекты (включая не активные) в сцене с указанным компонентом.
```c#
var transforms = SceneManager.GetActiveScene().FindObjectsOfType<Transform>();
```

## SceneManager
Данный класс является вспомогательным и не хранит методов расширения.

`FindObjectsOfTypeInActiveScene` - находит все объекты (включая не активные) в активной сцене с указанным компонентом.
```c#
var transforms = SceneManagerExtensions.FindObjectsOfTypeInActiveScene<Transform>();
```

`FindObjectsOfTypeInOpenScenes` - находит все объекты (включая не активные) с указанным компонентом во всех открытых сценах.
```c#
var transforms = SceneManagerExtensions.FindObjectsOfTypeInOpenScenes<Transform>();
```

## Transform
`SetPositionX` и `SetPositionXX` - устанавливают глобальную позицию объекта по выбранной оси.
```c#
transform.SetPositionX(1f);
transform.SetPositionYZ(2f, 3f);
```

`SetLocalPositionX` и `SetLocalPositionXX` - устанавливают локальную позицию объекта по выбранной оси.
```c#
transform.SetLocalPositionX(1f);
transform.SetLocalPPositionYZ(2f, 3f);
```

`SetEulerAnglesX` и `SetEulerAnglesXX` - устанавливают глобальный поворот объекта по выбранной оси.
```c#
transform.SetEulerAnglesX(45f);
transform.SetEulerAnglesYZ(0f, 90f);
```

`SetLocalEulerAnglesX` и `SetLocalEulerAnglesXX` - устанавливают локальный поворот объекта по выбранной оси. 
```c#
transform.SetLocalEulerAnglesX(45f);
transform.SetLocalEulerAnglesYZ(0f, 90f);
```

`SetLocalScaleX` и `SetLocalScaleXX` - устанавливают локальный масштаб объекта по выбранной оси.
```c#
transform.SetLocalScaleX(2f);
transform.SetLocalScaleXZ(2f, 3f);
```

`SetAsPreviousSibling` и `SetAsNextSibling` - смещает назад или вперед текущий объект среди других игровых объектов в сцене расположенных в иерархии рядом с текущим.
```c#
rectTransform.SetAsPreviousSibling();
rectTransform.SetAsNextSibling();
```

`GetChilds` - возвращает дочерние объекты первого уровня.
```c#
var childs = transform.GetChilds();
```

`GetRandomChild` - возвращает произвольный дочерний объект.
```c#
var child = transform.GetRandomChild();
```

`AddChilds` - добавляет дочерние объекты к текущему в конец списка.
```c#
transform.AddChilds(first, second, third);
```

`DestroyChilds` - удаляет все дочерние объекты.
```c#
transform.DestroyChilds();
```

`DestroyChildsWhere` - удаляет все дочерние объекты удовлетворяющие условию.
```c#
transform.DestroyChildsWhere(c => c.name.StartsWith("abc"));
```

`DestroyChild` - удаляет дочерний объект по индексу.
```c#
transform.DestroyChild(1);
```

`DestroyFirstChild` и `DestroyLastChild` - удаляют первый и последний дочерний объект соответственно.
```c#
transform.DestroyFirstChild();
transform.DestroyLastChild();
```

`GetPreviousSiblingTransform` и `GetNextSiblingTransform` - получает компонент `Trabsform` предыдущего и следующего объекта на этом уровне соответственно.
```c#
var nextObject = transform.GetNextSiblingTransform().gameObject;
```

`SetComponentsEnabledInChildren<T>` и `SetComponentsEnabledInParents<T>` - устанавливает активность всех компонентов на этом объекте и его детях или родителях соовтественно.
```c#
transform.SetComponentsEnabledInChildren<BoxCollider>(false);
```

## GameObject
`SetComponentsEnabledInChildren<T>` и `SetComponentsEnabledInParents<T>` - устанавливает активность всех компонентов на этом объекте и его детях или родителях соовтественно.
```c#
gameObject.SetComponentsEnabledInChildren<BoxCollider>(false);
```

## Camera
`SetBackgroundColor` и `SetBackgroundColorXXX` - устанавливают цвет заднего фона камеры.
```c#
camera.SetBackgroundColorGB(1f, 0.5f);
```

`SetLensShiftX` и `SetLensShiftY` - устанавливает смещение линзы камеры.

`SetPixelRectCenter` - устанавливает центр пиксельных координат камеры на экране.

`SetPixelRectPosition` - устанавливает позицию пиксельных координат камеры на экране.

`SetPixelRectHeight` - устанавливает высоту пиксельных координат камеры на экране.

`SetPixelRectWidth` - устанавливает ширину пиксельных координат камеры на экране.

`SetPixelRectMax` - устанавливает позицию максимального угла пиксельных координат камеры на экране.

`SetPixelRectMin` - устанавливает позицию минимального угла пиксельных координат камеры на экране.

`SetPixelRectSize` - устанавливает размер пиксельных координат камеры на экране.

`SetPixelRectX` - устанавливает X позицию пиксельных координат камеры на экране.

`SetPixelRectY` - устанавливает Y позицию пиксельных координат камеры на экране.

`SetPixelRectXMax` - устанавливает максимальную X позицию пиксельных координат камеры на экране.

`SetPixelRectYMax` - устанавливает максимальную Y позицию пиксельных координат камеры на экране.

`SetPixelRectXMin` - устанавливает минимальную X позицию пиксельных координат камеры на экране.

`SetPixelRectYMin` - устанавливает минимальную Y позицию пиксельных координат камеры на экране.

`SetRectCenter` - устанавливает центр нормализованных координат камеры на экране.

`SetRectPosition` - устанавливает позицию нормализованных координат камеры на экране.

`SetRectHeight` - устанавливает высоту нормализованных координат камеры на экране.

`SetRectWidth` - устанавливает ширину нормализованных координат камеры на экране.

`SetRectMax` - устанавливает позицию максимального угла нормализованных координат камеры на экране.

`SetRectMin` - устанавливает позицию минимального угла нормализованных координат камеры на экране.

`SetRectSize` - устанавливает размер нормализованных координат камеры на экране.

`SetRectX` - устанавливает X позицию нормализованных координат камеры на экране.

`SetRectY` - устанавливает Y позицию нормализованных координат камеры на экране.

`SetRectXMax` - устанавливает максимальную X позицию нормализованных координат камеры на экране.

`SetRectYMax` - устанавливает максимальную Y позицию нормализованных координат камеры на экране.

`SetRectXMin` - устанавливает минимальную X позицию нормализованных координат камеры на экране.

`SetRectYMin` - устанавливает минимальную Y позицию нормализованных координат камеры на экране.

`SetSensorSizeX` и `SetSensorSizeY` - устанавливает размер сенсора.

`SetTransparencySortAxisX` или `SetTransparencySortAxisXXX` - устанавливает вектор вдоль которого происходит измерение расстояния до объектов. 

## Vector2 и Vector2Int
`With`, `WithX` и `WithY` - заменяет значения в указанных осях вектора и возвращает результат как копию.
```c#
Vector2.zero.With(0, 1f); // 0 - это номер оси, а 1f - значение по этой оси.

Vector2.zero.WithX(1f);
Vector2.zero.WithY(2f);
```

`GetYX` - меняет местами значения X и Y вектора и возвращает результат как копию.
```c#
Vector2.up.GetYX();
```


`InsertX` - подставляет значение в позицию X тем самым расширяя текущий вектор до трехмерного и возвращая его как результат. Вместо X можно подставлять X, Y или Z.
```c#
Vector2.zero.InsertX(1f); // [1, 0, 0]
Vector2.zero.InsertY(1f); // [0, 1, 0]
Vector2.zero.InsertZ(1f); // [0, 0, 1]

```

`MaxComponent` и `MinComponent` - возвращают максимальный и минимальный компонент вектора соответственно.
```c#
var max = new Vector2(3.14f, 7f).MaxComponent(); // вернет 7
var min = new Vector2(3.14f, 7f).MinComponent(); // вернет 3.14
```

## Vector3 и Vector3Int
`With` - заменяет значения в указанных осях вектора и возвращает результат как копию. Имеет 2 перегрузки.
```c#
Vector3.zero.With(0, 1f);
Vector3.zero.With(0, 1f, 2, 3.14f);
```

`WithX` и `WithXX` - заменяют значения в выбранных осях вектора и возвращает результат как копию. Вместо X подставляйте X, Y или Z.
```c#
Vector3.zero.WithX(1f);
Vector3.zero.WithXZ(0f, 2f);
```

`Get` - позволяет выбрать 2 или 3 компонента исходного вектора и их порядок, тем самым формируя новый двумерный или трехмерный вектор и возвращая его. Имеет 2 перегрузки.
```c#
var vector2 = new Vector3(1f, 2f, 3f).Get(0, 2); // [1f, 3f];
var vector3 = new Vector3(1f, 2f, 3f).Get(2, 0, 1); // [3f, 1f, 2f];
```

`GetXX` и `GetXXX` - позволяет по имени метода выбрать 2 или 3 компонента исходного вектора и их порядок, тем самым формируя новый двумерный или трехмерный вектор и возвращая его. Имеет множество перегрузок.
```c#
var vector2 = new Vector3(1f, 2f, 3f).GetXZ(); // [1f, 3f];
var vector3 = new Vector3(1f, 2f, 3f).GetZXY(); // [3f, 1f, 2f];
```

`InsertX` - подставляет значение в позицию X тем самым расширяя текущий вектор до четырехмерного и возвращая его как результат. Вместо X надо подставлять X, Y, Z или W.
```c#
Vector3.zero.InsertX(1f); // [1, 0, 0, 0]
Vector3.zero.InsertY(1f); // [0, 1, 0, 0]
Vector3.zero.InsertZ(1f); // [0, 0, 1, 0]
Vector3.zero.InsertW(1f); // [0, 0, 0, 1]
```

`MaxComponent` и `MinComponent` - возвращают максимальный и минимальный компонент вектора соответственно.
```c#
var max = new Vector3(3.14f, 7f, 12f).MaxComponent(); // вернет 12
var min = new Vector3(3.14f, 7f, 12f).MinComponent(); // вернет 3.14
```

## Vector4
`With` - заменяет значения в указанных осях вектора и возвращает результат как копию. Имеет 3 перегрузки.
```c#
Vector4.zero.With(0, 1f);
Vector4.zero.With(0, 1f, 2, 3.14f);
Vector4.zero.With(0, 1f, 2, 3.14f, 1, 2.17f);
```

`WithX`, `WithXX` и `WithXXX` - заменяют значения в выбранных осях вектора и возвращает результат как копию. Вместо X подставляйте X, Y, Z или W.
```c#
Vector4.zero.WithX(1f);
Vector4.zero.WithXZ(0f, 2f);
Vector4.zero.WithXZW(1f, 2f, 3f);
```

`Get` - позволяет выбрать 2, 3 или 4 компонента исходного вектора и их порядок, тем самым формируя новый двумерный, трехмерный или четырехмерный вектор и возвращая его. Имеет 3 перегрузки.
```c#
var vector2 = new Vector4(1f, 2f, 3f, 4f).Get(0, 2); // [1f, 3f];
var vector3 = new Vector4(1f, 2f, 3f, 4f).Get(2, 0, 3); // [3f, 1f, 4f];
var vector4 = new Vector4(1f, 2f, 3f, 4f).Get(2, 0, 3, 1); // [3f, 1f, 4f, 2f];
```

`GetXX`, `GetXXX` и `GetXXXX` - позволяет по имени метода выбрать 2, 3 или 4 компонента исходного вектора и их порядок, тем самым формируя новый двумерный или трехмерный вектор и возвращая его. Имеет множество перегрузок.
```c#
var vector2 = new Vector4(1f, 2f, 3f, 4f).GetXZ(); // [1f, 3f];
var vector3 = new Vector4(1f, 2f, 3f, 4f).GetZXW(); // [3f, 1f, 4f];
var vector4 = new Vector4(1f, 2f, 3f, 4f).GetZXWY(); // [3f, 1f, 4f, 2f];
```

`MaxComponent` и `MinComponent` - возвращают максимальный и минимальный компонент вектора соответственно.
```c#
var max = new Vector4(3.14f, 7f, 12f, -2f).MaxComponent(); // вернет 12
var min = new Vector4(3.14f, 7f, 12f, -2f).MinComponent(); // вернет -2
```



