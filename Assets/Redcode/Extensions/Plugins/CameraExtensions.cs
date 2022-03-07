using UnityEngine;

namespace Redcode.Extensions
{
    public static class CameraExtensions
    {
        /// <summary>
        /// Set red channel of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        public static void SetBackgroundColorR(this Camera camera, float r) => camera.backgroundColor = camera.backgroundColor.WithR(r);

        /// <summary>
        /// Set green channel of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        public static void SetBackgroundColorG(this Camera camera, float g) => camera.backgroundColor = camera.backgroundColor.WithG(g);

        /// <summary>
        /// Set blue channel of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorB(this Camera camera, float b) => camera.backgroundColor = camera.backgroundColor.WithB(b);

        /// <summary>
        /// Set alpha channel of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorA(this Camera camera, float a) => camera.backgroundColor = camera.backgroundColor.WithA(a);

        /// <summary>
        /// Set red and green channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="g">Value of the green channel.</param>
        public static void SetBackgroundColorRG(this Camera camera, float r, float g) => camera.backgroundColor = camera.backgroundColor.WithRG(r, g);

        /// <summary>
        /// Set red and blue channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorRB(this Camera camera, float r, float b) => camera.backgroundColor = camera.backgroundColor.WithRB(r, b);

        /// <summary>
        /// Set red and alpha channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorRA(this Camera camera, float r, float a) => camera.backgroundColor = camera.backgroundColor.WithRA(r, a);

        /// <summary>
        /// Set green and blue channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorGB(this Camera camera, float g, float b) => camera.backgroundColor = camera.backgroundColor.WithGB(g, b);

        /// <summary>
        /// Set green and alpha channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorGA(this Camera camera, float g, float a) => camera.backgroundColor = camera.backgroundColor.WithGA(g, a);

        /// <summary>
        /// Set blue and alpha channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="b">Value of the blue channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorBA(this Camera camera, float b, float a) => camera.backgroundColor = camera.backgroundColor.WithBA(b, a);

        /// <summary>
        /// Set red, green and blue channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorRGB(this Camera camera, float r, float g, float b) => camera.backgroundColor = camera.backgroundColor.WithRGB(r, g, b);

        /// <summary>
        /// Set red, green and alpha channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorRGA(this Camera camera, float r, float g, float a) => camera.backgroundColor = camera.backgroundColor.WithRGA(r, g, a);

        /// <summary>
        /// Set red, blue and alpha channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorRBA(this Camera camera, float r, float b, float a) => camera.backgroundColor = camera.backgroundColor.WithRBA(r, b, a);

        /// <summary>
        /// Set green, blue and alpha channels of camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorGBA(this Camera camera, float g, float b, float a) => camera.backgroundColor = camera.backgroundColor.WithGBA(g, b, a);

        /// <summary>
        /// Set x component if lens shift.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">Value of the x component.</param>
        public static void SetLensShiftX(this Camera camera, float x) => camera.lensShift = camera.lensShift.WithX(x);

        /// <summary>
        /// Set y component if lens shift.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="y">Value of the y component.</param>
        public static void SetLensShiftY(this Camera camera, float y) => camera.lensShift = camera.lensShift.WithY(y);

        /// <summary>
        /// Set pixel rect center of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="center">Value to set.</param>
        public static void SetPixelRectCenter(this Camera camera, Vector2 center) => camera.pixelRect = camera.pixelRect.WithCenter(center);

        /// <summary>
        /// Set pixel rect position of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="position">Value to set.</param>
        public static void SetPixelRectPosition(this Camera camera, Vector2 position) => camera.pixelRect = camera.pixelRect.WithPosition(position);

        /// <summary>
        /// Set pixel rect height of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="height">Value to set.</param>
        public static void SetPixelRectHeight(this Camera camera, float height) => camera.pixelRect = camera.pixelRect.WithHeight(height);

        /// <summary>
        /// Set pixel rect width of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="width">Value to set.</param>
        public static void SetPixelRectWidth(this Camera camera, float width) => camera.pixelRect = camera.pixelRect.WithWidth(width);

        /// <summary>
        /// Set pixel rect max point of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="max">Value to set.</param>
        public static void SetPixelRectMax(this Camera camera, Vector2 max) => camera.pixelRect = camera.pixelRect.WithMax(max);

        /// <summary>
        /// Set pixel rect min point of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="min">Value to set.</param>
        public static void SetPixelRectMin(this Camera camera, Vector2 min) => camera.pixelRect = camera.pixelRect.WithMin(min);

        /// <summary>
        /// Set pixel rect size of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="size">Value to set.</param>
        public static void SetPixelRectSize(this Camera camera, Vector2 size) => camera.pixelRect = camera.pixelRect.WithSize(size);

        /// <summary>
        /// Set pixel rect x value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPixelRectX(this Camera camera, float x) => camera.pixelRect = camera.pixelRect.WithX(x);

        /// <summary>
        /// Set pixel rect y value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPixelRectY(this Camera camera, float y) => camera.pixelRect = camera.pixelRect.WithY(y);

        /// <summary>
        /// Set pixel rect x max value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="xMax">Value to set.</param>
        public static void SetPixelRectXMax(this Camera camera, float xMax) => camera.pixelRect = camera.pixelRect.WithXMax(xMax);

        /// <summary>
        /// Set pixel rect y max value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="yMax">Value to set.</param>
        public static void SetPixelRectYMax(this Camera camera, float yMax) => camera.pixelRect = camera.pixelRect.WithYMax(yMax);

        /// <summary>
        /// Set pixel rect x min value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="xMin">Value to set.</param>
        public static void SetPixelRectXMin(this Camera camera, float xMin) => camera.pixelRect = camera.pixelRect.WithXMin(xMin);

        /// <summary>
        /// Set pixel rect y min value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="yMin">Value to set.</param>
        public static void SetPixelRectYMin(this Camera camera, float yMin) => camera.pixelRect = camera.pixelRect.WithYMin(yMin);

        /// <summary>
        /// Set rect center value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="center">Value to set.</param>
        public static void SetRectCenter(this Camera camera, Vector2 center) => camera.rect = camera.rect.WithCenter(center);

        /// <summary>
        /// Set rect position value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="position">Value to set.</param>
        public static void SetRectPosition(this Camera camera, Vector2 position) => camera.rect = camera.rect.WithPosition(position);

        /// <summary>
        /// Set rect height value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="height">Value to set.</param>
        public static void SetRectHeight(this Camera camera, float height) => camera.rect = camera.rect.WithHeight(height);

        /// <summary>
        /// Set rect width value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="width">Value to set.</param>
        public static void SetRectWidth(this Camera camera, float width) => camera.rect = camera.rect.WithWidth(width);

        /// <summary>
        /// Set rect max point value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="max">Value to set.</param>
        public static void SetRectMax(this Camera camera, Vector2 max) => camera.rect = camera.rect.WithMax(max);

        /// <summary>
        /// Set rect min point value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="min">Value to set.</param>
        public static void SetRectMin(this Camera camera, Vector2 min) => camera.rect = camera.rect.WithMin(min);

        /// <summary>
        /// Set rect size value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="size">Value to set.</param>
        public static void SetRectSize(this Camera camera, Vector2 size) => camera.rect = camera.rect.WithSize(size);

        /// <summary>
        /// Set rect x value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">Value to set.</param>
        public static void SetRectX(this Camera camera, float x) => camera.rect = camera.rect.WithX(x);

        /// <summary>
        /// Set rect y value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="y">Value to set.</param>
        public static void SetRectY(this Camera camera, float y) => camera.rect = camera.rect.WithY(y);

        /// <summary>
        /// Set rect x max value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="xMax">Value to set.</param>
        public static void SetRectXMax(this Camera camera, float xMax) => camera.rect = camera.rect.WithXMax(xMax);

        /// <summary>
        /// Set rect y max value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="yMax">Value to set.</param>
        public static void SetRectYMax(this Camera camera, float yMax) => camera.rect = camera.rect.WithYMax(yMax);

        /// <summary>
        /// Set rect x min value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="xMin">Value to set.</param>
        public static void SetRectXMin(this Camera camera, float xMin) => camera.rect = camera.rect.WithXMin(xMin);

        /// <summary>
        /// Set rect y min value of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="yMin">Value to set.</param>
        public static void SetRectYMin(this Camera camera, float yMin) => camera.rect = camera.rect.WithYMin(yMin);

        /// <summary>
        /// Set sensor size x of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">Value to set.</param>
        public static void SetSensorSizeX(this Camera camera, float x) => camera.sensorSize = camera.sensorSize.WithX(x);

        /// <summary>
        /// Set sensor size y of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="y">Value to set.</param>
        public static void SetSensorSizeY(this Camera camera, float y) => camera.sensorSize = camera.sensorSize.WithY(y);

        /// <summary>
        /// Set transparency sort axis x of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">Value to set.</param>
        public static void SetTransparencySortAxisX(this Camera camera, float x) => camera.transparencySortAxis = camera.transparencySortAxis.WithX(x);

        /// <summary>
        /// Set transparency sort axis y of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="y">Value to set.</param>
        public static void SetTransparencySortAxisY(this Camera camera, float y) => camera.transparencySortAxis = camera.transparencySortAxis.WithY(y);

        /// <summary>
        /// Set transparency sort axis z of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="z">Value to set.</param>
        public static void SetTransparencySortAxisZ(this Camera camera, float z) => camera.transparencySortAxis = camera.transparencySortAxis.WithZ(z);

        /// <summary>
        /// Set transparency sort x and y axes of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">X axis value to set.</param>
        /// <param name="y">Y axis value to set.</param>
        public static void SetTransparencySortAxisXY(this Camera camera, float x, float y) => camera.transparencySortAxis = camera.transparencySortAxis.WithXY(x, y);

        /// <summary>
        /// Set transparency sort x and y axes of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="vector">Vector to set.</param>
        public static void SetTransparencySortAxisXY(this Camera camera, Vector2 vector) => camera.transparencySortAxis = camera.transparencySortAxis.WithXY(vector.x, vector.y);

        /// <summary>
        /// Set transparency sort x and y axes of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="x">X axis value to set.</param>
        /// <param name="z">Z axis value to set.</param>
        public static void SetTransparencySortAxisXZ(this Camera camera, float x, float z) => camera.transparencySortAxis = camera.transparencySortAxis.WithXZ(x, z);

        /// <summary>
        /// Set transparency sort x and z axes of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="vector">Vector to set.</param>
        public static void SetTransparencySortAxisXZ(this Camera camera, Vector2 vector) => camera.transparencySortAxis = camera.transparencySortAxis.WithXZ(vector.x, vector.y);

        /// <summary>
        /// Set transparency sort y and z axes of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="y">Y axis value to set.</param>
        /// <param name="z">Z axis value to set.</param>
        public static void SetTransparencySortAxisYZ(this Camera camera, float y, float z) => camera.transparencySortAxis = camera.transparencySortAxis.WithYZ(y, z);

        /// <summary>
        /// Set transparency sort y and z axes of the camera.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="vector">Vector to set.</param>
        public static void SetTransparencySortAxisYZ(this Camera camera, Vector2 vector) => camera.transparencySortAxis = camera.transparencySortAxis.WithYZ(vector.x, vector.y);
    }
}