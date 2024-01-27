Extensions is a package that contains many extension methods for popular classes in Unity that you can use to write more expressive and concise code.

For example:
```C#
// Setting a new global position along the desired axis.
transform.SetPositionX(1f);

// Setting local rotation through Euler angles along the desired axex.
transform.SetLocalEulerAnglesXZ(45f, 90f);

// Reset the transformation state to default values (position and rotation to zero, scale to one).
transform.Reset();

// Moves one position down in the hierarchy.
transform.SetToNextSibling();

// Returns all child objects.
var childs = transform.GetChilds();

// Will delete all child objects based on condition.
transform.DestroyChildsWhere(c => c.name == "Enemy");

// Assign a position with a zeroed value along the Y axis.
transform.position = otherTransform.position.WithY(0f);

// Create and return a new vector from components [z, x, y]
transform.position = vector.GetZXY();

// Inserts the value 1f along the Y axis. From [x, y] You get [x, 1f, y].
transform.position = vector2.InsertY(1f);

// Partially inverts a vector:
var partialNegated = transform.position.WithNegateXZ();

// Will check if the vector is homogeneous:
var isUniform = transform.localScale.IsUniform();

// Returns the point closest to the vector (used as the position in space) from the specified list.
var closest = transform.position.GetClosestPoint(pointsList);
print($"Point: {closest.point}\nIndex: {closest.index}");

// We get a return beam, the beginning of which begins at 10 meters along the original beam.
var reversed = ray.Reversed(10f);

// Returns a ray deviated from its original direction by a random angle.
var deflected = ray.RandomDeflected(45f);

// Returns a copy with the color channel value changed.
image.color = someColor.WithGA(1f, 0.5f);

// Will reassign a value in one range to a value in another.
var x = 0.25f;
var remapped = x.Remap(0f, 1f, 0f, 2f);

// Returns a random element.
var element = list.GetRandom();
var elements = list.GetRandoms(3);

// Will return a random element according to their probabilities (in this example: hello = 35%, bye = 50%, ok = 25%).
var words = new string[] {"hello", "bye", "ok"};
var random = words.GetRandomWithProbability(35f, 50f, 25f);

// Returns a shuffled list.
var shuffled = list.Shuffled();

// Converts any collection to a string in the format "[1, 2, 3]".
var array = new int[] { 4, -7, 12, 1, 0 };
print(array.AsString()); // Prints to the console -> [4, -7, 12, 1, 0]

// Retrieves an element from a list. You can retrieve multiple items at once.
var popped = list.Pop(4); // Retrieved the element at index 4.

// Retrieves random elements from a list.
var popped = list.PopRandoms(2); // Extracted 2 random elements.
```

And many other extensions! Read more on the <a href="https://github.com/KurbanismailovZaur/Extensions/wiki">wiki page</a>
