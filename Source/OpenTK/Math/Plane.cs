#region License
/*
MIT License
Copyright © 2006 The Mono.Xna Team


All rights reserved.


Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:


The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.


THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License


using System;
using System.ComponentModel;

namespace OpenTK.Math
{
    
    [Serializable]
    //[TypeConverter(typeof(PlaneConverter))]
    public struct Plane : IEquatable<Plane>
    {
        #region Public Fields


        public float D;
        public Vector3 Normal;


        #endregion Public Fields

        #region Constructors


        public Plane(Vector4 value)
            : this(new Vector3(value.X, value.Y, value.Z), value.W)
        {


        }


        public Plane(Vector3 normal, float d)
        {
            Normal = normal;
            D = d;
        }


        public Plane(Vector3 a, Vector3 b, Vector3 c)
        {
            Vector3 ab = b - a;
            Vector3 ac = c - a;


            Vector3 cross = Vector3.Cross(ab, ac);
            Normal = Vector3.Normalize(cross);
            D = -(Vector3.Dot(cross, a));
        }


        public Plane(float a, float b, float c, float d)
            : this(new Vector3(a, b, c), d)
        {


        }


        #endregion Constructors

        #region Public Methods


        public static bool operator !=(Plane plane1, Plane plane2)
        {
            return !plane1.Equals(plane2);
        }


        public static bool operator ==(Plane plane1, Plane plane2)
        {
            return plane1.Equals(plane2);
        }


        public override bool Equals(object other)
        {
            return (other is Plane) ? this.Equals((Plane)other) : false;
        }


        public bool Equals(Plane other)
        {
            return ((Normal == other.Normal) && (D == other.D));
        }


        public override int GetHashCode()
        {
            return Normal.GetHashCode() ^ D.GetHashCode();
        }


        public PlaneIntersectionType Intersects(BoundingBox box)
        {
            return box.Intersects(this);
        }


        public void Intersects(ref BoundingBox box, out PlaneIntersectionType result)
        {
            result = Intersects(box);
        }


        public PlaneIntersectionType Intersects(BoundingFrustum frustum)
        {
            return frustum.Intersects(this);
        }


        public PlaneIntersectionType Intersects(BoundingSphere sphere)
        {
            return sphere.Intersects(this);
        }


        public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
        {
            result = Intersects(sphere);
        }


        public override string ToString()
        {
            return string.Format("{{Normal:{0} D:{1}}}", Normal, D);
        }


        #endregion

        #region Internal Methods

        // Indicating which side (positive/negative) of a plane a point is on.
        // Returns > 0 if on the positive side, < 0 if on the negative size, 0 if on the plane.
        internal static float ClassifyPoint(ref Vector3 point, ref Plane plane)
        {
            return point.X * plane.Normal.X + point.Y * plane.Normal.Y + point.Z * plane.Normal.Z + plane.D;
        }

        // Calculates the perpendicular distance from a point to a plane
        internal static float PerpendicularDistance(ref Vector3 point, ref Plane plane)
        {
            // dist = (ax + by + cz + d) / sqrt(a*a + b*b + c*c)
            return (float)System.Math.Abs((plane.Normal.X * point.X +
                                           plane.Normal.Y * point.Y +
                                           plane.Normal.Z * point.Z) /
                                          System.Math.Sqrt(plane.Normal.X * plane.Normal.X +
                                                           plane.Normal.Y * plane.Normal.Y +
                                                           plane.Normal.Z * plane.Normal.Z));
        }
        
        #endregion
    }
}