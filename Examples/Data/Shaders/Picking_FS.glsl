#version 120

flat varying vec4 vColor;

void main()
{
  gl_FragData[0] = vColor; //vec4( vColor.r, vColor.r, vColor.r, 1.0); // just using *some* color to distinguish triangles from another
  gl_FragData[1] = vColor;
}