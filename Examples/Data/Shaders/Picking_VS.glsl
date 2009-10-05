#version 120

attribute vec4 Color; // holds triangle index
attribute vec3 Position;

flat varying vec4 vColor; // must be flat, cannot have this interpolated in any way

void main()
{
  vColor = Color;
  gl_Position = gl_ModelViewProjectionMatrix * vec4(Position, 1.0);
}