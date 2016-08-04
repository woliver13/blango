blango - stl file splitter

1. find middle of x extents
2. collect left only triangles
3. collect right only triangles
4. collect intersecting trianges
5. split intersecting triangles into 4 triangles (3 on large side one on small)
6. save off vertices of splitting lines
7. move new triangles into left and right collections
8. create surface triangles for cut 
9. copy surface triangles into both left and right collections with opposite face vectors.
10. write left and right files by extending filename with _left and _right
