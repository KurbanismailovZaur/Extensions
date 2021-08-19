using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

namespace Extensions
{
    public static class Random
    {
        #region Names
        private static readonly string[] _names = new string[] { "Oliver", "Jack", "Harry", "Jacob", "Charlie", "Thomas", "George", "Oscar", "James", "William" };

        private static readonly string[] _surnames = new string[] { "Smith", "Jones", "Taylor", "Williams", "Brown", "White", "Harris", "Martin", "Davies", "Wilson" };

        private static readonly string[] _patronymics = new string[] { "Adamson", "Bennison", "Coxon", "Davidson", "Emberson", "Fillary", "Gibbs", "Hendison", "Jackson", "Patterson" };

        public static string Name() => _names.GetRandomElement();

        public static string Surame() => _surnames.GetRandomElement();

        public static string Patronymic() => _patronymics.GetRandomElement();

        public static string Fullname() => $"{_names.GetRandomElement()} {_surnames.GetRandomElement()}";

        public static string NamePatronymic() => $"{_names.GetRandomElement()} {_patronymics.GetRandomElement()}";

        public static string FullnamePatronymic() => $"{_names.GetRandomElement()} {_surnames.GetRandomElement()} {_patronymics.GetRandomElement()}";
        #endregion

        public static Quaternion RotationUniform => UnityRandom.rotationUniform;

        public static Quaternion Rotation => UnityRandom.rotation;

        public static Vector3 OnUnitSphere => UnityRandom.onUnitSphere;

        public static Vector2 InsideUnitCircle => UnityRandom.insideUnitCircle;

        public static UnityRandom.State State
        {
            get => UnityRandom.state;
            set => UnityRandom.state = value;
        }

        public static float Value => UnityRandom.value;

        public static Vector3 InsideUnitSphere => UnityRandom.insideUnitSphere;

        public static Color ColorHSV() => UnityRandom.ColorHSV();

        public static Color ColorHSV(float hueMin, float hueMax) => UnityRandom.ColorHSV(hueMin, hueMax);

        public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax) => UnityRandom.ColorHSV(hueMin, hueMax, saturationMin, saturationMax);

        public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax) => UnityRandom.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax);

        public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) => UnityRandom.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, alphaMin, alphaMax);

        public static void InitState(int seed) => UnityRandom.InitState(seed);

        public static int Range(int minInclusive, int maxExclusive) => UnityRandom.Range(minInclusive, maxExclusive);

        public static float Range(float minInclusive, float maxInclusive) => UnityRandom.Range(minInclusive, maxInclusive);

        public static int Probability(params float[] probabilities)
        {
            if (probabilities.Length == 0)
                throw new ArgumentException($"Probabilities can't an array woth zero length");

            if (probabilities.Any(p => p <= 0f))
                throw new ArgumentException($"Probabilities can't be less then or equal to zero");

            var multiplier = 1f / probabilities.Sum();

            for (int i = 0; i < probabilities.Length; i++)
                probabilities[i] *= multiplier;

            var random = UnityEngine.Random.value;
            var sum = 0f;

            for (int i = 0; i < probabilities.Length - 1; i++)
            {
                sum += probabilities[i];

                if (random <= sum)
                    return i;
            }

            return probabilities.Length - 1;
        }
    }
}