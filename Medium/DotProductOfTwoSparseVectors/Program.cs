using DotProductOfTwoSparseVectors;

var v1 = new SparseVector(new int[] {1,0,0,2,3});
var v2 = new SparseVector(new int[] {0,3,0,4,0});
Console.WriteLine(v1.DotProduct(v2));

v1 = new SparseVector(new int[] {0,1,0,0,2,0,0});
v2 = new SparseVector(new int[] {1,0,0,0,3,0,4});
Console.WriteLine(v1.DotProduct(v2));
