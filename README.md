# Extensions 
Extensions - это методы расширения многих типов данных в Unity, что существенно упрощает решение повседневных задач при создании игр.

#№ Float и Double
`Remap` - переназначает число из начального диапазона в число конечного диапазона.
```
var x = 0.5f;
var remapedX = x.Remap(0f, 1f, 4f, 6f);
```

Переменная `RemapedX` будет равна `5f`.

## Color и Color32
`With` - заменяет значения в указанных каналах цвета и возвращает результат как копию. Имеет 3 перегрузки.
```
var green = Color.black.With(1, 1f);
var pink = Color.black.With(0, 1f, 2, 1f);
var gray = Color.black.With(0, 0.5f, 1, 0.5f, 2, 0.5f);

```

`WithX`, `WithXX` и `WithXXX` - заменяют значения в выбранных каналах цвета и возвращает результат как копию. Вместо X необходимо подставлять маркер канала (R, G, B или A).
```
var green = Color.black.WithG(1f);
var pink = Color.black.WithRB(1f, 1f);
var yellow = Color.black.WithRGA(1f, 1f, 0f); // A - альфа канал цвета
```

## Graphic
`SetColorX`, `SetColorXX` и `SetColorXXX` - устанавливает значение в выбранные каналы цвета свойства Graphic.color.
```
var image = GetComponent<Image>();

image.SetColorR(1f);
image.SetColorGB(1f, 1f);
image.SetColorRBA(0f, 0f, 0f);
```
> Класс `Image` наследован от класса `Graphic`, поэтому он также как и `Graphic` имеет эти методы.

## IComparable
`IsBetween` - проверяет находится-ли объект между двумя другими. Также принимает два дополнительных параметра - булевы значения указывающие нужно ли выполнять проверку включительно или исключительно.
```
var x = 1;
var result1 = x.IsBetween(0, 2);                // исключительно
var result2 = x.IsBetween(0, 1, true, true);    // включительно с двух сторон
```

## IEnumerable
`GetRandomElement` - возвращает произвольный элемент последовательности.
```
var list = new List<int>() { 1, 2, 3, 4, 5 };
var element = list.GetRandomElement();
```

`Except` - возвращает копию последовательности с исключенным элементом.
```
var list = new List<int>() { 1, 2, 3, 4, 5 };
list.Except(3); // [ 1, 2, 4, 5 ]
```

`Shuffled` - возвращает перемешанную копию последовательности.
```
var list = new List<int>() { 1, 2, 3, 4, 5 };
var shuffled = list.Shuffled();
```

`AsString` - возвращает строку представляющую элементы последовательности разделенных запятыми и в квадратных скобках.
```
var list = new List<int>() { 1, 2, 3, 4, 5 };
print(list.AsString());
```

## IEquatable
`EqualsToAll` - сравнивает текущий объект с переданными в метод, возвращает `true` если для всех них метод `Object.Equals` вернул истину. Передаваемые в метод объекты должны иметь такой же тип как и оригинал.
```
int x, y, z;
x = y = z = 1;

var result = x.EqualsToAll(y, z);
```

`EqualsToAny` - сравнивает текущий объект с переданными в метод, возвращает `true` если для хотя-бы одного из них метод `Object.Equals` вернул истину.  Передаваемые в метод объекты должны иметь такой же тип как и оригинал.
```
int x = 1;
int y = 1;
int z = 2;

var result = x.EqualsToAny(y, z);
```

## IList
`Pop` - удаляет указанный по индекс элементу из списка и возвращает его.
```
var list = new List<int>() { 1, 2, 3, 4, 5 };
var element = list.Pop(2);
```

`PopRandom` - удаляет произвольный элемент из списка и возвращает его.
```
var list = new List<int>() { 1, 2, 3, 4, 5 };
var element = list.PopRandom();
```

## System.Object
`EqualsToAll` - сравнивает текущий объект с переданными в метод, возвращает `true` если для всех них метод `Object.Equals` вернул истину.
```
int x, y, z;
x = y = z = 1;

var result = x.EqualsToAll(y, z);
```

`EqualsToAny` - сравнивает текущий объект с переданными в метод, возвращает `true` если для хотя-бы одного из них метод `Object.Equals` вернул истину.
```
int x = 1;
int y = 1;
int z = 2;

var result = x.EqualsToAny(y, z);
```

## Quaternion
`With` - заменяет значения в указанных осях кватерниона и возвращает результат как копию. Имеет 3 перегрузки.
```
transform.rotation.With(0, 8f);
transform.rotation.With(1, 32f, 3, -16f);
transform.rotation.With(0, 4f, 2, 8f, 3, -32);
```

`WithX`, `WithXX` и `WithXXX` - заменяют значения в выбранных осях кватерниона и возвращает результат как копию. Вместо X необходимо подставлять маркер оси (X, Y, Z или W).
```
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

## RectTransform
`SetSizeDeltaX` и `SetSizeDeltaY` - устанавливает одно из значений свойства `RectTransform.sizeDelta` в указанное значение.
```
rectTransform.SetSizeDeltaX(100f);
rectTransform.SetSizeDeltaY(200f);
```

`SetAnchorMinX` и `SetAnchorMinY` - устанавливает одно из значений свойства `RectTransform.anchorMin` в указанное значение.
```
rectTransform.SetAnchorMinX(100f);
rectTransform.SetAnchorMinY(200f);
```

`SetAnchorMaxX` и `SetAnchorMaxY` - устанавливает одно из значений свойства `RectTransform.anchorMax` в указанное значение.
```
rectTransform.SetAnchorMaxX(200f);
rectTransform.SetAnchorMaxY(400f);
```

`SetAnchoredPositionX` и `SetAnchoredPositionY` - устанавливает одно из значений свойства `RectTransform.anchoredPosition` в указанное значение.
```
rectTransform.SetAnchoredPositionX(100f);
rectTransform.SetAnchoredPositionY(100f);
```

`SetAnchoredPosition3DX` и `SetAnchoredPosition3DXX` - устанавливает выбранное значение свойства `RectTransform.anchoredPosition3D` в указанное значение. Вместо X надо подставлять X, Y или Z.
```
rectTransform.SetAnchoredPosition3DX(50f);
rectTransform.SetAnchoredPosition3DZ(0f);
rectTransform.SetAnchoredPosition3DXY(10f, 20f);
```

`SetPivotX` и `SetPivotY` - устанавливает одно из значений свойства `RectTransform.pivot` в указанное значение, со смещением элемента.
```
rectTransform.SetPivotX(100f);
rectTransform.SetPivotY(100f);
```

`SetPivotOnly`, `SetPivotOnlyX` и `SetPivotOnlyY` - устанавливает одно из значений свойства `RectTransform.pivot` в указанное значение, элемент остается на месте.
```
rectTransform.SetPivotOnlyX(100f);
rectTransform.SetPivotOnlyY(200f);
rectTransform.SetPivotOnly(100f, 200f);
```

`GetSize` - вычисляет и возвращает реальный размер элемента.
```
var size = rectTransform.GetSize();
```

## Scene
`FindObjectsOfType` - находит все объекты (включая не активные) в сцене с указанным компонентом.
```
var transforms = SceneManager.GetActiveScene().FindObjectsOfType<Transform>();
```

## SceneManager
Данный класс является вспомогательным и не хранит методов расширения.

`FindObjectsOfTypeInActiveScene` - находит все объекты (включая не активные) в активной сцене с указанным компонентом.
```
var transforms = SceneManagerExtensions.FindObjectsOfTypeInActiveScene<Transform>();
```

`FindObjectsOfTypeInOpenScenes` - находит все объекты (включая не активные) с указанным компонентом во всех открытых сценах.
```
var transforms = SceneManagerExtensions.FindObjectsOfTypeInOpenScenes<Transform>();
```

## Transform
`SetPositionX` и `SetPositionXX` - устанавливают глобальную позицию объекта по выбранной оси. Вместо X надо подставлять X, Y или Z.
```
transform.SetPositionX(1f);
transform.SetPositionYZ(2f, 3f);
```

`SetLocalPositionX` и `SetLocalPositionXX` - устанавливают локальную позицию объекта по выбранной оси. Вместо X надо подставлять X, Y или Z.
```
transform.SetLocalPositionX(1f);
transform.SetLocalPPositionYZ(2f, 3f);
```

`SetEulerAnglesX` и `SetEulerAnglesXX` - устанавливают глобальный поворот объекта по выбранной оси. Вместо X надо подставлять X, Y или Z.
```
transform.SetEulerAnglesX(45f);
transform.SetEulerAnglesYZ(0f, 90f);
```

`SetLocalEulerAnglesX` и `SetLocalEulerAnglesXX` - устанавливают локальный поворот объекта по выбранной оси. Вместо X надо подставлять X, Y или Z.
```
transform.SetLocalEulerAnglesX(45f);
transform.SetLocalEulerAnglesYZ(0f, 90f);
```

`SetLocalScaleX` и `SetLocalScaleXX` - устанавливают локальный масштаб объекта по выбранной оси. Вместо X надо подставлять X, Y или Z.
```
transform.SetLocalScaleX(2f);
transform.SetLocalScaleXZ(2f, 3f);
```

`SetAsPreviousSibling` и `SetAsNextSibling` - смещает назад или вперед текущий объект среди других игровых объектов в сцене расположенных в иерархии рядом с текущим.
```
rectTransform.SetAsPreviousSibling();
rectTransform.SetAsNextSibling();
```

`GetChilds` - возвращает дочерние объекты первого уровня.
```
var childs = transform.GetChilds();
```

`AddChilds` - добавляет дочерние объекты к текущему в конец списка.
```
transform.AddChilds(first, second, third);
```

`DestroyChilds` - удаляет все дочерние объекты.
```
transform.DestroyChilds();
```

`DestroyChildsWhere` - удаляет все дочерние объекты удовлетворящие условию.
```
transform.DestroyChildsWhere(c => c.name.StartsWith("abc"));
```

`DestroyChild` - удаляет дочерний объект по индексу.
```
transform.DestroyChild(1);
```

`DestroyFirstChild` и `DestroyLastChild` - удаляют первый и последний дочерний объект соответственно.
```
transform.DestroyFirstChild();
transform.DestroyLastChild();
```

#№ Camera
`SetBackgroundColor` и `SetBackgroundColorXXX` - устанавливают цвет заднего фона камеры.
```
camera.SetBackgroundColorG(1f);
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
`SetTransparencySortAxisX` или `SetTransparencySortAxisXXX`, где вместо X подставляются оси - устанавливает вектор вдоль которого происходит измерение расстояния до объектов. 

## Vector2 и Vector2Int
`With` - заменяет значения в указанных осях вектора и возвращает результат как копию.
```
Vector2.zero.With(0, 1f);
```

`WithX` и `WithY` - заменяют значения в выбранных осях вектора и возвращает результат как копию.
```
Vector2.zero.WithX(1f);
Vector2.zero.WithY(2f);
```

`GetYX` - меняет местами значения X и Y вектора и возвращает результат как копию.
```
Vector2.up.GetYX();
```


`InsertX` - подставляет значение в позицию X тем самым расширяя текущий вектор до трехмерного и возвращая его как результат. Вместо X надо подставлять X, Y или Z.
```
Vector2.zero.InsertX(1f); // [1, 0, 0]
Vector2.zero.InsertY(1f); // [0, 1, 0]
Vector2.zero.InsertZ(1f); // [0, 0, 1]

```

`MaxComponent` и `MinComponent` - возвращают максимальный и минимальный компонент вектора соответственно.
```
var max = new Vector2(3.14f, 7f).MaxComponent(); // вернет 7
var min = new Vector2(3.14f, 7f).MinComponent(); // вернет 3.14
```

## Vector3 и Vector3Int
`With` - заменяет значения в указанных осях вектора и возвращает результат как копию. Имеет 2 перегрузки.
```
Vector3.zero.With(0, 1f);
Vector3.zero.With(0, 1f, 2, 3.14f);
```

`WithX` и `WithXX` - заменяют значения в выбранных осях вектора и возвращает результат как копию. Вместо X подставляйте X, Y или Z.
```
Vector3.zero.WithX(1f);
Vector3.zero.WithXZ(0f, 2f);
```

`Get` - позволяет выбрать 2 или 3 компонента исходного вектора и их порядок, тем самым формируя новый двумерный или трехмерный вектор и возвращая его. Имеет 2 перегрузки.
```
var vector2 = new Vector3(1f, 2f, 3f).Get(0, 2); // [1f, 3f];
var vector3 = new Vector3(1f, 2f, 3f).Get(2, 0, 1); // [3f, 1f, 2f];
```

`GetXX` и `GetXXX` - позволяет по имени метода выбрать 2 или 3 компонента исходного вектора и их порядок, тем самым формируя новый двумерный или трехмерный вектор и возвращая его. Имеет множество перегрузок.
```
var vector2 = new Vector3(1f, 2f, 3f).GetXZ(); // [1f, 3f];
var vector3 = new Vector3(1f, 2f, 3f).GetZXY(); // [3f, 1f, 2f];
```

`InsertX` - подставляет значение в позицию X тем самым расширяя текущий вектор до четырехмерного и возвращая его как результат. Вместо X надо подставлять X, Y, Z или W.
```
Vector3.zero.InsertX(1f); // [1, 0, 0, 0]
Vector3.zero.InsertY(1f); // [0, 1, 0, 0]
Vector3.zero.InsertZ(1f); // [0, 0, 1, 0]
Vector3.zero.InsertW(1f); // [0, 0, 0, 1]
```

`MaxComponent` и `MinComponent` - возвращают максимальный и минимальный компонент вектора соответственно.
```
var max = new Vector3(3.14f, 7f, 12f).MaxComponent(); // вернет 12
var min = new Vector3(3.14f, 7f, 12f).MinComponent(); // вернет 3.14
```

## Vector4
`With` - заменяет значения в указанных осях вектора и возвращает результат как копию. Имеет 3 перегрузки.
```
Vector4.zero.With(0, 1f);
Vector4.zero.With(0, 1f, 2, 3.14f);
Vector4.zero.With(0, 1f, 2, 3.14f, 1, 2.17f);
```

`WithX`, `WithXX` и `WithXXX` - заменяют значения в выбранных осях вектора и возвращает результат как копию. Вместо X подставляйте X, Y, Z или W.
```
Vector4.zero.WithX(1f);
Vector4.zero.WithXZ(0f, 2f);
Vector4.zero.WithXZW(1f, 2f, 3f);
```

`Get` - позволяет выбрать 2, 3 или 4 компонента исходного вектора и их порядок, тем самым формируя новый двумерный, трехмерный или четырехмерный вектор и возвращая его. Имеет 3 перегрузки.
```
var vector2 = new Vector4(1f, 2f, 3f, 4f).Get(0, 2); // [1f, 3f];
var vector3 = new Vector4(1f, 2f, 3f, 4f).Get(2, 0, 3); // [3f, 1f, 4f];
var vector4 = new Vector4(1f, 2f, 3f, 4f).Get(2, 0, 3, 1); // [3f, 1f, 4f, 2f];
```

`GetXX`, `GetXXX` и `GetXXXX` - позволяет по имени метода выбрать 2, 3 или 4 компонента исходного вектора и их порядок, тем самым формируя новый двумерный или трехмерный вектор и возвращая его. Имеет множество перегрузок.
```
var vector2 = new Vector4(1f, 2f, 3f, 4f).GetXZ(); // [1f, 3f];
var vector3 = new Vector4(1f, 2f, 3f, 4f).GetZXW(); // [3f, 1f, 4f];
var vector4 = new Vector4(1f, 2f, 3f, 4f).GetZXWY(); // [3f, 1f, 4f, 2f];
```

`MaxComponent` и `MinComponent` - возвращают максимальный и минимальный компонент вектора соответственно.
```
var max = new Vector4(3.14f, 7f, 12f, -2f).MaxComponent(); // вернет 12
var min = new Vector4(3.14f, 7f, 12f, -2f).MinComponent(); // вернет -2
```



