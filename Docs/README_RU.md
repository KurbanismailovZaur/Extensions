# Extensions 
Extensions - это методы расширения многих типов данных в Unity, что существенно упрощает решение повседневных задач при создании игр.

## Настройка
Для работы с расширениями просто подключите пространство имен `Codomaster.Extenesions` в своем коде.

```c#
using Codomaster.Extensions;
```

### Внимание
> Многие методы расширения в данной библиотеке имеют перегрузки, которые не всегда будут рассматриваться в данной документации, однако вам не составит труда использовать их.

# Содержание
- [Transform](#transform)
    + [Позиция](#позиция)
    + [Поворот](#поворот)
    + [Масштаб](#масштаб)
    + [Сброс состояния](#сброс-состояния)
    + [Расположение в иерархии](#расположение-в-иерархии)
    + [Дочерние объекты](#дочерние-объекты)
- [Vectors](#vectors)
    + [Замена компонента](#замена-компонента)
    + [Извлечение вектора](#извлечение-вектора)
    + [Вставка компонента](#вставка-компонента)
    + [Максимальный и минимальный компонент](#максимальный-и-минимальный-компонент)
    + [Ремаппинг](#ремаппинг)
    + [Абсолютные значения](#абсолютные-значения)
    + [Инверсия компонентов вектора](#инверсия-компонентов-вектора)
    + [Ограничение вектора](#ограничение-вектора)
    + [Покомпонентное деление](#покомпонентное-деление)
    + [Проверки](#проверки)
    + [Ближайшая точка](#ближайшая-точка)
    + [Ближайшая точка на сегменте или луче](#ближайшая-точка-на-сегменте-или-луче)
    + [Поиск равномерно распределенной точки на окружности или сфере](#поиск-равномерно-распределенной-точки-на-окружности-или-сфере)
- [Quaternion](#quaternion)
    + [Замена компонента](#замена-компонента-1)
- [GameObject](#gameobject)
    + [Взаимодействие с компонентами](#взаимодействие-с-компонентами)
- [Component](#component)
    + [Взаимодействие с компонентами](#взаимодействие-с-компонентами-1)
- [CanvasScaler](#canvasscaler)
    + [Фактор масштаба](#фактор-масштаба)
- [RectTransform](#recttransform)
    + [Позиционирование элемента](#позиционирование-элемента)
- [Rect](#rect)
    + [Изменение свойств](#изменение-свойств)
- [Graphics](#graphics)
    + [Цвет элемента](#цвет-элемента)
- [Colors](#colors)
    + [Замена канала](#замена-канала)
- [Camera](#camera)
    + [Цвет заднего фона](#цвет-заднего-фона)
    + [Смещение линзы](#смещение-линзы)
    + [Пиксельные координаты камеры на экране](#пиксельные-координаты-камеры-на-экране)
    + [Нормализованные координаты камеры на экране](#нормализованные-координаты-камеры-на-экране)
    + [Размер сенсора](#размер-сенсора)
    + [Ось сортировки прозрачных объектов](#ось-сортировки-прозрачных-объектов)
    + [Преобразование глобальных координат в экранные с учетом CanvasScaler](#преобразование-глобальных-координат-в-экранные-с-учетом-canvasscaler)
- [RenderTexture](#rendertexture)
    + [Извлечение текстуры](#извлечение-текстуры)
    + [Запись в существующие текстуры](#запись-в-существующие-текстуры)
- [Scene](#scene)
    + [Поиск компонентов в сцене](#поиск-компонентов-в-сцене)
    + [Количество объектов](#количество-объектов)
    + [Ссылка на сцену](#ссылка-на-сцену)
- [Float и Double](#float-и-double)
    + [Ремаппинг](#ремаппинг-1)
    + [Приближенное сравнение (только float)](#приближенное-сравнение-только-float)
- [System.Object](#systemobject)
    + [Сравнения](#сравнения)
- [IComparable](#icomparable)
    + [Проверка на вхождение в диапазон](#проверка-на-вхождение-в-диапазон)
- [IEnumerable](#ienumerable)
    + [Рандомные элементы](#рандомные-элементы)
    + [Исключение из IEnumerable](#исключение-из-ienumerable)
    + [Цикл по элементам](#цикл-по-элементам)
    + [Преобразование в строку](#преобразование-в-строку)
- [IEquatable](#iequatable)
    + [Сравнения](#сравнения-1)
- [IList](#ilist)
    + [Извлечение элементов](#извлечение-элементов)
    + [Удаление элементов](#удаление-элементов)
- [Скрипты](#скрипты)
    + [Удаление несуществующих скриптов](#удаление-несуществующих-скриптов)
- [Атрибуты](#атрибуты)
    + [ReadOnly](#readonly)

# Transform
### Позиция
Установка новой позиции по нужной оси: SetPositionX/Y/Z/XY/XZ/YZ или SetLocalPositionX/Y/Z/XY/XZ/YZ. 
```C#
transform.SetPositionX(1f);
transform.SetLocalPositionXZ(1f, 2f);
```

### Поворот
Установка нового поворота через углы Эйлера по нужной оси: SetEulerAnglesX/Y/Z/XY/XZ/YZ или SetLocalEulerAnglesX/Y/Z/XY/XZ/YZ. 
```C#
transform.SetEulerAnglesX(45f);
transform.SetLocalEulerAnglesX(45f, 90f);
```

### Масштаб
Установка нового масштаба по нужной оси: SetLocalScale или SetLocalScaleX/Y/Z/XY/XZ/YZ. 
```C#
transform.SetLocalScale(2f); // Однородный масштаб.
transform.SetLocalScaleYZ(1f, 2f);
```

### Сброс состояния
Используйте метод Reset чтобы сбросить (сделать нулевыми позицию и поворот, а масштаб - единичным) состояние трансформации.
```C#
transform.Reset();
```

### Расположение в иерархии
Переместить на один вверх/вниз в иерархии соответственно: SetToPreviousSibling и SetToNextSibling.
```C#
transform.SetToPreviousSibling(); 
transform.SetToNextSibling(); 
```

Получить компонент `Transform` предыдущего/следующего игрового объекта соответственно: GetPreviousSiblingTransform и GetNextSiblingTransform.
```C#
transform.GetPreviousSiblingTransform(); 
transform.GetNextSiblingTransform(); 
```

Получить все объекты (их компоненты `Transform`) расположенные на том же уровне что и текущий: GetAllSiblingObjects.
```C#
var siblings = transform.GetAllSiblingObjects();
```

### Дочерние объекты
Получить все дочерние объекты: GetChilds.
```C#
var childs = transform.GetChilds();
```

Получить произвольный дочерний объект: GetRandomChild.
```C#
var child = transform.GetRandomChild();
```

Добавить дочерние объекты: AddChilds.
```C#
var childs = new List<Transform>() { child1, child2 };
transform.AddChilds(childs); // также поддерживает params массивы.
```

Удалить все дочерние объекты: DestroyChilds.
```C#
transform.DestroyChilds(); 
```

Удалить все дочерние объекты по условию: DestroyChildsWhere.
```C#
transform.DestroyChildsWhere(c => c.name == "Enemy"); 
```

Удалить дочерний объект по индексу: DestroyChild.
```C#
transform.DestroyChild(1);
```

Удалить первый дочерний объект: DestroyFirstChild.
```C#
transform.DestroyFirstChild();
```

Удалить последний дочерний объект: DestroyLastChild.
```C#
transform.DestroyLastChild();
```

# Vectors
### Замена компонента
Используйте следующие методы для замены компонента любого вектора: WithX/Y/Z/XY/XZ/XW/YZ/YW/ZW/XYZ/XYW/XZW/YZW.
```C#
// Присваиваем позицию с обнуленным значением по оси Y.
transform.position = otherTransform.position.WithY(0f);
```

### Извлечение вектора
Используйте следующие методы для извлечения вектора из любого другого вектора: Get + любая комбинация X, Y, Z и W.
```C#
var vector = GetSomeVector();

// Создаст и вернет новый вектор из компонент [z, x, y]
transform.position = vector.GetZXY(); 
```

### Вставка компонента
Используйте следующие методы для вставки компонента в вектор (кроме Vector3Int и Vector4): InsertX/Y/Z/W.
```C#
var vector2 = GetSomeVector2();

// Вставит значение 1f по оси Y.
// Из [x, y] Получится [x, 1f, y].
transform.position = vector2.InsertY(1f);
```

### Максимальный и минимальный компонент
Используйте следующие методы для получения максимального и минимального компонентов: MaxComponent и MinComponent.
```C#
var max = transform.position.MaxComponent();
print($"Max Index: {max.index}\nMax Value: {max.value}");
```

### Ремаппинг
Испольузуйте метод Remap(min1, max1, min2, max2) чтобы переназначить компоненты вектора в другой диапазон. Параметры min1 и max1 указывают начальный минимальный и максимальный значения компонентов в векторе. Параметры min2 и max2 указывают конечные. Компоненты вектора будут перерасчитаны в соотвествии с тем, как и насколько отличаются эти диапазоны.
```C#
// Метод Remap переназначит вектор [0.25, 0.5, 1] на [0.5, 1, 2],
var remapped = new Vector3(0.25f, 0.5f, 1f).Remap(0f, 1f, 0f, 2f); 
```

### Абсолютные значения
Метод Abs вернет вектор с абсолютными компонентами.
```C#
var absolutePos = transform.position.Abs();
```

### Инверсия компонентов вектора
Методы WithNegateX/Y/Z/W/XY/XZ/XW/YZ/YW/ZW/XYZ/XYW/XZW/YZW и Negate позволяют частично или полностью инвертировать вектор.
```C#
var partialNegated = transform.position.WithNegateXZ();
var fullNegated = transform.position.Negate();
```

### Ограничение вектора
Используйте методы Clamp и Clamp01 чтобы ограничить компоненты вектора нужными значениями.
```C#
var clampedPos = transform.position.Clamp01();
```

### Покомпонентное деление
Метод Devide поделит компоненты одного вектора на соответствующие компоненты другого. Vector2 на самом деле уже поддерживает такое деление с помощью оператора `/`, однако остальные типы векторов - нет. Для однородности, метод Devide также был добавлен и в Vector2.
```C#
var devided = transform.position.Divide(new Vector3(0.5f, 2f, 4f));
```

### Проверки
Используйте метод IsNan чтобы проверить является ли хотя бы один компонент вектора NaN.
```C#
var isNaN = transform.position.IsNaN();
```

Используйте метод IsUniform чтобы проверить является ли вектор однородным.
```C#
var isUniform = transform.localScale.IsUniform();
```

### Ближайшая точка
Используйте метод GetClosestPoint на любом векторе, чтобы получить ближаюшую к нему точку из указанного списка.
```C#
// GetClosestPoint также поддерживает params массивы.
var closest = transform.position.GetClosestPoint(pointsList);
print($"Point: {closest.point}\nIndex: {closest.index}");
```

### Ближайшая точка на сегменте или луче
Используйте метод GetClosestPointOnSegment на любом векторе, чтобы получить ближаюшую точку, которая лежит на указанном отрезке.
```C#
var closest = transform.position.GetClosestPointOnSegment(start, end);
target.position = closest.point;
```

Вы также можете использовать метод GetClosestPointOnRay чтобы определить ближайшую точку на луче.

### Поиск равномерно распределенной точки на окружности или сфере
Используйте метод EventlyDistributedPointOnCircle, чтобы получить равномерно распределенную точку на окружности.
```С#
var point = Vector2Extensions.EventlyDistributedPointOnCircle(0, 1f, 10);
```

Первый параметр метода — это индекс точки, которая в итоге окажется внутри круга. Второе - это радиус окружности. Count - это общее количество точек, которые окажутся внутри круга, это число должно быть известно заранее.

![image](https://user-images.githubusercontent.com/5365111/198890643-d9570ba8-8e3f-4d02-b852-544a5dc7151e.png)

Вы также можете использовать метод EventlyDistributedPointOnSphere для поиска точки на сфере.

# Quaternion
### Замена компонента
Используйте следующие методы для замены компонента кватерниона: WithX/Y/Z/XY/XZ/XW/YZ/YW/ZW/XYZ/XYW/XZW/YZW.
```C#
var rotation = transform.rotation.WithW(0f);
```

# GameObject
### Взаимодействие с компонентами
Используйте метод GetOrAddComponent чтобы получить уже существующий компонент на игровом объекте, или, если его нет, создать и получить его.
```C#
var collider = gameObject.GetOrAddComponent<BoxCollider>();
```

Используйте TryGetComponentInChildren и TryGetComponentInParent чтобы найти компонент на дочерних или родительских объектах (включая текущий).
```C#
if(gameObject.TryGetComponentInChildren<Renderer>(out Renderer renderer)) { ... }
```

# Component
### Взаимодействие с компонентами
Используйте метод GetOrAddComponent чтобы получить уже существующий компонент на текущем игровом объекте, или, если его нет, создать и получить его. Так как от класса `Component` наследуются все скрипты, вы также можете использовать ключевое слово `this`.
```C#
var collider = transform.GetOrAddComponent<BoxCollider>();
```

Используйте TryGetComponentInChildren и TryGetComponentInParent чтобы найти компонент на дочерних или родительских объектах (включая текущий).
```C#
if(transform.TryGetComponentInChildren<Renderer>(out BoxCollider collider)) { ... }
```

# CanvasScaler
### Фактор масштаба
Метод GetScaleFactor автоматически расчитает и вернет фактор масштаба для `CanvasScaler`, который работает в режиме `CanvasScaler.ScaleMode.ScaleWithScreenSize`.
```C#
var factor = canvasScaler.GetScaleFactor();
```

# RectTransform
### Позиционирование элемента
Используйте методы SetSizeDeltaX/Y для установки размера элемента.
```C#
rectTransform.SetSizeDeltaY(100f);
```

Используйте методы SetAnchorMinX/Y и SetAnchorMaxX/Y для установки позиции якорей.
```C#
rectTransform.SetAnchorMaxX(1f);
```

Используйте методы SetOffsetMinX/Y и SetOffsetMaxX/Y для установки смещения от краев. Вы также можете использовать методы SetLeft, SetTop, SetRight и SetBottom, которые делают то же самое.
```C#
// Смещение от нижней части якорей на 100 единиц.
rectTransform.SetBottom(100f);
```

Используйте методы SetAnchoredPositionX/Y и SetAnchoredPosition3DX/Y/Z/XY/XZ/YZ для установки позиции относительно якорей.
```C#
rectTransform.SetAnchoredPositionX(0f);
```

Используйте методы SetPivotX/Y для установки точки опоры (он же pivot point) элемента. Изменение точки опоры приведет к изменению положения элемента относительно родителя.
```C#
rectTransform.SetPivotX(0.5f);
```

Используйте методы SetPivotOnlyX/Y для установки точки опоры (он же pivot point) элемента без изменения положения элемента относительно родителя.
```C#
rectTransform.SetPivotOnlyY(1f);
```

# Rect
### Изменение свойств
Вы можете использовать следующие методы для изменения (на копии) свойства объекта `Rect`: WithCenter, WithPosition, WithHeight, WithWidth, WithMax, WithMin, WithSize, WithX, WithY, WithXMax, WithXMin, WithYMax, и WithYMin.
```C#
var rect = (transform as RectTransform).rect.WithHeight(400f);
```

# Graphics
### Цвет элемента
Установка цвета в любой канал графического UI-элемента: SetColorR/G/B/A/RG/RB/RA/GB/GA/BA/RGB/RGA/RBA/GBA.
```C#
image.SetColorA(0); // Установливаем 0 в альфа канал цвета компонента Image.
```

# Colors
### Замена канала
Замена значения любого канала цвета: WithR/G/B/A/RG/RB/RA/GB/GA/BA/RGB/RGA/RBA/GBA.
```C#
image.color = someColor.WithR(1f);
```

# Camera
### Цвет заднего фона
Изменяйте цвет заднего фона с помощью следующих методов: SetBackgroundColorR/G/B/A/RG/RB/RA/GB/GA/BA/RGB/RGA/RBA/GBA.
```
Camera.main.SetBackgroundColorRB(1f, 1f);
```

### Смещение линзы
Изменяйте смещение линзы с помощью методов SetLensShiftX и SetLensShiftY.
```C#
Camera.main.SetLensShiftX(1f);
```

### Пиксельные координаты камеры на экране
Изменяйте любое свойство пиксельных координат камеры на экране с помощью следующих методов: SetPixelRectCenter, SetPixelRectPosition, SetPixelRectHeight, SetPixelRectWidth, SetPixelRectMax, SetPixelRectMin, SetPixelRectSize, SetPixelRectX, SetPixelRectY, SetPixelRectXMax, SetPixelRectYMax, SetPixelRectXMin, SetPixelRectYMin.
```C#
Camera.main.SetPixelRectXMin(125f);
```

### Нормализованные координаты камеры на экране
Изменяйте любое свойство нормализованных координат камеры на экране с помощью следующих методов: SetRectCenter, SetRectPosition, SetRectHeight, SetRectWidth, SetRectMax, SetRectMin, SetRectSize, SetRectX, SetRectY, SetRectXMax, SetRectYMax, SetRectXMin, SetRectYMin.
```C#
Camera.main.SetRectMax(new Vector2(1f, 1f));
```

### Размер сенсора
Используйте методы SetSensorSizeX и SetSensorSizeY чтобы установить размер сенсора камеры.
```C#
Camera.main.SetSensorSizeX(25f);
```

### Ось сортировки прозрачных объектов
Методы SetTransparencySortAxisX/Y/Z/XY/XZ/YZ установят ось сортировки прозрачных объектов.
```C#
Camera.main.SetTransparencySortAxisX(1f);
```

### Преобразование глобальных координат в экранные с учетом CanvasScaler
Используйте WorldToScreenPoint чтобы преобразовать глобальные координаты в экранные с учетом компонента CanvasScaler. Метод автоматически учтет
```C#
var position = GetSomePosition();
var scaler = GetComponentInParent<CanvasScaler>();
var point = Camera.main.WorldToScreenPoint(position, scaler);
```

# RenderTexture
### Извлечение текстуры
Используйте метод ToTexture2D чтобы извлечь текстуру из RenderTexture.
```C#
var texture = renderTexture.ToTexture2D(TextureFormat.ARGB32);
```

Используйте метод ToSprite чтобы извлечь спрайт из RenderTexture.
```C#
image.sprite = renderTexture.ToSprite(TextureFormat.ARGB32);
```

### Запись в существующие текстуры
Используйте метод WriteToTexture2D чтобы обновить существующую текстуру в соответствии с изображением в RenderTexture.
```C#
renderTexture.WriteToTexture2D(texture);
```

Используйте метод WriteToSprite чтобы обновить существующий спрайт в соответствии с изображением в RenderTexture.
```C#
renderTexture.WriteToSprite(sprite);
```

# Scene
### Поиск компонентов в сцене
Используйте FindObjectOfType и FindObjectsOfType чтобы искать объекты с указанным компонентом в сцене.
```C#
var renderer = gameObject.scene.FindObjectOfType<SkinnedMeshRenderer>(includeInactive: true);
```

### Количество объектов
Метод ObjectsCount вернет общее количество объектов в сцене.
```C#
print(gameObject.scene.ObjectsCount());
```

### Ссылка на сцену
Теперь вы можете ссылаться на сцену прямо из поля любого скрипта. Для этого объявите поля типа `SceneReference`. В коде используйте член `Path`, чтобы получить путь сцены, или просто укажите объект сцены, чтобы использовать неявное приведение типа `SceneReference` в `string`.
```C#
// Объявляем поле в любом скрипте.
public SceneReference _scene;

// ...

SceneManager.LoadScene(_scene);
```

![SceneReference](https://user-images.githubusercontent.com/5365111/198889672-f7d76d01-96c2-43de-bde2-c010b07d6170.gif)

# Float и Double
### Ремаппинг
Используйте метод Remap, чтобы переназначить значение в одном диапазоне в значение в другом.
```C#
var x = 0.25f;
var remapped = x.Remap(0f, 1f, 0f, 2f);
```

### Приближенное сравнение (только float)
Числа с плавяющей точкой не рекомендуется сравнивать жестко, вместо этого лучше использовать метод приближенного сравнения Approximately, которые исключает возможное непредсказуемое поведение.
```C#
var x = 1f / 3f;
bool result = x.Approximately(0.3333333f);
```

# System.Object
### Сравнения
Используйте методы EqualsToAll и EqualsToAny, чтобы определить равенство всем или хотя бы одному объекту из указанного списка соответственно.
```C#
var values = new int[] { 4, 1, 7, 2, 9 };
var x = Random.Range(0, 10);

if (x.EqualsToAny(values)) { ... }
```

# IComparable
### Проверка на вхождение в диапазон
Используйте метод IsBetween на любом IComparable объекте, чтобы определить находится ли он между двух указанных значений или нет. Можно использовать не только числа.
```C#
var x = 0.5f;
var isBetween = x.IsBetween(0f, 1f);
```

# IEnumerable
### Рандомные элементы
Используйте GetRandomElement и GetRandomElements чтобы получить рандомный элемент или элементы.
```
var element = list.GetRandomElement();
```

Используй GetRandomElementWithProbability чтобы получить рандомный элемент по их вероятностям. Например у вас есть массив `words` содержащий 3 строки `["hello", "bye", "..."]` и допустим вы хотите получить одну из них со следующими соотвествующими вероятностями `[35%, 50%, 25%]`. Тогда вы можете вызвать на них метод GetRandomElementWithProbability следующим образом:
```C#
var words = new string[] {"hello", "bye", "..."};
var random = words.GetRandomElementWithProbability(35f, 50f, 25f); // Также можно передавать массивы, списки и прочие.

print($"Element: {random.element}\nIndex: {random.index}");
```

Используйте метод Shuffled чтобы перемешать элементы.
```C#
var list = new List<int>() { 0, 1, 2, 3 ,4 ,5};
var shuffled = list.Shuffled(); // Будут перемешанны.
```

### Исключение из IEnumerable
Используйте метод Except чтобы исключить объект из коллекции.
```C#
var listWithoutExcepted = list.Except(someObject);
```

### Цикл по элементам
Метод ForEach позволяет организовать цикл по элементам коллекции.
```
objects.ForEach(o => print(o.name));
```

### Преобразование в строку
Используйте AsString чтобы преобразовать любую коллекцию в строку в формате `"[1, 2, 3]"`.
```C#
var array = new int[] { 4, -7, 12, 1, 0 };
print(array.AsString()); // Выведет в консоль -> [4, -7, 12, 1, 0]
```

# IEquatable
### Сравнения
Используйте методы EqualsToAll и EqualsToAny, чтобы определить равенство всем или хотя бы одному объекту из указанного списка соответственно. В отличии от аналогичных методов расширений у System.Object, данные методы работают с конкретными типами.
```C#
var values = new int[] { 4, 1, 7, 2, 9 };
var x = Random.Range(0, 10);

if (x.EqualsToAny(values)) { ... }
```

# IList
### Извлечение элементов
Используйте метод Pop чтобы извлечь элемент из списка. Извлеченные элемент удаляется из списка. Можно извлекать несколько элементов за раз.
```
var popped = list.Pop(4); // Извлекли элемент по индексу 4.
```

Используйте методы PopRandom и PopRandoms чтобы извлекать рандомный элемент/ы из списка. Извлеченный элемент удаляется из списка.
```
var popped = list.PopRandoms(2); // Извлекли 2 рандомных элемента.
```

Используйте метод PopRandomElementWithProbability чтобы извлечь рандомный элемент с учетом вероятностей. В примере ниже значение 1 выпадет с вероятностью 50%, 2 - 30%, а 3 - 20%.
```
var list = new List<int>() { 1, 2, 3 };
var popped = list.PopRandomElementWithProbability(50f, 30f, 20f);

print($"Element: {popped.element}\nIndex: {popped.index}");
```

### Удаление элементов
Используйте метод RemoveRange чтобы удалить все элементы начиная с указанного индекса.
```C#
list.RemoveRange(3); // Удалит начиная с 3 индекса и до конца.
```

# Скрипты
### Удаление несуществующих скриптов
Вы можете выделить игровые объекты в окне иерархии или префабы в окне проекта, вызвать контекстное меню и выбрать `Remove Missing Scripts`, чтобы удалить все скрипты, которых больше нет в проекте. В окне консоли появится подробная информация о результате операции. При удалении отсутствующих скриптов на префабах, они также будут удалены на экхемплярах в сцене и наоборот.

![image](https://user-images.githubusercontent.com/5365111/198891225-9f4ebd8c-61ab-4501-92ad-a5b56cbc0501.png)
![image](https://user-images.githubusercontent.com/5365111/198891880-2a99a252-1b5f-445f-b1f4-41295d9b045b.png)
